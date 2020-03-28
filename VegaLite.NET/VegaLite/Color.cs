namespace VegaLite
{
    public struct Color
    {
        public ConditionalAxisPropertyColorNull ConditionalAxisPropertyColorNull;
        public string                           String;

        public static implicit operator Color(ConditionalAxisPropertyColorNull conditionalAxisPropertyColorNull) => new Color { ConditionalAxisPropertyColorNull = conditionalAxisPropertyColorNull };
        public static implicit operator Color(string                           @string)                           => new Color { String                           = @string };
        public                          bool IsNull                                                              => ConditionalAxisPropertyColorNull == null && String == null;
    }
}