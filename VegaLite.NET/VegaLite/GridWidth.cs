namespace VegaLite
{
    public struct GridWidth
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridWidth(ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass) => new GridWidth { ConditionalAxisPropertyNumberNullClass = ConditionalAxisPropertyNumberNullClass };
        public static implicit operator GridWidth(double                                 Double)                                 => new GridWidth { Double                                 = Double };
    }
}