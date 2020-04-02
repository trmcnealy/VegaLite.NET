namespace VegaLite.Schema
{
    public struct LabelFontWeightUnion
    {
        public ConditionalAxisPropertyFontWeightNull ConditionalAxisPropertyFontWeightNull;
        public double?                               Double;
        public FontWeightEnum?                       Enum;

        public static implicit operator LabelFontWeightUnion(ConditionalAxisPropertyFontWeightNull conditionalAxisPropertyFontWeightNull)
        {
            return new LabelFontWeightUnion
            {
                ConditionalAxisPropertyFontWeightNull = conditionalAxisPropertyFontWeightNull
            };
        }

        public static implicit operator LabelFontWeightUnion(double @double)
        {
            return new LabelFontWeightUnion
            {
                Double = @double
            };
        }

        public static implicit operator LabelFontWeightUnion(FontWeightEnum @enum)
        {
            return new LabelFontWeightUnion
            {
                Enum = @enum
            };
        }
    }
}
