namespace VegaLite.Schema
{
    public struct BoxPlotDefExtent
    {
        public double?       Double;
        public ExtentExtent? Enum;

        public static implicit operator BoxPlotDefExtent(double @double)
        {
            return new BoxPlotDefExtent
            {
                Double = @double
            };
        }

        public static implicit operator BoxPlotDefExtent(ExtentExtent @enum)
        {
            return new BoxPlotDefExtent
            {
                Enum = @enum
            };
        }
    }
}
