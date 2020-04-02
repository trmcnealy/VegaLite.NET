namespace VegaLite.Schema
{
    public struct ConditionalPredicateValueDefFontWeightNullValue
    {
        public double?         Double;
        public FontWeightEnum? Enum;

        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(double @double)
        {
            return new ConditionalPredicateValueDefFontWeightNullValue
            {
                Double = @double
            };
        }

        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(FontWeightEnum @enum)
        {
            return new ConditionalPredicateValueDefFontWeightNullValue
            {
                Enum = @enum
            };
        }

        public bool IsNull { get { return Double == null && Enum == null; } }
    }
}
