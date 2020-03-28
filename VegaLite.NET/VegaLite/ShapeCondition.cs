using System.Collections.Generic;

namespace VegaLite
{
    public struct ShapeCondition
    {
        public ConditionalPredicateMarkPropFieldDefTypeForShapeClass ConditionalPredicateMarkPropFieldDefTypeForShapeClass;
        public List<ConditionalStringValueDef>                       ConditionalStringValueDefArray;

        public static implicit operator ShapeCondition(ConditionalPredicateMarkPropFieldDefTypeForShapeClass conditionalPredicateMarkPropFieldDefTypeForShapeClass) => new ShapeCondition { ConditionalPredicateMarkPropFieldDefTypeForShapeClass = conditionalPredicateMarkPropFieldDefTypeForShapeClass };
        public static implicit operator ShapeCondition(List<ConditionalStringValueDef>                       conditionalStringValueDefArray)                        => new ShapeCondition { ConditionalStringValueDefArray                        = conditionalStringValueDefArray };
    }
}