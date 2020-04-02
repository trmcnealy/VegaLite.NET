using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// An object hash that defines default range arrays or schemes for using with scales.
    /// For a full list of scale range configuration options, please see the [corresponding
    /// section of the scale
    /// documentation](https://vega.github.io/vega-lite/docs/scale.html#config).
    /// </summary>
    public class RangeConfig
    {
        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
        /// </summary>
        [JsonProperty("category",
                      NullValueHandling = NullValueHandling.Ignore)]
        public CategoryUnion? Category { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for diverging
        /// quantitative ramps.
        /// </summary>
        [JsonProperty("diverging",
                      NullValueHandling = NullValueHandling.Ignore)]
        public DivergingUnion? Diverging { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for quantitative
        /// heatmaps.
        /// </summary>
        [JsonProperty("heatmap",
                      NullValueHandling = NullValueHandling.Ignore)]
        public HeatmapUnion? Heatmap { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
        /// </summary>
        [JsonProperty("ordinal",
                      NullValueHandling = NullValueHandling.Ignore)]
        public OrdinalUnion? Ordinal { get; set; }

        /// <summary>
        /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for sequential
        /// quantitative ramps.
        /// </summary>
        [JsonProperty("ramp",
                      NullValueHandling = NullValueHandling.Ignore)]
        public RampUnion? Ramp { get; set; }

        /// <summary>
        /// Array of [symbol](https://vega.github.io/vega/docs/marks/symbol/) names or paths for the
        /// default shape palette.
        /// </summary>
        [JsonProperty("symbol",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Symbol { get; set; }
    }
}
