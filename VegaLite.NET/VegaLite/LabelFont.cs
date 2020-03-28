namespace VegaLite
{
    public struct LabelFont
    {
        public ConditionalAxisPropertyStringNull ConditionalAxisPropertyStringNull;
        public string                            String;

        public static implicit operator LabelFont(ConditionalAxisPropertyStringNull conditionalAxisPropertyStringNull) => new LabelFont { ConditionalAxisPropertyStringNull = conditionalAxisPropertyStringNull };
        public static implicit operator LabelFont(string                            @string)                            => new LabelFont { String                            = @string };
    }
}