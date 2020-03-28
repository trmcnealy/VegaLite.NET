using System.Collections.Generic;

namespace VegaLite
{
    public struct HrefCondition
    {
        public List<ConditionElement>                  ConditionElementArray;
        public ConditionalPredicateValueDefStringClass ConditionalPredicateValueDefStringClass;

        public static implicit operator HrefCondition(List<ConditionElement>                  conditionElementArray)                   => new HrefCondition { ConditionElementArray                   = conditionElementArray };
        public static implicit operator HrefCondition(ConditionalPredicateValueDefStringClass conditionalPredicateValueDefStringClass) => new HrefCondition { ConditionalPredicateValueDefStringClass = conditionalPredicateValueDefStringClass };
    }
}