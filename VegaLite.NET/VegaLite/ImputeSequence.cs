using Newtonsoft.Json;

namespace VegaLite
{
    public class ImputeSequence
    {
        /// <summary>
        /// The starting value of the sequence.
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public double? Start { get; set; }

        /// <summary>
        /// The step value between sequence entries.
        /// __Default value:__ `1` or `-1` if `stop  start`
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// The ending value(exclusive) of the sequence.
        /// </summary>
        [JsonProperty("stop", Required = Required.Always)]
        public double Stop { get; set; }
    }
}