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

        public static implicit operator DivergingUnion(List<RangeRaw>     AnythingArray)      => new DivergingUnion { AnythingArray      = AnythingArray };
        public static implicit operator DivergingUnion(DivergingSignalRef DivergingSignalRef) => new DivergingUnion { DivergingSignalRef = DivergingSignalRef };
        public static implicit operator DivergingUnion(RangeEnum          Enum)               => new DivergingUnion { Enum               = Enum };
    }
}