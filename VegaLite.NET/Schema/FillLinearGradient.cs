using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class FillLinearGradient
    {
        /// <summary>
        /// The type of gradient. Use `"linear"` for a linear gradient.
        ///
        /// The type of gradient. Use `"radial"` for a radial gradient.
        /// </summary>
        [JsonProperty("gradient",
                      Required = Required.Always)]
        public Gradient Gradient { get; set; }

        [JsonProperty("id",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// An array of gradient stops defining the gradient color sequence.
        /// </summary>
        [JsonProperty("stops",
                      Required = Required.Always)]
        public List<GradientStop> Stops { get; set; }

        /// <summary>
        /// The starting x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x1",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? X1 { get; set; }

        /// <summary>
        /// The ending x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `1`
        ///
        /// The x-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("x2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? X2 { get; set; }

        /// <summary>
        /// The starting y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y1",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Y1 { get; set; }

        /// <summary>
        /// The ending y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
        ///
        /// __Default value:__ `0`
        ///
        /// The y-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle
        /// for the gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("y2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Y2 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the inner circle for the
        /// gradient.
        ///
        /// __Default value:__ `0`
        /// </summary>
        [JsonProperty("r1",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? R1 { get; set; }

        /// <summary>
        /// The radius length, in normalized [0, 1] coordinates, of the outer circle for the
        /// gradient.
        ///
        /// __Default value:__ `0.5`
        /// </summary>
        [JsonProperty("r2",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? R2 { get; set; }
    }
}
