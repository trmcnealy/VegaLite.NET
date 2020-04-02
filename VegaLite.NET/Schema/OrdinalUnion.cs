using System.Collections.Generic;

namespace VegaLite.Schema
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
    /// </summary>
    public struct OrdinalUnion
    {
        public List<RangeRaw>   AnythingArray;
        public RangeEnum?       Enum;
        public OrdinalSignalRef OrdinalSignalRef;

        public static implicit operator OrdinalUnion(List<RangeRaw> anythingArray)
        {
            return new OrdinalUnion
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator OrdinalUnion(RangeEnum @enum)
        {
            return new OrdinalUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator OrdinalUnion(OrdinalSignalRef ordinalSignalRef)
        {
            return new OrdinalUnion
            {
                OrdinalSignalRef = ordinalSignalRef
            };
        }
    }
}
