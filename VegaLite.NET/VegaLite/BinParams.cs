using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Binning properties or boolean flag for determining whether to bin data or not.
    /// </summary>
    public class BinParams
    {
        /// <summary>
        /// A value in the binned domain at which to anchor the bins, shifting the bin boundaries if
        /// necessary to ensure that a boundary aligns with the anchor value.
        ///
        /// __Default value:__ the minimum bin extent value
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public double? Anchor { get; set; }

        /// <summary>
        /// The number base to use for automatic bin determination (default is base 10).
        ///
        /// __Default value:__ `10`
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public double? Base { get; set; }

        /// <summary>
        /// When set to `true`, Vega-Lite treats the input data as already binned.
        /// </summary>
        [JsonProperty("binned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Binned { get; set; }

        /// <summary>
        /// Scale factors indicating allowable subdivisions. The default value is [5, 2], which
        /// indicates that for base 10 numbers (the default base), the method may consider dividing
        /// bin sizes by 5 and/or 2. For example, for an initial step size of 10, the method can
        /// check if bin sizes of 2 (= 10/5), 5 (= 10/2), or 1 (= 10/(5*2)) might also satisfy the
        /// given constraints.
        ///
        /// __Default value:__ `[5, 2]`
        /// </summary>
        [JsonProperty("divide", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Divide { get; set; }

        /// <summary>
        /// A two-element (`[min, max]`) array indicating the range of desired bin values.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public BinExtent? Extent { get; set; }

        /// <summary>
        /// Maximum number of bins.
        ///
        /// __Default value:__ `6` for `row`, `column` and `shape` channels; `10` for other channels
        /// </summary>
        [JsonProperty("maxbins", NullValueHandling = NullValueHandling.Ignore)]
        public double? Maxbins { get; set; }

        /// <summary>
        /// A minimum allowable step size (particularly useful for integer values).
        /// </summary>
        [JsonProperty("minstep", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minstep { get; set; }

        /// <summary>
        /// If true, attempts to make the bin boundaries use human-friendly boundaries, such as
        /// multiples of ten.
        ///
        /// __Default value:__ `true`
        /// </summary>
        [JsonProperty("nice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nice { get; set; }

        /// <summary>
        /// An exact step size to use between bins.
        ///
        /// __Note:__ If provided, options such as maxbins will be ignored.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// An array of allowable step sizes to choose from.
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Steps { get; set; }
    }
}