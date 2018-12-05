using System;
using System.Collections.Generic;

namespace DiabasePrintingWizard
{
    class GCodeLayer
    {
        public int Number { get; set; }

        public double ZHeight { get; set; }

        public List<GCodeSegment> Segments { get; set; }

        public GCodeLayer(int number, double zHeight)
        {
            Number = number;
            ZHeight = zHeight;
            Segments = new List<GCodeSegment>();
        }
    }
}
