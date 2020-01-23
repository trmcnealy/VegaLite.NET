using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyNumberNullCondition
    {
        public ConditionalPredicateValueDefNumberNull       ConditionalPredicateValueDefNumberNull;
        public List<ConditionalPredicateValueDefNumberNull> ConditionalPredicateValueDefNumberNullArray;

        public static implicit operator ConditionalAxisPropertyNumberNullCondition(ConditionalPredicateValueDefNumberNull       ConditionalPredicateValueDefNumberNull)      => new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNull      = ConditionalPredicateValueDefNumberNull };
        public static implicit operator ConditionalAxisPropertyNumberNullCondition(List<ConditionalPredicateValueDefNumberNull> ConditionalPredicateValueDefNumberNullArray) => new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNullArray = ConditionalPredicateValueDefNumberNullArray };
    }
}