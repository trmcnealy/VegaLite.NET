using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyTextBaselineNullCondition
    {
        public ConditionalPredicateValueDefTextBaselineNull       ConditionalPredicateValueDefTextBaselineNull;
        public List<ConditionalPredicateValueDefTextBaselineNull> ConditionalPredicateValueDefTextBaselineNullArray;

        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(ConditionalPredicateValueDefTextBaselineNull conditionalPredicateValueDefTextBaselineNull)
        {
            return new ConditionalAxisPropertyTextBaselineNullCondition
            {
                ConditionalPredicateValueDefTextBaselineNull = conditionalPredicateValueDefTextBaselineNull
            };
        }

        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(List<ConditionalPredicateValueDefTextBaselineNull> conditionalPredicateValueDefTextBaselineNullArray)
        {
            return new ConditionalAxisPropertyTextBaselineNullCondition
            {
                ConditionalPredicateValueDefTextBaselineNullArray = conditionalPredicateValueDefTextBaselineNullArray
            };
        }
    }
}
