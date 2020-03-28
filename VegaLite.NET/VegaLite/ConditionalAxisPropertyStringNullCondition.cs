using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyStringNullCondition
    {
        public ConditionalPredicateStringValueDef       ConditionalPredicateStringValueDef;
        public List<ConditionalPredicateStringValueDef> ConditionalPredicateStringValueDefArray;

        public static implicit operator ConditionalAxisPropertyStringNullCondition(ConditionalPredicateStringValueDef       conditionalPredicateStringValueDef)      => new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDef      = conditionalPredicateStringValueDef };
        public static implicit operator ConditionalAxisPropertyStringNullCondition(List<ConditionalPredicateStringValueDef> conditionalPredicateStringValueDefArray) => new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDefArray = conditionalPredicateStringValueDefArray };
    }
}