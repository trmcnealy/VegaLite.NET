using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyTextBaselineNullCondition
    {
        public ConditionalPredicateValueDefTextBaselineNull       ConditionalPredicateValueDefTextBaselineNull;
        public List<ConditionalPredicateValueDefTextBaselineNull> ConditionalPredicateValueDefTextBaselineNullArray;

        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(ConditionalPredicateValueDefTextBaselineNull       ConditionalPredicateValueDefTextBaselineNull)      => new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNull      = ConditionalPredicateValueDefTextBaselineNull };
        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(List<ConditionalPredicateValueDefTextBaselineNull> ConditionalPredicateValueDefTextBaselineNullArray) => new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNullArray = ConditionalPredicateValueDefTextBaselineNullArray };
    }
}