namespace VegaLite
{
    public struct Color
    {
        public ConditionalAxisPropertyColorNull ConditionalAxisPropertyColorNull;
        public string                           String;

        public static implicit operator Color(ConditionalAxisPropertyColorNull ConditionalAxisPropertyColorNull) => new Color { ConditionalAxisPropertyColorNull = ConditionalAxisPropertyColorNull };
        public static implicit operator Color(string                           String)                           => new Color { String                           = String };
        public                          bool IsNull                                                              => ConditionalAxisPropertyColorNull == null && String == null;
    }
}