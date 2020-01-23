using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for sequential
    /// quantitative ramps.
    /// </summary>
    public struct RampUnion
    {
        public List<RangeRaw> AnythingArray;
        public RangeEnum?     Enum;
        public RampSignalRef  RampSignalRef;

        public static implicit operator RampUnion(List<RangeRaw> AnythingArray) => new RampUnion { AnythingArray = AnythingArray };
        public static implicit operator RampUnion(RangeEnum      Enum)          => new RampUnion { Enum          = Enum };
        public static implicit operator RampUnion(RampSignalRef  RampSignalRef) => new RampUnion { RampSignalRef = RampSignalRef };
    }
}