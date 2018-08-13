using System.Collections.Generic;

namespace DiabaseWizard.Duet
{
    public class MachineInfo
    {
        public static MachineInfo DefaultMachineInfo = new MachineInfo
        {
            Axes = 5,
            IPAddress = null,
            Name = null,
            Tools = new List<Tool>
            {
                new Tool
                {
                    Number = 1,
                    NumDrives = 1,
                    NumHeaters = 1,
                    HasSpindle = false
                },
                new Tool
                {
                    Number = 2,
                    NumDrives = 1,
                    NumHeaters = 1,
                    HasSpindle = false
                },
                new Tool
                {
                    Number = 3,
                    NumDrives = 1,
                    NumHeaters = 1,
                    HasSpindle = false
                },
                new Tool
                {
                    Number = 4,
                    NumDrives = 1,
                    NumHeaters = 1,
                    HasSpindle = false
                },
                new Tool
                {
                    Number = 5,
                    NumDrives = 1,
                    NumHeaters = 1,
                    HasSpindle = false
                }
            }
        };

        public string Name { get; set; }

        public string IPAddress { get; set; }

        public class Tool
        {
            public int Number;
            public int NumHeaters;
            public int NumDrives;
            public bool HasSpindle;
        }

        public List<Tool> Tools { get; set; } = new List<Tool>();

        public int Axes { get; set; }

        public List<double> Accelerations = new List<double>();     // mm/s^2

        public List<double> MinFeedrates = new List<double>();      // mm/s

        public List<double> MaxFeedrates = new List<double>();      // mm/s
    }
}
