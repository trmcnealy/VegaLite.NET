namespace VegaLite.Schema
{
    public struct GridOpacity
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridOpacity(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass)
        {
            return new GridOpacity
            {
                ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass
            };
        }

        public static implicit operator GridOpacity(double @double)
        {
            return new GridOpacity
            {
                Double = @double
            };
        }
    }
}
