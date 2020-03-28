namespace VegaLite
{
    public struct LabelFontStyle
    {
        public ConditionalAxisPropertyFontStyleNull ConditionalAxisPropertyFontStyleNull;
        public string                               String;

        public static implicit operator LabelFontStyle(ConditionalAxisPropertyFontStyleNull conditionalAxisPropertyFontStyleNull) => new LabelFontStyle { ConditionalAxisPropertyFontStyleNull = conditionalAxisPropertyFontStyleNull };
        public static implicit operator LabelFontStyle(string                               @string)                               => new LabelFontStyle { String                               = @string };
    }
}