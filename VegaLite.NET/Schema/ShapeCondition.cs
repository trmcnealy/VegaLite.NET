using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct ShapeCondition
    {
        public ConditionalPredicateMarkPropFieldDefTypeForShapeClass ConditionalPredicateMarkPropFieldDefTypeForShapeClass;
        public List<ConditionalStringValueDef>                       ConditionalStringValueDefArray;

        public static implicit operator ShapeCondition(ConditionalPredicateMarkPropFieldDefTypeForShapeClass conditionalPredicateMarkPropFieldDefTypeForShapeClass)
        {
            return new ShapeCondition
            {
                ConditionalPredicateMarkPropFieldDefTypeForShapeClass = conditionalPredicateMarkPropFieldDefTypeForShapeClass
            };
        }

        public static implicit operator ShapeCondition(List<ConditionalStringValueDef> conditionalStringValueDefArray)
        {
            return new ShapeCondition
            {
                ConditionalStringValueDefArray = conditionalStringValueDefArray
            };
        }
    }
}
