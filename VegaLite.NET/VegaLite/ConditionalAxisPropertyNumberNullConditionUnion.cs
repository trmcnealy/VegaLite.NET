using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyNumberNullConditionUnion
    {
        public ConditionalPredicateValueDefNumberNullElement       ConditionalPredicateValueDefNumberNullElement;
        public List<ConditionalPredicateValueDefNumberNullElement> ConditionalPredicateValueDefNumberNullElementArray;

        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(ConditionalPredicateValueDefNumberNullElement       conditionalPredicateValueDefNumberNullElement)      => new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElement      = conditionalPredicateValueDefNumberNullElement };
        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(List<ConditionalPredicateValueDefNumberNullElement> conditionalPredicateValueDefNumberNullElementArray) => new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElementArray = conditionalPredicateValueDefNumberNullElementArray };
    }
}