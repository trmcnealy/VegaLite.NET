using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct TextCondition
    {
        public ConditionalPredicateValueDefTextClass ConditionalPredicateValueDefTextClass;
        public List<ConditionalValueDefText>         ConditionalValueDefTextArray;

        public static implicit operator TextCondition(ConditionalPredicateValueDefTextClass conditionalPredicateValueDefTextClass)
        {
            return new TextCondition
            {
                ConditionalPredicateValueDefTextClass = conditionalPredicateValueDefTextClass
            };
        }

        public static implicit operator TextCondition(List<ConditionalValueDefText> conditionalValueDefTextArray)
        {
            return new TextCondition
            {
                ConditionalValueDefTextArray = conditionalValueDefTextArray
            };
        }
    }
}
