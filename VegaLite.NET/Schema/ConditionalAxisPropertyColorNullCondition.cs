using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyColorNullCondition
    {
        public ConditionalPredicateValueDefColorNull       ConditionalPredicateValueDefColorNull;
        public List<ConditionalPredicateValueDefColorNull> ConditionalPredicateValueDefColorNullArray;

        public static implicit operator ConditionalAxisPropertyColorNullCondition(ConditionalPredicateValueDefColorNull conditionalPredicateValueDefColorNull)
        {
            return new ConditionalAxisPropertyColorNullCondition
            {
                ConditionalPredicateValueDefColorNull = conditionalPredicateValueDefColorNull
            };
        }

        public static implicit operator ConditionalAxisPropertyColorNullCondition(List<ConditionalPredicateValueDefColorNull> conditionalPredicateValueDefColorNullArray)
        {
            return new ConditionalAxisPropertyColorNullCondition
            {
                ConditionalPredicateValueDefColorNullArray = conditionalPredicateValueDefColorNullArray
            };
        }
    }
}
