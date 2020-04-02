using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class NiceClass
    {
        [JsonProperty("interval",
                      Required = Required.Always)]
        public string Interval { get; set; }

        [JsonProperty("step",
                      Required = Required.Always)]
        public double? Step { get; set; }
    }
}
