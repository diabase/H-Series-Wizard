using System;

namespace DiabasePrintingWizard
{
    class OverrideRule
    {
        private int _tool = -1;
        public string Tool
        {
            get => (_tool == -1) ? "Any" : $"Tool {_tool}";
            set
            {
                switch (value)
                {
                    case "Any":
                        _tool = -1;
                        break;
                    case "Tool 1":
                        _tool = 1;
                        break;
                    case "Tool 2":
                        _tool = 2;
                        break;
                    case "Tool 3":
                        _tool = 3;
                        break;
                    case "Tool 4":
                        _tool = 4;
                        break;
                    case "Tool 5":
                        _tool = 5;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        private int _layer = -1;
        public string Layer
        {
            get => (_layer == -1) ? "Any" : _layer.ToString();
            set
            {
                if (value == "Any")
                {
                    _layer = -1;
                }
                else if (int.TryParse(value, out int numericLayer) && numericLayer >= 1)
                {
                    _layer = numericLayer;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Region { get; set; } = "Any";

        public bool Matches(int tool, int layer, string region)
        {
            return ((_tool == -1 || _tool == tool) &&
                (_layer == -1 || _layer == layer) &&
                (Region == "Any" || Region.Equals(region, StringComparison.InvariantCultureIgnoreCase)));
        }

        public double SpeedFactor { get; set; } = 100;

        public double ExtrusionFactor { get; set; } = 100;
    }
}
