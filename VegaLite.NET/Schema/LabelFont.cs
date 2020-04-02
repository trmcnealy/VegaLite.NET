namespace VegaLite.Schema
{
    public struct LabelFont
    {
        public ConditionalAxisPropertyStringNull ConditionalAxisPropertyStringNull;
        public string                            String;

        public static implicit operator LabelFont(ConditionalAxisPropertyStringNull conditionalAxisPropertyStringNull)
        {
            return new LabelFont
            {
                ConditionalAxisPropertyStringNull = conditionalAxisPropertyStringNull
            };
        }

        public static implicit operator LabelFont(string @string)
        {
            return new LabelFont
            {
                String = @string
            };
        }
    }
}
