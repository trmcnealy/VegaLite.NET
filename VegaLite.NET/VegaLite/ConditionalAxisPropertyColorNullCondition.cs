using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyColorNullCondition
    {
        public ConditionalPredicateValueDefColorNull       ConditionalPredicateValueDefColorNull;
        public List<ConditionalPredicateValueDefColorNull> ConditionalPredicateValueDefColorNullArray;

        public static implicit operator ConditionalAxisPropertyColorNullCondition(ConditionalPredicateValueDefColorNull       ConditionalPredicateValueDefColorNull)      => new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNull      = ConditionalPredicateValueDefColorNull };
        public static implicit operator ConditionalAxisPropertyColorNullCondition(List<ConditionalPredicateValueDefColorNull> ConditionalPredicateValueDefColorNullArray) => new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNullArray = ConditionalPredicateValueDefColorNullArray };
    }
}