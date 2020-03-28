using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyFontStyleNullCondition
    {
        public ConditionalPredicateValueDefFontStyleNull       ConditionalPredicateValueDefFontStyleNull;
        public List<ConditionalPredicateValueDefFontStyleNull> ConditionalPredicateValueDefFontStyleNullArray;

        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(ConditionalPredicateValueDefFontStyleNull       conditionalPredicateValueDefFontStyleNull)      => new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNull      = conditionalPredicateValueDefFontStyleNull };
        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(List<ConditionalPredicateValueDefFontStyleNull> conditionalPredicateValueDefFontStyleNullArray) => new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNullArray = conditionalPredicateValueDefFontStyleNullArray };
    }
}