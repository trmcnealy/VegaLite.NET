using System.Collections.Generic;

namespace VegaLite.Schema
{
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for quantitative
    /// heatmaps.
    /// </summary>
    public struct HeatmapUnion
    {
        public List<RangeRaw>   AnythingArray;
        public RangeEnum?       Enum;
        public HeatmapSignalRef HeatmapSignalRef;

        public static implicit operator HeatmapUnion(List<RangeRaw> anythingArray)
        {
            return new HeatmapUnion
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator HeatmapUnion(RangeEnum @enum)
        {
            return new HeatmapUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator HeatmapUnion(HeatmapSignalRef heatmapSignalRef)
        {
            return new HeatmapUnion
            {
                HeatmapSignalRef = heatmapSignalRef
            };
        }
    }
}
