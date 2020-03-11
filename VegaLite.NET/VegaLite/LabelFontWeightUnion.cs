namespace VegaLite
{
    public struct LabelFontWeightUnion
    {
        public ConditionalAxisPropertyFontWeightNull ConditionalAxisPropertyFontWeightNull;
        public double?                               Double;
        public FontWeightEnum?                     Enum;

        public static implicit operator LabelFontWeightUnion(ConditionalAxisPropertyFontWeightNull ConditionalAxisPropertyFontWeightNull) => new LabelFontWeightUnion { ConditionalAxisPropertyFontWeightNull = ConditionalAxisPropertyFontWeightNull };
        public static implicit operator LabelFontWeightUnion(double                                Double)                                => new LabelFontWeightUnion { Double                                = Double };
        public static implicit operator LabelFontWeightUnion(FontWeightEnum                      Enum)                                  => new LabelFontWeightUnion { Enum                                  = Enum };
    }
}