namespace VegaLite
{
    public struct GridOpacity
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridOpacity(ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass) => new GridOpacity { ConditionalAxisPropertyNumberNullClass = ConditionalAxisPropertyNumberNullClass };
        public static implicit operator GridOpacity(double                                 Double)                                 => new GridOpacity { Double                                 = Double };
    }
}