using System.Collections.Generic;

namespace VegaLite
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

        public static implicit operator HeatmapUnion(List<RangeRaw>   anythingArray)    => new HeatmapUnion { AnythingArray    = anythingArray };
        public static implicit operator HeatmapUnion(RangeEnum        @enum)             => new HeatmapUnion { Enum             = @enum };
        public static implicit operator HeatmapUnion(HeatmapSignalRef heatmapSignalRef) => new HeatmapUnion { HeatmapSignalRef = heatmapSignalRef };
    }
}