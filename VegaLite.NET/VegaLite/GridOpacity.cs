namespace VegaLite
{
    public struct GridOpacity
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridOpacity(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new GridOpacity { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator GridOpacity(double                                 @double)                                 => new GridOpacity { Double                                 = @double };
    }
}