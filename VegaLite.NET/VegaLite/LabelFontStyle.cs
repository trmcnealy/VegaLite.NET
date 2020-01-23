namespace VegaLite
{
    public struct LabelFontStyle
    {
        public ConditionalAxisPropertyFontStyleNull ConditionalAxisPropertyFontStyleNull;
        public string                               String;

        public static implicit operator LabelFontStyle(ConditionalAxisPropertyFontStyleNull ConditionalAxisPropertyFontStyleNull) => new LabelFontStyle { ConditionalAxisPropertyFontStyleNull = ConditionalAxisPropertyFontStyleNull };
        public static implicit operator LabelFontStyle(string                               String)                               => new LabelFontStyle { String                               = String };
    }
}