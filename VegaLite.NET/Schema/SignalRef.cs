using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class SignalRef
    {
        [JsonProperty("signal",
                      Required = Required.Always)]
        public string Signal { get; set; }
    }
}
