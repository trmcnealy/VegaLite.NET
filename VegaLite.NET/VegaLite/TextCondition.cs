using System.Collections.Generic;

namespace VegaLite
{
    public struct TextCondition
    {
        public ConditionalPredicateValueDefTextClass ConditionalPredicateValueDefTextClass;
        public List<ConditionalValueDefText>         ConditionalValueDefTextArray;

        public static implicit operator TextCondition(ConditionalPredicateValueDefTextClass ConditionalPredicateValueDefTextClass) => new TextCondition { ConditionalPredicateValueDefTextClass = ConditionalPredicateValueDefTextClass };
        public static implicit operator TextCondition(List<ConditionalValueDefText>         ConditionalValueDefTextArray)          => new TextCondition { ConditionalValueDefTextArray          = ConditionalValueDefTextArray };
    }
}