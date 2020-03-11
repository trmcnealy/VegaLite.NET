namespace VegaLite
{
    public struct ConditionalPredicateValueDefFontWeightNullValue
    {
        public double?           Double;
        public FontWeightEnum? Enum;

        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(double           Double) => new ConditionalPredicateValueDefFontWeightNullValue { Double = Double };
        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(FontWeightEnum Enum)   => new ConditionalPredicateValueDefFontWeightNullValue { Enum   = Enum };
        public                          bool IsNull                                                              => Double == null && Enum == null;
    }
}