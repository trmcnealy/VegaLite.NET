using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyFontStyleNullCondition
    {
        public ConditionalPredicateValueDefFontStyleNull       ConditionalPredicateValueDefFontStyleNull;
        public List<ConditionalPredicateValueDefFontStyleNull> ConditionalPredicateValueDefFontStyleNullArray;

        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(ConditionalPredicateValueDefFontStyleNull       ConditionalPredicateValueDefFontStyleNull)      => new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNull      = ConditionalPredicateValueDefFontStyleNull };
        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(List<ConditionalPredicateValueDefFontStyleNull> ConditionalPredicateValueDefFontStyleNullArray) => new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNullArray = ConditionalPredicateValueDefFontStyleNullArray };
    }
}