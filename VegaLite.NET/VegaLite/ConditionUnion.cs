using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionUnion
    {
        public ConditionalDef                  ConditionalDef;
        public List<ConditionalNumberValueDef> ConditionalNumberValueDefArray;

        public static implicit operator ConditionUnion(ConditionalDef                  conditionalDef)                 => new ConditionUnion { ConditionalDef                 = conditionalDef };
        public static implicit operator ConditionUnion(List<ConditionalNumberValueDef> conditionalNumberValueDefArray) => new ConditionUnion { ConditionalNumberValueDefArray = conditionalNumberValueDefArray };
    }
}