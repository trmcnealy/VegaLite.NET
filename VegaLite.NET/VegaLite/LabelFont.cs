namespace VegaLite
{
    public struct LabelFont
    {
        public ConditionalAxisPropertyStringNull ConditionalAxisPropertyStringNull;
        public string                            String;

        public static implicit operator LabelFont(ConditionalAxisPropertyStringNull ConditionalAxisPropertyStringNull) => new LabelFont { ConditionalAxisPropertyStringNull = ConditionalAxisPropertyStringNull };
        public static implicit operator LabelFont(string                            String)                            => new LabelFont { String                            = String };
    }
}