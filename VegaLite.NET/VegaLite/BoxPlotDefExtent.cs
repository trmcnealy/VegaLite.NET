namespace VegaLite
{
    public struct BoxPlotDefExtent
    {
        public double?       Double;
        public ExtentExtent? Enum;

        public static implicit operator BoxPlotDefExtent(double       Double) => new BoxPlotDefExtent { Double = Double };
        public static implicit operator BoxPlotDefExtent(ExtentExtent Enum)   => new BoxPlotDefExtent { Enum   = Enum };
    }
}