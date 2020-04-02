namespace VegaLite.Schema
{
    public struct GridDashOffset
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double?                                Double;

        public static implicit operator GridDashOffset(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass)
        {
            return new GridDashOffset
            {
                ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass
            };
        }

        public static implicit operator GridDashOffset(double @double)
        {
            return new GridDashOffset
            {
                Double = @double
            };
        }
    }
}
