using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyTextBaselineNullCondition
    {
        public ConditionalPredicateValueDefTextBaselineNull       ConditionalPredicateValueDefTextBaselineNull;
        public List<ConditionalPredicateValueDefTextBaselineNull> ConditionalPredicateValueDefTextBaselineNullArray;

        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(ConditionalPredicateValueDefTextBaselineNull       conditionalPredicateValueDefTextBaselineNull)      => new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNull      = conditionalPredicateValueDefTextBaselineNull };
        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(List<ConditionalPredicateValueDefTextBaselineNull> conditionalPredicateValueDefTextBaselineNullArray) => new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNullArray = conditionalPredicateValueDefTextBaselineNullArray };
    }
}