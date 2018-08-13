using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabaseWizard
{
    class GCodeLayer
    {
        public int Number { get; set; }

        public List<GCodeLine> Lines { get; set; }

        public GCodeLayer(int number)
        {
            Number = number;
            Lines = new List<GCodeLine>();
        }

        public void AddLine(GCodeLine line) => Lines.Add(line);

        public void AddLine(string line)
        {
            if (Lines.Count == 0)
            {
                throw new ArgumentException($"No lines added yet (layer {Number})");
            }

            AddLine(new GCodeLine(line)
            {
                Tool = Lines[Lines.Count - 1].Tool,
                Feedrate = Lines[Lines.Count - 1].Feedrate
            });
        }
    }
}
