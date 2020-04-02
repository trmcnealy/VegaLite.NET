using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct HrefCondition
    {
        public List<ConditionElement>                  ConditionElementArray;
        public ConditionalPredicateValueDefStringClass ConditionalPredicateValueDefStringClass;

        public static implicit operator HrefCondition(List<ConditionElement> conditionElementArray)
        {
            return new HrefCondition
            {
                ConditionElementArray = conditionElementArray
            };
        }

        public static implicit operator HrefCondition(ConditionalPredicateValueDefStringClass conditionalPredicateValueDefStringClass)
        {
            return new HrefCondition
            {
                ConditionalPredicateValueDefStringClass = conditionalPredicateValueDefStringClass
            };
        }
    }
}
