namespace VegaLite
{
    public struct TextBaseline
    {
        public ConditionalAxisPropertyTextBaselineNull ConditionalAxisPropertyTextBaselineNull;
        public Baseline?                               Enum;

        public static implicit operator TextBaseline(ConditionalAxisPropertyTextBaselineNull conditionalAxisPropertyTextBaselineNull) => new TextBaseline { ConditionalAxisPropertyTextBaselineNull = conditionalAxisPropertyTextBaselineNull };
        public static implicit operator TextBaseline(Baseline                                @enum)                                    => new TextBaseline { Enum                                    = @enum };
    }
}