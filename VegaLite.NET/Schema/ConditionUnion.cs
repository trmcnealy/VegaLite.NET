using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ConditionUnion
    {
        public ConditionalDef                  ConditionalDef;
        public List<ConditionalNumberValueDef> ConditionalNumberValueDefArray;

        public static implicit operator ConditionUnion(ConditionalDef conditionalDef)
        {
            return new ConditionUnion
            {
                ConditionalDef = conditionalDef
            };
        }

        public static implicit operator ConditionUnion(List<ConditionalNumberValueDef> conditionalNumberValueDefArray)
        {
            return new ConditionUnion
            {
                ConditionalNumberValueDefArray = conditionalNumberValueDefArray
            };
        }
    }
}
