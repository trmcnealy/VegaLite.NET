using Newtonsoft.Json;

namespace VegaLite
{
    public class SignalRef
    {
        [JsonProperty("signal", Required = Required.Always)]
        public string Signal { get; set; }
    }
}