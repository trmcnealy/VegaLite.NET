using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class RowColNumber
    {
        [JsonProperty("column",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Column { get; set; }

        [JsonProperty("row",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Row { get; set; }
    }
}
