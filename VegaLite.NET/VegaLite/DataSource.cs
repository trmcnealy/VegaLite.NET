using Newtonsoft.Json;

namespace VegaLite
{
    public class DataSource
    {
        /// <summary>
        /// An object that specifies the format for parsing the data.
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public DataFormat Format { get; set; }

        /// <summary>
        /// Provide a placeholder name and bind data at runtime.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// An URL from which to load the data set. Use the `format.type` property
        /// to ensure the loaded data is correctly parsed.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The full data set, included inline. This can be an array of objects or primitive values,
        /// an object, or a string.
        /// Arrays of primitive values are ingested as objects with a `data` property. Strings are
        /// parsed according to the specified format type.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public InlineDataset? Values { get; set; }

        /// <summary>
        /// Generate a sequence of numbers.
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public SequenceParams Sequence { get; set; }

        /// <summary>
        /// Generate sphere GeoJSON data for the full globe.
        /// </summary>
        [JsonProperty("sphere", NullValueHandling = NullValueHandling.Ignore)]
        public SphereUnion? Sphere { get; set; }

        /// <summary>
        /// Generate graticule GeoJSON data for geographic reference lines.
        /// </summary>
        [JsonProperty("graticule", NullValueHandling = NullValueHandling.Ignore)]
        public Graticule? Graticule { get; set; }
    }
}