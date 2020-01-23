using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Reference to a repeated value.
    /// </summary>
    public class RepeatRef
    {
        [JsonProperty("repeat", Required = Required.Always)]
        public RepeatEnum? Repeat { get; set; }
    }
}