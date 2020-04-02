namespace VegaLite.Schema
{
    public struct LabelFontStyle
    {
        public ConditionalAxisPropertyFontStyleNull ConditionalAxisPropertyFontStyleNull;
        public string                               String;

        public static implicit operator LabelFontStyle(ConditionalAxisPropertyFontStyleNull conditionalAxisPropertyFontStyleNull)
        {
            return new LabelFontStyle
            {
                ConditionalAxisPropertyFontStyleNull = conditionalAxisPropertyFontStyleNull
            };
        }

        public static implicit operator LabelFontStyle(string @string)
        {
            return new LabelFontStyle
            {
                String = @string
            };
        }
    }
}
