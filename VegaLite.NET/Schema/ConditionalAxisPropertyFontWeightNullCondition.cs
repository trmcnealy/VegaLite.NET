using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyFontWeightNullCondition
    {
        public ConditionalPredicateValueDefFontWeightNull       ConditionalPredicateValueDefFontWeightNull;
        public List<ConditionalPredicateValueDefFontWeightNull> ConditionalPredicateValueDefFontWeightNullArray;

        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(ConditionalPredicateValueDefFontWeightNull conditionalPredicateValueDefFontWeightNull)
        {
            return new ConditionalAxisPropertyFontWeightNullCondition
            {
                ConditionalPredicateValueDefFontWeightNull = conditionalPredicateValueDefFontWeightNull
            };
        }

        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(List<ConditionalPredicateValueDefFontWeightNull> conditionalPredicateValueDefFontWeightNullArray)
        {
            return new ConditionalAxisPropertyFontWeightNullCondition
            {
                ConditionalPredicateValueDefFontWeightNullArray = conditionalPredicateValueDefFontWeightNullArray
            };
        }
    }
}
