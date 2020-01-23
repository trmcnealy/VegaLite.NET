using Newtonsoft.Json;

namespace VegaLite
{
    public class BinExtentClass
    {
        /// <summary>
        /// The field name to extract selected values for, when a selection is
        /// [projected](https://vega.github.io/vega-lite/docs/project.html)
        /// over multiple fields or encodings.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The name of a selection.
        /// </summary>
        [JsonProperty("selection", Required = Required.Always)]
        public string Selection { get; set; }

        /// <summary>
        /// The encoding channel to extract selected values for, when a selection is
        /// [projected](https://vega.github.io/vega-lite/docs/project.html)
        /// over multiple fields or encodings.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public SingleDefUnitChannel? Encoding { get; set; }
    }
}