namespace VegaLite
{
    public struct BoxPlotDefExtent
    {
        public double?       Double;
        public ExtentExtent? Enum;

        public static implicit operator BoxPlotDefExtent(double       @double) => new BoxPlotDefExtent { Double = @double };
        public static implicit operator BoxPlotDefExtent(ExtentExtent @enum)   => new BoxPlotDefExtent { Enum   = @enum };
    }
}