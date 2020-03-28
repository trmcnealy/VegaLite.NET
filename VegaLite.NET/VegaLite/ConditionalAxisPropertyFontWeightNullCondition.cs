using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyFontWeightNullCondition
    {
        public ConditionalPredicateValueDefFontWeightNull       ConditionalPredicateValueDefFontWeightNull;
        public List<ConditionalPredicateValueDefFontWeightNull> ConditionalPredicateValueDefFontWeightNullArray;

        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(ConditionalPredicateValueDefFontWeightNull       conditionalPredicateValueDefFontWeightNull)      => new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNull      = conditionalPredicateValueDefFontWeightNull };
        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(List<ConditionalPredicateValueDefFontWeightNull> conditionalPredicateValueDefFontWeightNullArray) => new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNullArray = conditionalPredicateValueDefFontWeightNullArray };
    }
}