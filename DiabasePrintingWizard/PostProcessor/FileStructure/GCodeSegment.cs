using System;
using System.Collections.Generic;

namespace DiabasePrintingWizard
{
    class GCodeSegment
    {
        public string Name { get; set; }                    // Feature Name

        public int Tool { get; set; }                       // Selected Tool
        
        public bool IsInterfacing { get; set; }             // Whether the area below was printed with a different material

        public List<GCodeLine> Lines { get; set; }          // Segment G-Code Instructions

        public Coordinate LastPosition { get; set; }        // Last position in this segment

        private readonly GCodeSegment last;

        public GCodeSegment(string name, int tool, GCodeSegment lastSegment)
        {
            Name = name;
            Tool = tool;
            Lines = new List<GCodeLine>();
            last = lastSegment;
        }

        public void AddLine(GCodeLine line) => Lines.Add(line);

        public void AddLine(string line)
        {
            if (Lines.Count == 0 && (last == null || last.Lines.Count == 0))
            {
                throw new ArgumentException($"No sticky parameters available for AddLine call (segment {Name})");
            }

            GCodeLine lastLine = (Lines.Count > 0) ? Lines[Lines.Count - 1] : last.Lines[last.Lines.Count - 1];
            AddLine(new GCodeLine(line, lastLine.Feedrate));
        }
    }
}
