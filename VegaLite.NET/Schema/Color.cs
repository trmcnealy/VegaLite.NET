namespace VegaLite.Schema
{
    public struct Color
    {
        public ConditionalAxisPropertyColorNull ConditionalAxisPropertyColorNull;
        public string                           String;

        public static implicit operator Color(ConditionalAxisPropertyColorNull conditionalAxisPropertyColorNull)
        {
            return new Color
            {
                ConditionalAxisPropertyColorNull = conditionalAxisPropertyColorNull
            };
        }

        public static implicit operator Color(string @string)
        {
            return new Color
            {
                String = @string
            };
        }

        public bool IsNull { get { return ConditionalAxisPropertyColorNull == null && String == null; } }
    }
}
