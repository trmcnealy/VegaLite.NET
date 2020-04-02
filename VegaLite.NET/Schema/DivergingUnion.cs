using System.Collections.Generic;

namespace VegaLite.Schema
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

        public static implicit operator DivergingUnion(List<RangeRaw> anythingArray)
        {
            return new DivergingUnion
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator DivergingUnion(DivergingSignalRef divergingSignalRef)
        {
            return new DivergingUnion
            {
                DivergingSignalRef = divergingSignalRef
            };
        }

        public static implicit operator DivergingUnion(RangeEnum @enum)
        {
            return new DivergingUnion
            {
                Enum = @enum
            };
        }
    }
}
