using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyNumberNullCondition
    {
        public ConditionalPredicateValueDefNumberNull       ConditionalPredicateValueDefNumberNull;
        public List<ConditionalPredicateValueDefNumberNull> ConditionalPredicateValueDefNumberNullArray;

        public static implicit operator ConditionalAxisPropertyNumberNullCondition(ConditionalPredicateValueDefNumberNull conditionalPredicateValueDefNumberNull)
        {
            return new ConditionalAxisPropertyNumberNullCondition
            {
                ConditionalPredicateValueDefNumberNull = conditionalPredicateValueDefNumberNull
            };
        }

        public static implicit operator ConditionalAxisPropertyNumberNullCondition(List<ConditionalPredicateValueDefNumberNull> conditionalPredicateValueDefNumberNullArray)
        {
            return new ConditionalAxisPropertyNumberNullCondition
            {
                ConditionalPredicateValueDefNumberNullArray = conditionalPredicateValueDefNumberNullArray
            };
        }
    }
}
