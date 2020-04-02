using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class GraticuleParams
    {
        /// <summary>
        /// Sets both the major and minor extents to the same values.
        /// </summary>
        [JsonProperty("extent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> Extent { get; set; }

        /// <summary>
        /// The major extent of the graticule as a two-element array of coordinates.
        /// </summary>
        [JsonProperty("extentMajor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> ExtentMajor { get; set; }

        /// <summary>
        /// The minor extent of the graticule as a two-element array of coordinates.
        /// </summary>
        [JsonProperty("extentMinor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> ExtentMinor { get; set; }

        /// <summary>
        /// The precision of the graticule in degrees.
        ///
        /// __Default value:__ `2.5`
        /// </summary>
        [JsonProperty("precision",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Precision { get; set; }

        /// <summary>
        /// Sets both the major and minor step angles to the same values.
        /// </summary>
        [JsonProperty("step",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Step { get; set; }

        /// <summary>
        /// The major step angles of the graticule.
        ///
        ///
        /// __Default value:__ `[90, 360]`
        /// </summary>
        [JsonProperty("stepMajor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StepMajor { get; set; }

        /// <summary>
        /// The minor step angles of the graticule.
        ///
        /// __Default value:__ `[10, 10]`
        /// </summary>
        [JsonProperty("stepMinor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StepMinor { get; set; }
    }
}
