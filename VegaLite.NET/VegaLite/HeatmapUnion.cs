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

        public static implicit operator HeatmapUnion(List<RangeRaw>   AnythingArray)    => new HeatmapUnion { AnythingArray    = AnythingArray };
        public static implicit operator HeatmapUnion(RangeEnum        Enum)             => new HeatmapUnion { Enum             = Enum };
        public static implicit operator HeatmapUnion(HeatmapSignalRef HeatmapSignalRef) => new HeatmapUnion { HeatmapSignalRef = HeatmapSignalRef };
    }
}