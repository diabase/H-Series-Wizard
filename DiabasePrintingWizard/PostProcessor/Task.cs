using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DiabasePrintingWizard
{
    static class PostProcessor
    {
        public static readonly int StepsPerAdditiveFile = 3;
        public static readonly int StepsPerSubstractiveFile = 1;   // substractive files are not processed (yet)

        private static int totalProgressValue;

        public static async Task CreateTask(FileStream topAdditiveFile, FileStream topSubstractiveFile,
            FileStream bottomAdditiveFile, FileStream bottomSubstractiveFile,
            FileStream outFile, SettingsContainer settings, IList<OverrideRule> rules, Duet.MachineInfo machine,
            IProgress<string> textProgress, IProgress<int> progress, IProgress<int> maxProgress, IProgress<int>totalProgress, bool debug, Duet.MachineInfo userEnteredMachine)
        {
            Exception ex = null;
            try
            {
                totalProgressValue = 0;

                // Additive Top
                GCodeProcessor topAdditiveGCode = new GCodeProcessor(topAdditiveFile, settings, rules, machine, progress, maxProgress);
                textProgress.Report("Preprocessing file for additive manufacturing on the top side...");
                await topAdditiveGCode.PreProcess();
                IncreaseTotalProgress(totalProgress);

                textProgress.Report("Postprocessing file for additive manufacturing on the top side...");
                topAdditiveGCode.PostProcess();
                IncreaseTotalProgress(totalProgress);

                // Hybrid Top is not processed

                // Additive Bottom
                GCodeProcessor bottomAdditiveGCode = null;
                if (bottomAdditiveFile != null)
                {
                    bottomAdditiveGCode = new GCodeProcessor(bottomAdditiveFile, settings, rules, machine, progress, maxProgress);
                    textProgress.Report("Preprocessing file for additive manufacturing on the bottom side...");
                    await bottomAdditiveGCode.PreProcess();
                    IncreaseTotalProgress(totalProgress);

                    textProgress.Report("Postprocessing file for additive manufacturing on the bottom side...");
                    bottomAdditiveGCode.PostProcess();
                    IncreaseTotalProgress(totalProgress);
                }

                // Hybrid Bottom is not processed

                // Join files together
                textProgress.Report("Combining results...");
                WriteSettings(outFile, settings, machine, userEnteredMachine, rules);
                WriteFileInfo(outFile, "Additive manufacturing on the top side", topAdditiveFile);
                await topAdditiveGCode.WriteToFile(outFile, debug);
                IncreaseTotalProgress(totalProgress);
                if (topSubstractiveFile != null)
                {
                    WriteFileInfo(outFile, "Substractive manufacturing on the top side", topSubstractiveFile);
                    await topSubstractiveFile.CopyToAsync(outFile);
                    IncreaseTotalProgress(totalProgress);
                }
                if (bottomAdditiveFile != null)
                {
                    // TODO: Add code to turn around A-axis for two-sided prints?
                    WriteFileInfo(outFile, "Additive manufacturing on the bottom side", bottomAdditiveFile);
                    await bottomAdditiveGCode.WriteToFile(outFile, debug);
                    IncreaseTotalProgress(totalProgress);
                }
                if (bottomSubstractiveFile != null)
                {
                    WriteFileInfo(outFile, "Substractive manufacturing on the bottom side", bottomSubstractiveFile);
                    await bottomSubstractiveFile.CopyToAsync(outFile);
                    IncreaseTotalProgress(totalProgress);
                }
                textProgress.Report("Done!");
            }
            catch (Exception e)
            {
                ex = e;
            }

            if (ex != null)
            {
                throw new AggregateException(ex);
            }
        }


        private static void WriteSettings(FileStream outFile, SettingsContainer currentSettings, Duet.MachineInfo machine, Duet.MachineInfo userEnteredMachine, IList<OverrideRule> overrideRules)
        {
            StreamWriter sw = new StreamWriter(outFile);

            // General settings
            sw.WriteLine(";  General Settings");
            string machineSelection;
            if (machine == Duet.MachineInfo.DefaultMachineInfo)
            {
                machineSelection = "configured manually";
            }
            else if (machine == userEnteredMachine)
            {
                machineSelection = "manually entered address";
            }
            else
            {
                machineSelection = "selected from auto-detect list";
            }
            sw.WriteLine($";    Machine selection: {machineSelection}");
            sw.WriteLine($";    Use own settings: {currentSettings.UseOwnSettings}");
            sw.WriteLine($";    Generate special support: {currentSettings.GenerateSpecialSupport}");
            if (currentSettings.RotaryPrinting != null)
            {
                sw.WriteLine($";    Rotary printing: true");
                sw.WriteLine($";    Inner radius: {currentSettings.RotaryPrinting.InnerRadius.ToString("F2", FrmMain.numberFormat)}mm");
            }
            sw.WriteLine($";    Island combining: {currentSettings.IslandCombining}");
            sw.WriteLine($";    Skip homing: {currentSettings.SkipHoming}");
            sw.WriteLine(";");

            // Tool settings
            sw.WriteLine(";  Tool Settings");
            for (var i = 0; i < currentSettings.Tools.Length; i++)
            {
                var ts = currentSettings.Tools[i];
                sw.WriteLine($";    Tool {i + 1}");
                sw.WriteLine($";      Type: {ts.Type}");
                sw.WriteLine($";      Preheat time: {ts.PreheatTime}");
                sw.WriteLine($";      Active temperature: {ts.ActiveTemperature}");
                sw.WriteLine($";      Standby temperature: {ts.StandbyTemperature}");
                sw.WriteLine($";      Cleaning: {ts.Cleaning.ToString()}{((ts.Cleaning == CleaningMode.Interval) ? $" every {ts.Interval} change(s)" : "")}");
                sw.WriteLine(";");

            }

            // Override rules
            if (overrideRules.Count > 0)
            {
                sw.WriteLine(";  Override rules");
                foreach (OverrideRule or in overrideRules)
                {
                    sw.WriteLine($";    Tool: {or.Tool}");
                    sw.WriteLine($";    Layer: {or.Layer}");
                    sw.WriteLine($";    Region: {or.Region}");
                    sw.WriteLine($";    Speed factor: {or.SpeedFactor.ToString("F1", FrmMain.numberFormat)}");
                    sw.WriteLine($";    Extrusion factor: {or.ExtrusionFactor.ToString("F1", FrmMain.numberFormat)}");
                    sw.WriteLine(";");
                }
            }

            sw.Flush();
        }
        private static void IncreaseTotalProgress(IProgress<int> progress)
        {
            progress.Report(++totalProgressValue);
        }

        private static void WriteFileInfo(FileStream outFile, string info, FileStream stream)
        {
            StreamWriter sw = new StreamWriter(outFile);
            sw.WriteLine(";");
            sw.WriteLine("; -- " + info + " --");
            sw.WriteLine("; Source File: " + stream.Name);

            sw.Flush();
        }
    }
}
