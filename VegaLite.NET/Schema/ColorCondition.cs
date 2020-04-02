using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ColorCondition
    {
        public ConditionalPredicateValueDefGradientStringNullClass ConditionalPredicateValueDefGradientStringNullClass;
        public List<ConditionalValueDefGradientStringNull>         ConditionalValueDefGradientStringNullArray;

        public static implicit operator ColorCondition(ConditionalPredicateValueDefGradientStringNullClass conditionalPredicateValueDefGradientStringNullClass)
        {
            return new ColorCondition
            {
                ConditionalPredicateValueDefGradientStringNullClass = conditionalPredicateValueDefGradientStringNullClass
            };
        }

        public static implicit operator ColorCondition(List<ConditionalValueDefGradientStringNull> conditionalValueDefGradientStringNullArray)
        {
            return new ColorCondition
            {
                ConditionalValueDefGradientStringNullArray = conditionalValueDefGradientStringNullArray
            };
        }
    }
}
