using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyColorNullCondition
    {
        public ConditionalPredicateValueDefColorNull       ConditionalPredicateValueDefColorNull;
        public List<ConditionalPredicateValueDefColorNull> ConditionalPredicateValueDefColorNullArray;

        public static implicit operator ConditionalAxisPropertyColorNullCondition(ConditionalPredicateValueDefColorNull       conditionalPredicateValueDefColorNull)      => new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNull      = conditionalPredicateValueDefColorNull };
        public static implicit operator ConditionalAxisPropertyColorNullCondition(List<ConditionalPredicateValueDefColorNull> conditionalPredicateValueDefColorNullArray) => new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNullArray = conditionalPredicateValueDefColorNullArray };
    }
}