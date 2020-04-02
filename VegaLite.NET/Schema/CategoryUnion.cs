using System.Collections.Generic;

namespace VegaLite.Schema
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
    /// </summary>
    public struct CategoryUnion
    {
        public List<RangeRaw>    AnythingArray;
        public CategorySignalRef CategorySignalRef;
        public RangeEnum?        Enum;

        public static implicit operator CategoryUnion(List<RangeRaw> anythingArray)
        {
            return new CategoryUnion
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator CategoryUnion(CategorySignalRef categorySignalRef)
        {
            return new CategoryUnion
            {
                CategorySignalRef = categorySignalRef
            };
        }

        public static implicit operator CategoryUnion(RangeEnum @enum)
        {
            return new CategoryUnion
            {
                Enum = @enum
            };
        }
    }
}
