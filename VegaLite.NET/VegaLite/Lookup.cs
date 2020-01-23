using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// DataSource source or selection for secondary data reference.
    /// </summary>
    public class Lookup
    {
        /// <summary>
        /// Secondary data source to lookup in.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }

        /// <summary>
        /// Fields in foreign data or selection to lookup.
        /// If not specified, the entire object is queried.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Key in data to lookup.
        /// </summary>
        [JsonProperty("key", Required = Required.Always)]
        public string Key { get; set; }

        /// <summary>
        /// Selection name to look up.
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public string Selection { get; set; }
    }
}