using System.Collections.Generic;

namespace VegaLite
{
    public struct ConditionUnion
    {
        public ConditionalDef                  ConditionalDef;
        public List<ConditionalNumberValueDef> ConditionalNumberValueDefArray;

        public static implicit operator ConditionUnion(ConditionalDef                  ConditionalDef)                 => new ConditionUnion { ConditionalDef                 = ConditionalDef };
        public static implicit operator ConditionUnion(List<ConditionalNumberValueDef> ConditionalNumberValueDefArray) => new ConditionUnion { ConditionalNumberValueDefArray = ConditionalNumberValueDefArray };
    }
}