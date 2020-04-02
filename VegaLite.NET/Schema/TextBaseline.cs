namespace VegaLite.Schema
{
    public struct TextBaseline
    {
        public ConditionalAxisPropertyTextBaselineNull ConditionalAxisPropertyTextBaselineNull;
        public Baseline?                               Enum;

        public static implicit operator TextBaseline(ConditionalAxisPropertyTextBaselineNull conditionalAxisPropertyTextBaselineNull)
        {
            return new TextBaseline
            {
                ConditionalAxisPropertyTextBaselineNull = conditionalAxisPropertyTextBaselineNull
            };
        }

        public static implicit operator TextBaseline(Baseline @enum)
        {
            return new TextBaseline
            {
                Enum = @enum
            };
        }
    }
}
