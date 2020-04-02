using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// ErrorBand Config
    /// </summary>
    public class ErrorBandConfig
    {
        [JsonProperty("band",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Band { get; set; }

        [JsonProperty("borders",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Box? Borders { get; set; }

        /// <summary>
        /// The extent of the band. Available options include:
        /// - `"ci"`: Extend the band to the confidence interval of the mean.
        /// - `"stderr"`: The size of band are set to the value of standard error, extending from the
        /// mean.
        /// - `"stdev"`: The size of band are set to the value of standard deviation, extending from
        /// the mean.
        /// - `"iqr"`: Extend the band to the q1 and q3.
        ///
        /// __Default value:__ `"stderr"`.
        /// </summary>
        [JsonProperty("extent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ErrorbandExtent? Extent { get; set; }

        /// <summary>
        /// The line interpolation method for the error band. One of the following:
        /// - `"linear"`: piecewise linear segments, as in a polyline.
        /// - `"linear-closed"`: close the linear segments to form a polygon.
        /// - `"step"`: a piecewise constant function (a step function) consisting of alternating
        /// horizontal and vertical lines. The y-value changes at the midpoint of each pair of
        /// adjacent x-values.
        /// - `"step-before"`: a piecewise constant function (a step function) consisting of
        /// alternating horizontal and vertical lines. The y-value changes before the x-value.
        /// - `"step-after"`: a piecewise constant function (a step function) consisting of
        /// alternating horizontal and vertical lines. The y-value changes after the x-value.
        /// - `"basis"`: a B-spline, with control point duplication on the ends.
        /// - `"basis-open"`: an open B-spline; may not intersect the start or end.
        /// - `"basis-closed"`: a closed B-spline, as in a loop.
        /// - `"cardinal"`: a Cardinal spline, with control point duplication on the ends.
        /// - `"cardinal-open"`: an open Cardinal spline; may not intersect the start or end, but
        /// will intersect other control points.
        /// - `"cardinal-closed"`: a closed Cardinal spline, as in a loop.
        /// - `"bundle"`: equivalent to basis, except the tension parameter is used to straighten the
        /// spline.
        /// - `"monotone"`: cubic interpolation that preserves monotonicity in y.
        /// </summary>
        [JsonProperty("interpolate",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        /// <summary>
        /// The tension parameter for the interpolation type of the error band.
        /// </summary>
        [JsonProperty("tension",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Tension { get; set; }
    }
}
