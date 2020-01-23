using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionalAxisPropertyStringNullCondition
    {
        public ConditionalPredicateStringValueDef       ConditionalPredicateStringValueDef;
        public List<ConditionalPredicateStringValueDef> ConditionalPredicateStringValueDefArray;

        public static implicit operator ConditionalAxisPropertyStringNullCondition(ConditionalPredicateStringValueDef       ConditionalPredicateStringValueDef)      => new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDef      = ConditionalPredicateStringValueDef };
        public static implicit operator ConditionalAxisPropertyStringNullCondition(List<ConditionalPredicateStringValueDef> ConditionalPredicateStringValueDefArray) => new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDefArray = ConditionalPredicateStringValueDefArray };
    }
}