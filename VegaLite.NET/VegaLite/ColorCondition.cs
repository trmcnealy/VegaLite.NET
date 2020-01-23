using System.Collections.Generic;

namespace VegaLite
{
    public struct ColorCondition
    {
        public ConditionalPredicateValueDefGradientStringNullClass ConditionalPredicateValueDefGradientStringNullClass;
        public List<ConditionalValueDefGradientStringNull>         ConditionalValueDefGradientStringNullArray;

        public static implicit operator ColorCondition(ConditionalPredicateValueDefGradientStringNullClass ConditionalPredicateValueDefGradientStringNullClass) => new ColorCondition { ConditionalPredicateValueDefGradientStringNullClass = ConditionalPredicateValueDefGradientStringNullClass };
        public static implicit operator ColorCondition(List<ConditionalValueDefGradientStringNull>         ConditionalValueDefGradientStringNullArray)          => new ColorCondition { ConditionalValueDefGradientStringNullArray          = ConditionalValueDefGradientStringNullArray };
    }
}