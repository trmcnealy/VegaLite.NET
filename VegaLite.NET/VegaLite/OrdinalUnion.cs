using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
    /// </summary>
    public struct OrdinalUnion
    {
        public List<RangeRaw>   AnythingArray;
        public RangeEnum?       Enum;
        public OrdinalSignalRef OrdinalSignalRef;

        public static implicit operator OrdinalUnion(List<RangeRaw>   anythingArray)    => new OrdinalUnion { AnythingArray    = anythingArray };
        public static implicit operator OrdinalUnion(RangeEnum        @enum)             => new OrdinalUnion { Enum             = @enum };
        public static implicit operator OrdinalUnion(OrdinalSignalRef ordinalSignalRef) => new OrdinalUnion { OrdinalSignalRef = ordinalSignalRef };
    }
}