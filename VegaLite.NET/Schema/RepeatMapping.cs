using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class RepeatMapping
    {
        /// <summary>
        /// An array of fields to be repeated horizontally.
        /// </summary>
        [JsonProperty("column",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Column { get; set; }

        /// <summary>
        /// An array of fields to be repeated vertically.
        /// </summary>
        [JsonProperty("row",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Row { get; set; }
    }
}
