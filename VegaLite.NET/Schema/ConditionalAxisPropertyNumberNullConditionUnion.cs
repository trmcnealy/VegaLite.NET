using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyNumberNullConditionUnion
    {
        public ConditionalPredicateValueDefNumberNullElement       ConditionalPredicateValueDefNumberNullElement;
        public List<ConditionalPredicateValueDefNumberNullElement> ConditionalPredicateValueDefNumberNullElementArray;

        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(ConditionalPredicateValueDefNumberNullElement conditionalPredicateValueDefNumberNullElement)
        {
            return new ConditionalAxisPropertyNumberNullConditionUnion
            {
                ConditionalPredicateValueDefNumberNullElement = conditionalPredicateValueDefNumberNullElement
            };
        }

        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(List<ConditionalPredicateValueDefNumberNullElement> conditionalPredicateValueDefNumberNullElementArray)
        {
            return new ConditionalAxisPropertyNumberNullConditionUnion
            {
                ConditionalPredicateValueDefNumberNullElementArray = conditionalPredicateValueDefNumberNullElementArray
            };
        }
    }
}
