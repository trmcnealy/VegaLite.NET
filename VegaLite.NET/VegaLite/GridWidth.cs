namespace VegaLite
{
    public struct GridWidth
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridWidth(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new GridWidth { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator GridWidth(double                                 @double)                                 => new GridWidth { Double                                 = @double };
    }
}