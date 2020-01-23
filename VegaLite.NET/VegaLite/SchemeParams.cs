using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    public class SchemeParams
    {
        /// <summary>
        /// The number of colors to use in the scheme. This can be useful for scale types such as
        /// `"quantize"`, which use the length of the scale range to determine the number of discrete
        /// bins for the scale domain.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        /// <summary>
        /// The extent of the color range to use. For example `[0.2, 1]` will rescale the color
        /// scheme such that color values in the range _[0, 0.2)_ are excluded from the scheme.
        /// </summary>
        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Extent { get; set; }

        /// <summary>
        /// A color scheme name for ordinal scales (e.g., `"category10"` or `"blues"`).
        ///
        /// For the full list of supported schemes, please refer to the [Vega
        /// Scheme](https://vega.github.io/vega/docs/schemes/#reference) reference.
        /// </summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}