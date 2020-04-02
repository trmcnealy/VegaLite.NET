using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyFontStyleNullCondition
    {
        public ConditionalPredicateValueDefFontStyleNull       ConditionalPredicateValueDefFontStyleNull;
        public List<ConditionalPredicateValueDefFontStyleNull> ConditionalPredicateValueDefFontStyleNullArray;

        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(ConditionalPredicateValueDefFontStyleNull conditionalPredicateValueDefFontStyleNull)
        {
            return new ConditionalAxisPropertyFontStyleNullCondition
            {
                ConditionalPredicateValueDefFontStyleNull = conditionalPredicateValueDefFontStyleNull
            };
        }

        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(List<ConditionalPredicateValueDefFontStyleNull> conditionalPredicateValueDefFontStyleNullArray)
        {
            return new ConditionalAxisPropertyFontStyleNullCondition
            {
                ConditionalPredicateValueDefFontStyleNullArray = conditionalPredicateValueDefFontStyleNullArray
            };
        }
    }
}
