using System;
namespace DiabasePrintingWizard
{
    class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coordinate Clone() => new Coordinate { X = X, Y = Y, Z = Z };
        public void AssignFrom(Coordinate coord) { X = coord.X; Y = coord.Y; Z = coord.Z; }
    }
}
