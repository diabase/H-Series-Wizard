﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DiabasePrintingWizard
{
    class GCodeProcessor
    {
        private static readonly double DefaultFeedrate = 3000.0 / 60.0;         // see RRF in Configuration.h

        private static readonly double ToolChangeDuration = 4.0;                // in s
        private static readonly double ToolChangeDurationWithCleaning = 10.0;   // in s

        private FileStream input;
        private SettingsContainer settings;
        private IList<OverrideRule> rules;
        private Duet.MachineInfo machineInfo;
        private IProgress<int> progress;
        private IProgress<int> maxProgress;

        private List<GCodeLayer> layers;

        private List<bool> toolPrimed;
        private double toolChangeRetractionDistance = 10.0;
        private double toolChangeRetractionSpeed = 3600;

        private class Coordinate
        {
            public double X;
            public double Y;
            public double Z;

            public Coordinate Clone() => new Coordinate { X = X, Y = Y, Z = Z };
            public void AssignFrom(Coordinate coord) { X = coord.X; Y = coord.Y; Z = coord.Z; }
        };
        private Coordinate lastPoint;

        public GCodeProcessor(FileStream stream, SettingsContainer preferences, IList<OverrideRule> ruleSet, Duet.MachineInfo machine,
            IProgress<int> setProgress, IProgress<int> setMaxProgress)
        {
            input = stream;
            settings = preferences;
            rules = ruleSet;
            machineInfo = machine;
            progress = setProgress;
            maxProgress = setMaxProgress;

            layers = new List<GCodeLayer>();
            toolPrimed = new List<bool>();
            for(int i = 0; i < preferences.Tools.Length; i++)
            {
                toolPrimed.Add(false);
            }
            lastPoint = new Coordinate();
        }

        // Split up the G-code file into different segments holding corresponding G-code lines plus feedrate
        // Each segment is created when
        // - the tool number OR
        // - the print region as indicated by S3D ("; feature..." or "; ...")
        // changes.
        // These segments are combined later on in the post-processing step
        public async Task PreProcess()
        {
            StreamReader reader = new StreamReader(input);
            string lineBuffer = await reader.ReadLineAsync();
            if (lineBuffer == null)
            {
                throw new ProcessorException("File is empty");
            }

            if (lineBuffer.Contains("G-Code generated by Simplify3D(R)"))
            {
                maxProgress.Report((int)input.Length);

                double feedrate = DefaultFeedrate;
                int lineNumber = 1, numExtrusions = 0;
                bool isInterfacingSet = true;
                GCodeLayer layer = new GCodeLayer(0, 0.0), lastLayer = null;
                GCodeSegment segment = new GCodeSegment("Initialization", -1, null);
                layer.Segments.Add(segment);

                do
                {
                    bool writeLine = true;
                    GCodeLine line = new GCodeLine(lineBuffer);

                    if (lineBuffer.StartsWith(";"))
                    {
                        if (lineBuffer.StartsWith("; layer "))
                        {
                            // Add past layer
                            layers.Add(layer);
                            lastLayer = layer;

                            // Get the Z height. S3D provides it via the comment except before the end
                            string lastParameter = lineBuffer.Split(' ').Last();
                            double zHeight = (lastParameter == "end") ? double.NaN : double.Parse(lastParameter);

                            // Create a new one
                            layer = new GCodeLayer(layer.Number + 1, zHeight);
                            segment = new GCodeSegment(segment.Name, segment.Tool, segment);
                            layer.Segments.Add(segment);
                            isInterfacingSet = layer.Number < 2;
                        }
                        else if ((layer.Number == 0 && lineNumber > 2 && !lineBuffer.Contains("layerHeight")) ||
                            lineBuffer.StartsWith("; tool") || lineBuffer.StartsWith("; process"))
                        {
                            // Keep first two comment lines but get rid of S3D process description and
                            // remove "; tool" as well as "; process" lines because they are completely useless
                            writeLine = false;

                            // Try to get the tool change parameters
                            if (lineBuffer.Contains("toolChangeRetractionDistance"))
                            {
                                double? value = line.GetFValue(',');
                                if (value != null) { toolChangeRetractionDistance = value.Value; }
                            }
                            if (lineBuffer.Contains("toolChangeRetractionSpeed"))
                            {
                                double? value = line.GetFValue(',');
                                if (value != null) { toolChangeRetractionSpeed = value.Value; }
                            }
                        }
                        else
                        {
                            // T-codes are generated just before a new segment starts
                            string region = lineBuffer.Substring(lineBuffer.StartsWith("; feature") ? 9 : 1).Trim();
                            if (segment.Lines.Count == 0)
                            {
                                segment.Name = region;
                            }
                            else
                            {
                                segment = new GCodeSegment(region, segment.Tool, segment);
                                layer.Segments.Add(segment);
                            }
                        }
                    }
                    else
                    {
                        int? gCode = line.GetIValue('G');
                        if (gCode != null)
                        {
                            // G0 / G1
                            if (gCode == 0 || gCode == 1)
                            {
                                double? xParam = line.GetFValue('X');
                                double? yParam = line.GetFValue('Y');
                                double? zParam = line.GetFValue('Z');
                                if (xParam != null) { lastPoint.X = xParam.Value; }
                                if (yParam != null) { lastPoint.Y = yParam.Value; }
                                if (zParam != null) { lastPoint.Z = zParam.Value; }

                                if (numExtrusions < 2)
                                {
                                    double? eParam = line.GetFValue('E');
                                    if (eParam != null)
                                    {
                                        numExtrusions++;
                                        writeLine = false;
                                    }
                                }

                                double? fParam = line.GetFValue('F');
                                if (fParam != null) { feedrate = fParam.Value / 60.0; }

                                if (!isInterfacingSet && segment.Tool != -1 && xParam.HasValue && yParam.HasValue)
                                {
                                    segment.IsInterfacing = GetClosestSegment(lastLayer, xParam.Value, yParam.Value)?.Tool != segment.Tool;
                                    isInterfacingSet = true;
                                }
                            }
                            // G10
                            else if (gCode == 10)
                            {
                                int? pParam = line.GetIValue('P');
                                double? sParam = line.GetFValue('S');
                                if (pParam != null && pParam.Value > 0 && pParam.Value <= settings.Tools.Length &&
                                    sParam != null)
                                {
                                    // G10 P... S...
                                    settings.Tools[pParam.Value - 1].ActiveTemperature = (decimal)sParam.Value;
                                }
                            }
                        }
                        else
                        {
                            int? mCode = line.GetIValue('M');
                            if (mCode != null)
                            {
                                // M106
                                if (mCode == 106)
                                {
                                    // FIXME: Check machineInfo for non-thermostatic fans
                                    writeLine = false;
                                }
                                // M104
                                else if (mCode == 104)
                                {
                                    double? sParam = line.GetFValue('S');
                                    int? tParam = line.GetIValue('T');
                                    if (sParam != null &&
                                        tParam != null && tParam.Value > 0 && tParam.Value <= settings.Tools.Length)
                                    {
                                        ToolSettings toolSettings = settings.Tools[tParam.Value - 1];
										if (toolSettings.Type == ToolType.Nozzle)
										{
											if (toolSettings.ActiveTemperature <= 0m)
											{
												toolSettings.ActiveTemperature = (decimal)sParam.Value;
												segment.AddLine($"G10 P{tParam} R{toolSettings.StandbyTemperature} S{toolSettings.ActiveTemperature}");
											}
											else
											{
												segment.AddLine($"G10 P{tParam} S{sParam}");
											}
										}
                                        writeLine = false;
                                    }
                                }
                            }
                            else
                            {
                                // T-Code
                                int? tCode = line.GetIValue('T');
                                if (tCode != null)
                                {
                                    if (tCode > 0 && tCode <= settings.Tools.Length)
                                    {
                                        if (settings.Tools[tCode.Value - 1].Type == ToolType.Nozzle)
                                        {
                                            // Keep track of tools in use. Tool change sequences are inserted by the post-processor
                                            if (segment.Lines.Count == 0)
                                            {
                                                segment.Tool = tCode.Value;
                                            }
                                            else
                                            {
                                                segment = new GCodeSegment(segment.Name, tCode.Value, segment);
                                                layer.Segments.Add(segment);
                                            }
                                            writeLine = false;
                                        }
                                        else
                                        {
                                            // Make sure we don't print with inproperly configured tools...
                                            throw new ProcessorException($"Tool {tCode} is not configured as a nozzle (see line {lineNumber})");
                                        }
                                    }
                                    else if (segment.Lines.Count == 0)
                                    {
                                        segment.Tool = -1;
                                    }
                                    else
                                    {
                                        segment = new GCodeSegment(segment.Name, -1, segment);
                                        layer.Segments.Add(segment);
                                    }
                                }
                            }
                        }
                    }

                    // Add this line unless it was handled before
                    if (writeLine)
                    {
                        line.Feedrate = feedrate;
                        segment.AddLine(line);
                    }
                    lineBuffer = await reader.ReadLineAsync();
                    lineNumber++;

                    // Report progress to the UI
                    progress.Report((int)input.Position);
                } while (lineBuffer != null);

                layers.Add(layer);
            }
            else if (lineBuffer.Contains("Diabase"))
            {
                throw new ProcessorException("File has been already processed");
            }
            else
            {
                throw new ProcessorException("File was not generated by Simplify3D");
            }
        }

        private GCodeSegment GetClosestSegment(GCodeLayer layer, double x, double y)
        {
            GCodeSegment minSegment = null;
            double minDistance = 0.0;
            double lastX = double.NaN, lastY = double.NaN;
            foreach(GCodeSegment segment in layer.Segments)
            {
                foreach(GCodeLine line in segment.Lines)
                {
                    int? gCode = line.GetIValue('G');
                    if (gCode == 0 || gCode == 1)
                    {
                        double? xCoord = line.GetFValue('X');
                        double? yCoord = line.GetFValue('Y');
                        if (xCoord.HasValue && yCoord.HasValue)
                        {
                            if (double.IsNaN(lastX) || double.IsNaN(lastY))
                            {
                                lastX = xCoord.Value;
                                lastY = yCoord.Value;
                            }
                            else if (line.GetFValue('E').HasValue)
                            {
                                // Get distance from the extruding G0/G1 line segment ([lastX, lastY] to [xCoord, yCoord]) to [x, y]
                                double distance = Math.Abs((yCoord.Value - lastY) * x - (xCoord.Value - lastX) * y + xCoord.Value * lastY - yCoord.Value * lastX) /
                                    Math.Sqrt(Math.Pow(yCoord.Value - lastY, 2) + Math.Pow(xCoord.Value - lastX, 2));
                                if (minSegment == null || distance < minDistance)
                                {
                                    minSegment = segment;
                                    minDistance = distance;
                                }
                            }
                        }
                    }
                }
            }
            return minSegment;
        }

        private OverrideRule GetRule(int tool, int layer, GCodeSegment segment)
        {
            foreach(OverrideRule rule in rules)
            {
                if (rule.Matches(tool, layer, segment))
                {
                    return rule;
                }
            }
            return null;
        }

        public void PostProcess()
        {
            // We know how much we need to do here...
            maxProgress.Report(Math.Max(layers.Count * 2 - 2, 0));

            // Combine tool islands per layer, adjust tool change sequences and take care of rules
            bool startWithLowestTool = true;
            int iteration = 1, currentTool = -1;
            OverrideRule activeRule = null;
            for(int layerIndex = 1; layerIndex < layers.Count; layerIndex++)
            {
                GCodeLayer layer = layers[layerIndex];
                GCodeLayer replacementLayer = new GCodeLayer(layerIndex, layer.ZHeight);

                if (startWithLowestTool)
                {
                    for (int toolNumber = 1; toolNumber <= settings.Tools.Length; toolNumber++)
                    {
                        // Go from T1-T5
                        GCodeSegment segment = CombineSegments(layer, toolNumber, ref currentTool, ref activeRule);
                        if (segment != null) { replacementLayer.Segments.Add(segment); }
                    }
                }
                else
                {
                    for (int toolNumber = settings.Tools.Length; toolNumber >= 1; toolNumber--)
                    {
                        // Go from T5-T1
                        GCodeSegment segment = CombineSegments(layer, toolNumber, ref currentTool, ref activeRule);
                        if (segment != null) { replacementLayer.Segments.Add(segment); }
                    }
                }
                startWithLowestTool = !startWithLowestTool;

                layers[layerIndex] = replacementLayer;
                progress.Report(iteration++);
            }

            // Make sure the last applied rule is reset before the print finishes
            if (activeRule != null)
            {
                GCodeSegment lastSegment = layers.Last((layer) => layer.Segments.Count > 0).Segments.Last();
                if (activeRule.SpeedFactor != 100) { lastSegment.Lines.Add(new GCodeLine("M220 S100")); }
                if (activeRule.ExtrusionFactor != 100) { lastSegment.Lines.Add(new GCodeLine("M221 S100")); }
                activeRule = null;
            }

            // Add preheating sequences
            Coordinate position = lastPoint.Clone();
            Coordinate previousPosition = lastPoint.Clone();
            int selectedTool = -1;

            Dictionary<int, double> preheatCounters = new Dictionary<int, double>();   // Tool number vs. Elapsed time
            for(int layerNumber = 1; layerNumber < layers.Count; layerNumber++)
            {
                GCodeLayer layer = layers[layerNumber];
                double timeSpent = 0;

                foreach (GCodeSegment segment in layer.Segments)
                {
                    if (selectedTool == -1)
                    {
                        selectedTool = segment.Tool;
                    }
                    else if (selectedTool != segment.Tool)
                    {
                        // Take into account tool change times
                        ToolSettings tool = settings.Tools[selectedTool - 1];
                        timeSpent += (settings.Tools[selectedTool - 1].AutoClean) ? ToolChangeDurationWithCleaning : ToolChangeDuration;

                        // See if we need to use preheating for this tool
                        if (tool.PreheatTime > 0.0m)
                        {
                            if (preheatCounters.ContainsKey(selectedTool))
                            {
                                preheatCounters[selectedTool] = 0.0;
                            }
                            else
                            {
                                preheatCounters.Add(selectedTool, 0.0);
                            }
                        }
                        selectedTool = segment.Tool;
                    }

                    for (int lineIndex = segment.Lines.Count - 1; lineIndex >= 0; lineIndex--)
                    {
                        GCodeLine line = segment.Lines[lineIndex];

                        // Any counters running?
                        if (preheatCounters.Count > 0)
                        {
                            int? gCode = line.GetIValue('G');

                            // G0 / G1
                            if (gCode == 0 || gCode == 1)
                            {
                                double? xParam = line.GetFValue('X');
                                double? yParam = line.GetFValue('Y');
                                double? zParam = line.GetFValue('Z');
                                double? eParam = line.GetFValue('E');
                                if (xParam != null) { previousPosition.X = xParam.Value; }
                                if (yParam != null) { previousPosition.Y = yParam.Value; }
                                if (zParam != null) { previousPosition.Z = zParam.Value; }

                                double distance = Math.Sqrt(Math.Pow(position.X - previousPosition.X, 2) +
                                                            Math.Pow(position.Y - previousPosition.Y, 2) +
                                                            Math.Pow(position.Z - previousPosition.Z, 2) +
                                                            (eParam.HasValue ? Math.Pow(eParam.Value, 2) : 0));
                                double feedrate = line.Feedrate;
                                if (line.Feedrate > 0.0)
                                {
                                    // TODO: Take into account accelerations here
                                    timeSpent += distance / line.Feedrate;
                                }

                                position.AssignFrom(previousPosition);
                            }
                            // G4
                            else if (gCode == 4)
                            {
                                double? sParam = line.GetFValue('S');
                                if (sParam != null)
                                {
                                    timeSpent += sParam.Value;
                                }
                                else
                                {
                                    int? pParam = line.GetIValue('P');
                                    if (pParam != null)
                                    {
                                        timeSpent += pParam.Value * 1000.0;
                                    }
                                }
                            }
                            // G10 P... R...
                            else if (gCode == 10)
                            {
                                int? pParam = line.GetIValue('P');
                                int? rParam = line.GetIValue('R');
                                if (pParam != null && rParam != null && pParam > 0 && pParam <= settings.Tools.Length)
                                {
                                    if (preheatCounters.ContainsKey(pParam.Value))
                                    {
                                        // Remove this line again if we are still preheating
                                        segment.Lines.RemoveAt(lineIndex);
                                    }
                                }
                            }

                            foreach (int toolNumber in preheatCounters.Keys.ToList())
                            {
                                ToolSettings tool = settings.Tools[toolNumber - 1];
                                double totalTimeSpent = preheatCounters[toolNumber] + timeSpent;
                                if (totalTimeSpent > (double)tool.PreheatTime)
                                {
                                    // We've been doing enough stuff to generate a good G10 code
                                    segment.Lines.Insert(lineIndex, new GCodeLine($"G10 P{toolNumber} R{tool.ActiveTemperature}"));
                                    preheatCounters.Remove(toolNumber);
                                }
                                else
                                {
                                    // Need to do some more...
                                    preheatCounters[toolNumber] = totalTimeSpent;
                                }
                            }
                        }
                    }
                }
                progress.Report(iteration++);
            }

            // Override first generated G10 codes if we could not preheat in time
            if (preheatCounters.Count > 0 && layers.Count > 0 && layers[0].Segments.Count > 0)
            {
                foreach (GCodeLine line in layers[0].Segments[0].Lines)
                {
                    int? gCode = line.GetIValue('G');
                    if (gCode == 10)
                    {
                        int? pParam = line.GetIValue('P');
                        if (pParam != null && preheatCounters.ContainsKey(pParam.Value))
                        {
                            ToolSettings tool = settings.Tools[pParam.Value - 1];
                            line.Content = $"G10 P{pParam} R{tool.ActiveTemperature} S{tool.ActiveTemperature}";
                            preheatCounters.Remove(pParam.Value);
                        }
                    }
                }
            }
        }
        
        // Perform island combination for a given tool on a given layer returning a segment for the selected tool
        private GCodeSegment CombineSegments(GCodeLayer layer, int toolNumber, ref int currentTool, ref OverrideRule activeRule)
        {
            if (settings.Tools[toolNumber - 1].Type != ToolType.Nozzle)
            {
                // Don't bother with unconfigured tools
                return null;
            }

            List<GCodeLine> replacementLines = new List<GCodeLine>();
            double currentZ = 0.0;
            bool primeTool = false;
            foreach (GCodeSegment segment in layer.Segments)
            {
                if (segment.Tool == toolNumber)
                {
                    foreach (GCodeLine line in segment.Lines)
                    {
                        // Add next line
                        int? gCode = line.GetIValue('G');
                        if (gCode == 0 || gCode == 1)
                        {
                            // Keep track of the current Z position
                            double? zPosition = line.GetFValue('Z');
                            if (zPosition.HasValue) { currentZ = zPosition.Value; }

                            // Make sure to un-hop before the first extrusion if required
                            if (!double.IsNaN(layer.ZHeight) && currentZ != layer.ZHeight && line.GetFValue('E').HasValue)
                            {
                                replacementLines.Add(new GCodeLine($"G1 Z{layer.ZHeight:0.000} F{line.Feedrate * 60.0:0}"));
                                currentZ = layer.ZHeight;
                            }

                            // Add next movement of the segment
                            replacementLines.Add(line);

                            // Insert potential tool changes after first G0/G1 code
                            if (toolNumber != currentTool)
                            {
                                AddToolChange(replacementLines, currentTool, toolNumber);
                                currentTool = toolNumber;
                                primeTool = !toolPrimed[currentTool - 1];
                            }
                            else if (primeTool)
                            {
                                // Prime tool after the following G0/G1 code
                                replacementLines.Add(new GCodeLine($"G1 E{toolChangeRetractionDistance:0.00} F{toolChangeRetractionSpeed}", toolChangeRetractionSpeed / 60.0));
                                toolPrimed[currentTool - 1] = true;
                                primeTool = false;
                            }
                        }
                        else
                        {
                            // Always add it if is no movement
                            replacementLines.Add(line);
                        }

                        // Deal with custom rules
                        OverrideRule rule = GetRule(currentTool, layer.Number, segment);
                        if (rule != activeRule)
                        {
                            if (rule == null)
                            {
                                // Reset speed and/or extrusion factor
                                if (activeRule.SpeedFactor != 100) { replacementLines.Add(new GCodeLine("M220 S100")); }
                                if (activeRule.ExtrusionFactor != 100) { replacementLines.Add(new GCodeLine("M221 S100")); }
                            }
                            else
                            {
                                // Apply new speed and/or extrusion factor
                                if ((activeRule == null && rule.SpeedFactor != 100) || (activeRule != null && activeRule.SpeedFactor != rule.SpeedFactor))
                                {
                                    replacementLines.Add(new GCodeLine($"M220 S{rule.SpeedFactor}"));
                                }
                                if ((activeRule == null && rule.ExtrusionFactor != 100) || (activeRule != null && activeRule.ExtrusionFactor != rule.ExtrusionFactor))
                                {
                                    replacementLines.Add(new GCodeLine($"M221 S{rule.ExtrusionFactor}"));
                                }
                            }
                            activeRule = rule;
                        }
                    }
                }
            }
            return (replacementLines.Count == 0) ? null : new GCodeSegment($"T{toolNumber}", toolNumber, null) { Lines = replacementLines };
        }

        private void AddToolChange(List<GCodeLine> lines, int oldToolNumber, int newToolNumber)
        {
            if (oldToolNumber > 0 && oldToolNumber <= settings.Tools.Length)
            {
                ToolSettings oldTool = settings.Tools[oldToolNumber - 1];
                if (oldTool.PreheatTime > 0m)
                {
                    lines.Add(new GCodeLine($"G10 P{oldToolNumber} R{oldTool.StandbyTemperature}"));
                }
            }

            ToolSettings newTool = settings.Tools[newToolNumber - 1];
            if (newTool.AutoClean)
            {
                if (oldToolNumber == -1 || newTool.PreheatTime <= 0m)
                {
                    lines.Add(new GCodeLine("T" + newToolNumber + " P0"));
                    lines.Add(new GCodeLine("M116 P" + newToolNumber));
                }
                lines.Add(new GCodeLine("M98 P\"tprime" + newToolNumber + ".g\""));
            }
            else
            {
                lines.Add(new GCodeLine("T" + newToolNumber));
                if (oldToolNumber == -1 || newTool.PreheatTime <= 0m)
                {
                    lines.Add(new GCodeLine("M116 P" + newToolNumber));
                }
            }
        }

        public async Task WriteToFile(FileStream stream)
        {
            StreamWriter sw = new StreamWriter(stream);
            foreach(GCodeLayer layer in layers)
            {
                foreach(GCodeSegment segment in layer.Segments)
                {
                    foreach(GCodeLine line in segment.Lines)
                    {
                        await sw.WriteLineAsync(line.Content);
                    }
                }
            }
            sw.Flush();
        }
    }
}
