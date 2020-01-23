using Newtonsoft.Json;

namespace VegaLite
{
    public class RowColBoolean
    {
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Row { get; set; }
    }
}