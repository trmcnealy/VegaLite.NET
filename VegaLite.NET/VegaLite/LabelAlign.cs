namespace VegaLite
{
    public struct LabelAlign
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public Align?                                 Enum;

        public static implicit operator LabelAlign(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new LabelAlign { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator LabelAlign(Align                                  @enum)                                   => new LabelAlign { Enum                                   = @enum };
    }
}