namespace VegaLite
{
    public struct LabelAlign
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public Align?                                 Enum;

        public static implicit operator LabelAlign(ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass) => new LabelAlign { ConditionalAxisPropertyNumberNullClass = ConditionalAxisPropertyNumberNullClass };
        public static implicit operator LabelAlign(Align                                  Enum)                                   => new LabelAlign { Enum                                   = Enum };
    }
}