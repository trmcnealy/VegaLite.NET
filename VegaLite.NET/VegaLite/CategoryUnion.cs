using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
    /// </summary>
    public struct CategoryUnion
    {
        public List<RangeRaw>    AnythingArray;
        public CategorySignalRef CategorySignalRef;
        public RangeEnum?        Enum;

        public static implicit operator CategoryUnion(List<RangeRaw>    AnythingArray)     => new CategoryUnion { AnythingArray     = AnythingArray };
        public static implicit operator CategoryUnion(CategorySignalRef CategorySignalRef) => new CategoryUnion { CategorySignalRef = CategorySignalRef };
        public static implicit operator CategoryUnion(RangeEnum         Enum)              => new CategoryUnion { Enum              = Enum };
    }
}