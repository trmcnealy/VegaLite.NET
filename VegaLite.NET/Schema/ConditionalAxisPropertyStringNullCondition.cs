using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionalAxisPropertyStringNullCondition
    {
        public ConditionalPredicateStringValueDef       ConditionalPredicateStringValueDef;
        public List<ConditionalPredicateStringValueDef> ConditionalPredicateStringValueDefArray;

        public static implicit operator ConditionalAxisPropertyStringNullCondition(ConditionalPredicateStringValueDef conditionalPredicateStringValueDef)
        {
            return new ConditionalAxisPropertyStringNullCondition
            {
                ConditionalPredicateStringValueDef = conditionalPredicateStringValueDef
            };
        }

        public static implicit operator ConditionalAxisPropertyStringNullCondition(List<ConditionalPredicateStringValueDef> conditionalPredicateStringValueDefArray)
        {
            return new ConditionalAxisPropertyStringNullCondition
            {
                ConditionalPredicateStringValueDefArray = conditionalPredicateStringValueDefArray
            };
        }
    }
}
