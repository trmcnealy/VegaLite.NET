using System.Collections.Generic;

namespace VegaLite
{
    public struct ShapeCondition
    {
        public ConditionalPredicateMarkPropFieldDefTypeForShapeClass ConditionalPredicateMarkPropFieldDefTypeForShapeClass;
        public List<ConditionalStringValueDef>                       ConditionalStringValueDefArray;

        public static implicit operator ShapeCondition(ConditionalPredicateMarkPropFieldDefTypeForShapeClass ConditionalPredicateMarkPropFieldDefTypeForShapeClass) => new ShapeCondition { ConditionalPredicateMarkPropFieldDefTypeForShapeClass = ConditionalPredicateMarkPropFieldDefTypeForShapeClass };
        public static implicit operator ShapeCondition(List<ConditionalStringValueDef>                       ConditionalStringValueDefArray)                        => new ShapeCondition { ConditionalStringValueDefArray                        = ConditionalStringValueDefArray };
    }
}