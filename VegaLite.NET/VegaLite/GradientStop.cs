using Newtonsoft.Json;

namespace VegaLite
{
    public class GradientStop
    {
        /// <summary>
        /// The color value at this point in the gradient.
        /// </summary>
        [JsonProperty("color", Required = Required.Always)]
        public string Color { get; set; }

        /// <summary>
        /// The offset fraction for the color stop, indicating its position within the gradient.
        /// </summary>
        [JsonProperty("offset", Required = Required.Always)]
        public double? Offset { get; set; }
    }
}