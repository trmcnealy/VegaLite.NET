using System.Collections.Generic;

namespace VegaLite.Schema
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

        public static implicit operator RampUnion(List<RangeRaw> anythingArray)
        {
            return new RampUnion
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator RampUnion(RangeEnum @enum)
        {
            return new RampUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator RampUnion(RampSignalRef rampSignalRef)
        {
            return new RampUnion
            {
                RampSignalRef = rampSignalRef
            };
        }
    }
}
