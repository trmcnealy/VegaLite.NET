using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyNumberNullCondition
    {
        public ConditionalPredicateValueDefNumberNull       ConditionalPredicateValueDefNumberNull;
        public List<ConditionalPredicateValueDefNumberNull> ConditionalPredicateValueDefNumberNullArray;

        public static implicit operator ConditionalAxisPropertyNumberNullCondition(ConditionalPredicateValueDefNumberNull       conditionalPredicateValueDefNumberNull)      => new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNull      = conditionalPredicateValueDefNumberNull };
        public static implicit operator ConditionalAxisPropertyNumberNullCondition(List<ConditionalPredicateValueDefNumberNull> conditionalPredicateValueDefNumberNullArray) => new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNullArray = conditionalPredicateValueDefNumberNullArray };
    }
}