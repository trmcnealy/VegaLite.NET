namespace VegaLite.Schema
{
    public struct LabelAlign
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public Align?                                 Enum;

        public static implicit operator LabelAlign(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass)
        {
            return new LabelAlign
            {
                ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass
            };
        }

        public static implicit operator LabelAlign(Align @enum)
        {
            return new LabelAlign
            {
                Enum = @enum
            };
        }
    }
}
