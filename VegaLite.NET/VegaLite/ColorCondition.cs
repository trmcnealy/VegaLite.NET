using System.Collections.Generic;

namespace VegaLite
{
    public struct ColorCondition
    {
        public ConditionalPredicateValueDefGradientStringNullClass ConditionalPredicateValueDefGradientStringNullClass;
        public List<ConditionalValueDefGradientStringNull>         ConditionalValueDefGradientStringNullArray;

        public static implicit operator ColorCondition(ConditionalPredicateValueDefGradientStringNullClass conditionalPredicateValueDefGradientStringNullClass) => new ColorCondition { ConditionalPredicateValueDefGradientStringNullClass = conditionalPredicateValueDefGradientStringNullClass };
        public static implicit operator ColorCondition(List<ConditionalValueDefGradientStringNull>         conditionalValueDefGradientStringNullArray)          => new ColorCondition { ConditionalValueDefGradientStringNullArray          = conditionalValueDefGradientStringNullArray };
    }
}