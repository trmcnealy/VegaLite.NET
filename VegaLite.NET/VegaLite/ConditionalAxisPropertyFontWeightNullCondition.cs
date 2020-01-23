using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyFontWeightNullCondition
    {
        public ConditionalPredicateValueDefFontWeightNull       ConditionalPredicateValueDefFontWeightNull;
        public List<ConditionalPredicateValueDefFontWeightNull> ConditionalPredicateValueDefFontWeightNullArray;

        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(ConditionalPredicateValueDefFontWeightNull       ConditionalPredicateValueDefFontWeightNull)      => new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNull      = ConditionalPredicateValueDefFontWeightNull };
        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(List<ConditionalPredicateValueDefFontWeightNull> ConditionalPredicateValueDefFontWeightNullArray) => new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNullArray = ConditionalPredicateValueDefFontWeightNullArray };
    }
}