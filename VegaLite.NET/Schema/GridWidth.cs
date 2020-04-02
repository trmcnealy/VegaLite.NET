namespace VegaLite.Schema
{
    public struct GridWidth
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridWidth(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass)
        {
            return new GridWidth
            {
                ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass
            };
        }

        public static implicit operator GridWidth(double @double)
        {
            return new GridWidth
            {
                Double = @double
            };
        }
    }
}
