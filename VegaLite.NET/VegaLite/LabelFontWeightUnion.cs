namespace VegaLite
{
    public struct LabelFontWeightUnion
    {
        public ConditionalAxisPropertyFontWeightNull ConditionalAxisPropertyFontWeightNull;
        public double?                               Double;
        public FontWeightEnum?                     Enum;

        public static implicit operator LabelFontWeightUnion(ConditionalAxisPropertyFontWeightNull conditionalAxisPropertyFontWeightNull) => new LabelFontWeightUnion { ConditionalAxisPropertyFontWeightNull = conditionalAxisPropertyFontWeightNull };
        public static implicit operator LabelFontWeightUnion(double                                @double)                                => new LabelFontWeightUnion { Double                                = @double };
        public static implicit operator LabelFontWeightUnion(FontWeightEnum                      @enum)                                  => new LabelFontWeightUnion { Enum                                  = @enum };
    }
}