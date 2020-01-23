using Newtonsoft.Json;

namespace VegaLite
{
    public class PurpleSignalRef
    {
        [JsonProperty("signal", Required = Required.Always)]
        public string Signal { get; set; }
    }
}