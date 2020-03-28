using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for diverging
    /// quantitative ramps.
    /// </summary>
    public struct DivergingUnion
    {
        public List<RangeRaw>     AnythingArray;
        public DivergingSignalRef DivergingSignalRef;
        public RangeEnum?         Enum;

        public static implicit operator DivergingUnion(List<RangeRaw>     anythingArray)      => new DivergingUnion { AnythingArray      = anythingArray };
        public static implicit operator DivergingUnion(DivergingSignalRef divergingSignalRef) => new DivergingUnion { DivergingSignalRef = divergingSignalRef };
        public static implicit operator DivergingUnion(RangeEnum          @enum)               => new DivergingUnion { Enum               = @enum };
    }
}