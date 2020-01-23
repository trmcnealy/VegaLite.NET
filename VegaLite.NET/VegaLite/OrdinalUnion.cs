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

        public static implicit operator OrdinalUnion(List<RangeRaw>   AnythingArray)    => new OrdinalUnion { AnythingArray    = AnythingArray };
        public static implicit operator OrdinalUnion(RangeEnum        Enum)             => new OrdinalUnion { Enum             = Enum };
        public static implicit operator OrdinalUnion(OrdinalSignalRef OrdinalSignalRef) => new OrdinalUnion { OrdinalSignalRef = OrdinalSignalRef };
    }
}