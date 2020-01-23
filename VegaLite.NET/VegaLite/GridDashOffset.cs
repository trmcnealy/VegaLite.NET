namespace VegaLite
{
    public struct GridDashOffset
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridDashOffset(ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass) => new GridDashOffset { ConditionalAxisPropertyNumberNullClass = ConditionalAxisPropertyNumberNullClass };
        public static implicit operator GridDashOffset(double                                 Double)                                 => new GridDashOffset { Double                                 = Double };
    }
}