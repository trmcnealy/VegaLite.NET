using System.Collections.Generic;

namespace VegaLite
{
    public struct TextCondition
    {
        public ConditionalPredicateValueDefTextClass ConditionalPredicateValueDefTextClass;
        public List<ConditionalValueDefText>         ConditionalValueDefTextArray;

        public static implicit operator TextCondition(ConditionalPredicateValueDefTextClass conditionalPredicateValueDefTextClass) => new TextCondition { ConditionalPredicateValueDefTextClass = conditionalPredicateValueDefTextClass };
        public static implicit operator TextCondition(List<ConditionalValueDefText>         conditionalValueDefTextArray)          => new TextCondition { ConditionalValueDefTextArray          = conditionalValueDefTextArray };
    }
}