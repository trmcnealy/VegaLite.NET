namespace VegaLite
{
    public struct GridDashOffset
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridDashOffset(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new GridDashOffset { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator GridDashOffset(double                                 @double)                                 => new GridDashOffset { Double                                 = @double };
    }
}