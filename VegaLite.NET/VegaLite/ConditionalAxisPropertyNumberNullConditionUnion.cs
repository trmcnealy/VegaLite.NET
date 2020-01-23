using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyNumberNullConditionUnion
    {
        public ConditionalPredicateValueDefNumberNullElement       ConditionalPredicateValueDefNumberNullElement;
        public List<ConditionalPredicateValueDefNumberNullElement> ConditionalPredicateValueDefNumberNullElementArray;

        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(ConditionalPredicateValueDefNumberNullElement       ConditionalPredicateValueDefNumberNullElement)      => new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElement      = ConditionalPredicateValueDefNumberNullElement };
        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(List<ConditionalPredicateValueDefNumberNullElement> ConditionalPredicateValueDefNumberNullElementArray) => new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElementArray = ConditionalPredicateValueDefNumberNullElementArray };
    }
}