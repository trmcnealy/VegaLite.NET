using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Generate a sequence of numbers.
    /// </summary>
    public class SequenceParams
    {
        /// <summary>
        /// The name of the generated sequence field.
        ///
        /// __Default value:__ `"data"`
        /// </summary>
        [JsonProperty("as",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        /// <summary>
        /// The starting value of the sequence (inclusive).
        /// </summary>
        [JsonProperty("start",
                      Required = Required.Always)]
        public double? Start { get; set; }

        /// <summary>
        /// The step value between sequence entries.
        ///
        /// __Default value:__ `1`
        /// </summary>
        [JsonProperty("step",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// The ending value of the sequence (exclusive).
        /// </summary>
        [JsonProperty("stop",
                      Required = Required.Always)]
        public double? Stop { get; set; }
    }
}
