using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Scale configuration determines default properties for all
    /// [scales](https://vega.github.io/vega-lite/docs/scale.html). For a full list of scale
    /// configuration options, please see the [corresponding section of the scale
    /// documentation](https://vega.github.io/vega-lite/docs/scale.html#config).
    /// </summary>
    public class ScaleConfig
    {
        /// <summary>
        /// Default inner padding for `x` and `y` band-ordinal scales.
        ///
        /// __Default value:__
        /// - `barBandPaddingInner` for bar marks (`0.1` by default)
        /// - `rectBandPaddingInner` for rect and other marks (`0` by default)
        /// </summary>
        [JsonProperty("bandPaddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPaddingInner { get; set; }

        /// <summary>
        /// Default outer padding for `x` and `y` band-ordinal scales.
        ///
        /// __Default value:__ `paddingInner/2` (which makes _width/height = number of unique values
        /// * step_)
        /// </summary>
        [JsonProperty("bandPaddingOuter", NullValueHandling = NullValueHandling.Ignore)]
        public double? BandPaddingOuter { get; set; }

        /// <summary>
        /// Default inner padding for `x` and `y` band-ordinal scales of `"bar"` marks.
        ///
        /// __Default value:__ `0.1`
        /// </summary>
        [JsonProperty("barBandPaddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? BarBandPaddingInner { get; set; }

        /// <summary>
        /// If true, values that exceed the data domain are clamped to either the minimum or maximum
        /// range value
        /// </summary>
        [JsonProperty("clamp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clamp { get; set; }

        /// <summary>
        /// Default padding for continuous scales.
        ///
        /// __Default:__ `5` for continuous x-scale of a vertical bar and continuous y-scale of a
        /// horizontal bar.; `0` otherwise.
        /// </summary>
        [JsonProperty("continuousPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? ContinuousPadding { get; set; }

        /// <summary>
        /// The default max value for mapping quantitative fields to bar's size/bandSize.
        ///
        /// If undefined (default), we will use the axis's size (width or height) - 1.
        /// </summary>
        [JsonProperty("maxBandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxBandSize { get; set; }

        /// <summary>
        /// The default max value for mapping quantitative fields to text's size/fontSize.
        ///
        /// __Default value:__ `40`
        /// </summary>
        [JsonProperty("maxFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxFontSize { get; set; }

        /// <summary>
        /// Default max opacity for mapping a field to opacity.
        ///
        /// __Default value:__ `0.8`
        /// </summary>
        [JsonProperty("maxOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxOpacity { get; set; }

        /// <summary>
        /// Default max value for point size scale.
        /// </summary>
        [JsonProperty("maxSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxSize { get; set; }

        /// <summary>
        /// Default max strokeWidth for the scale of strokeWidth for rule and line marks and of size
        /// for trail marks.
        ///
        /// __Default value:__ `4`
        /// </summary>
        [JsonProperty("maxStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxStrokeWidth { get; set; }

        /// <summary>
        /// The default min value for mapping quantitative fields to bar and tick's size/bandSize
        /// scale with zero=false.
        ///
        /// __Default value:__ `2`
        /// </summary>
        [JsonProperty("minBandSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinBandSize { get; set; }

        /// <summary>
        /// The default min value for mapping quantitative fields to tick's size/fontSize scale with
        /// zero=false
        ///
        /// __Default value:__ `8`
        /// </summary>
        [JsonProperty("minFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinFontSize { get; set; }

        /// <summary>
        /// Default minimum opacity for mapping a field to opacity.
        ///
        /// __Default value:__ `0.3`
        /// </summary>
        [JsonProperty("minOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinOpacity { get; set; }

        /// <summary>
        /// Default minimum value for point size scale with zero=false.
        ///
        /// __Default value:__ `9`
        /// </summary>
        [JsonProperty("minSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinSize { get; set; }

        /// <summary>
        /// Default minimum strokeWidth for the scale of strokeWidth for rule and line marks and of
        /// size for trail marks with zero=false.
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("minStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinStrokeWidth { get; set; }

        /// <summary>
        /// Default outer padding for `x` and `y` point-ordinal scales.
        ///
        /// __Default value:__ `0.5` (which makes _width/height = number of unique values * step_)
        /// </summary>
        [JsonProperty("pointPadding", NullValueHandling = NullValueHandling.Ignore)]
        public double? PointPadding { get; set; }

        /// <summary>
        /// Default range cardinality for
        /// [`quantile`](https://vega.github.io/vega-lite/docs/scale.html#quantile) scale.
        ///
        /// __Default value:__ `4`
        /// </summary>
        [JsonProperty("quantileCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? QuantileCount { get; set; }

        /// <summary>
        /// Default range cardinality for
        /// [`quantize`](https://vega.github.io/vega-lite/docs/scale.html#quantize) scale.
        ///
        /// __Default value:__ `4`
        /// </summary>
        [JsonProperty("quantizeCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? QuantizeCount { get; set; }

        /// <summary>
        /// Default inner padding for `x` and `y` band-ordinal scales of `"rect"` marks.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("rectBandPaddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public double? RectBandPaddingInner { get; set; }

        /// <summary>
        /// If true, rounds numeric output values to integers.
        /// This can be helpful for snapping to the pixel grid.
        /// (Only available for `x`, `y`, and `size` scales.)
        /// </summary>
        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Round { get; set; }

        /// <summary>
        /// Use the source data range before aggregation as scale domain instead of aggregated data
        /// for aggregate axis.
        ///
        /// This is equivalent to setting `domain` to `"unaggregate"` for aggregated _quantitative_
        /// fields by default.
        ///
        /// This property only works with aggregate functions that produce values within the raw data
        /// domain (`"mean"`, `"average"`, `"median"`, `"q1"`, `"q3"`, `"min"`, `"max"`). For other
        /// aggregations that produce values outside of the raw data domain (e.g. `"count"`,
        /// `"sum"`), this property is ignored.
        ///
        /// __Default value:__ `false`
        /// </summary>
        [JsonProperty("useUnaggregatedDomain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseUnaggregatedDomain { get; set; }
    }
}