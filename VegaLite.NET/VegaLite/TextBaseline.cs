namespace VegaLite
{
    public struct TextBaseline
    {
        public ConditionalAxisPropertyTextBaselineNull ConditionalAxisPropertyTextBaselineNull;
        public Baseline?                               Enum;

        public static implicit operator TextBaseline(ConditionalAxisPropertyTextBaselineNull ConditionalAxisPropertyTextBaselineNull) => new TextBaseline { ConditionalAxisPropertyTextBaselineNull = ConditionalAxisPropertyTextBaselineNull };
        public static implicit operator TextBaseline(Baseline                                Enum)                                    => new TextBaseline { Enum                                    = Enum };
    }
}