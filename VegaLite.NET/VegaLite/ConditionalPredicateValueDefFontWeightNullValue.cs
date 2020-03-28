namespace VegaLite
{
    public struct ConditionalPredicateValueDefFontWeightNullValue
    {
        public double?           Double;
        public FontWeightEnum? Enum;

        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(double           @double) => new ConditionalPredicateValueDefFontWeightNullValue { Double = @double };
        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(FontWeightEnum @enum)   => new ConditionalPredicateValueDefFontWeightNullValue { Enum   = @enum };
        public                          bool IsNull                                                              => Double == null && Enum == null;
    }
}