namespace DiabasePrintingWizard
{
    enum ToolType : int
    {
        None = 0,
        Nozzle,
        Spindle
    }

    class ToolSettings
    {
        public ToolType Type { get; set; }

        public decimal PreheatTime { get; set; }

        public decimal ActiveTemperature { get; set; }

        public decimal StandbyTemperature { get; set; }

        public bool AutoClean { get; set; }
    }

    public class RotaryPrintingSettings
    {
        public double InnerRadius { get; set; }
    }

    class SettingsContainer
    {
        public bool ConfigureManually { get; set; }

        public ToolSettings[] Tools { get; set; }

        public bool UseOwnSettings { get; set; }

        public bool GenerateSpecialSupport { get; set; }

        public RotaryPrintingSettings RotaryPrinting { get; set; }

        public bool IslandCombining { get; set; } = true;
    }
}
