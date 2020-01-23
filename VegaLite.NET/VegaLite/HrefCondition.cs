using System.Collections.Generic;

namespace VegaLite
{
    public struct HrefCondition
    {
        public List<ConditionElement>                  ConditionElementArray;
        public ConditionalPredicateValueDefStringClass ConditionalPredicateValueDefStringClass;

        public static implicit operator HrefCondition(List<ConditionElement>                  ConditionElementArray)                   => new HrefCondition { ConditionElementArray                   = ConditionElementArray };
        public static implicit operator HrefCondition(ConditionalPredicateValueDefStringClass ConditionalPredicateValueDefStringClass) => new HrefCondition { ConditionalPredicateValueDefStringClass = ConditionalPredicateValueDefStringClass };
    }
}