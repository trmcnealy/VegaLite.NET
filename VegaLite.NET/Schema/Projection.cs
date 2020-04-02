using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    /// <summary>
    /// Projection configuration, which determines default properties for all
    /// [projections](https://vega.github.io/vega-lite/docs/projection.html). For a full list of
    /// projection configuration options, please see the [corresponding section of the projection
    /// documentation](https://vega.github.io/vega-lite/docs/projection.html#config).
    ///
    /// Any property of Projection can be in config
    ///
    /// An object defining properties of geographic projection, which will be applied to `shape`
    /// path for `"geoshape"` marks
    /// and to `latitude` and `"longitude"` channels for other marks.
    ///
    /// An object defining properties of the geographic projection shared by underlying layers.
    /// </summary>
    public class Projection
    {
        /// <summary>
        /// The projection’s center to the specified center, a two-element array of longitude and
        /// latitude in degrees.
        ///
        /// __Default value:__ `[0, 0]`
        /// </summary>
        [JsonProperty("center",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Center { get; set; }

        /// <summary>
        /// The projection’s clipping circle radius to the specified angle in degrees. If `null`,
        /// switches to [antimeridian](http://bl.ocks.org/mbostock/3788999) cutting rather than
        /// small-circle clipping.
        /// </summary>
        [JsonProperty("clipAngle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? ClipAngle { get; set; }

        /// <summary>
        /// The projection’s viewport clip extent to the specified bounds in pixels. The extent
        /// bounds are specified as an array `[[x0, y0], [x1, y1]]`, where `x0` is the left-side of
        /// the viewport, `y0` is the top, `x1` is the right and `y1` is the bottom. If `null`, no
        /// viewport clipping is performed.
        /// </summary>
        [JsonProperty("clipExtent",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> ClipExtent { get; set; }

        [JsonProperty("coefficient",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Coefficient { get; set; }

        [JsonProperty("distance",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        [JsonProperty("fraction",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Fraction { get; set; }

        [JsonProperty("lobes",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Lobes { get; set; }

        [JsonProperty("parallel",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Parallel { get; set; }

        [JsonProperty("parallels",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Parallels { get; set; }

        /// <summary>
        /// The threshold for the projection’s [adaptive
        /// resampling](http://bl.ocks.org/mbostock/3795544) to the specified value in pixels. This
        /// value corresponds to the [Douglas–Peucker
        /// distance](http://en.wikipedia.org/wiki/Ramer%E2%80%93Douglas%E2%80%93Peucker_algorithm).
        /// If precision is not specified, returns the projection’s current resampling precision
        /// which defaults to `√0.5 ≅ 0.70710…`.
        /// </summary>
        [JsonProperty("precision",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Precision { get; set; }

        [JsonProperty("radius",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Radius { get; set; }

        [JsonProperty("ratio",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Ratio { get; set; }

        [JsonProperty("reflectX",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReflectX { get; set; }

        [JsonProperty("reflectY",
                      NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReflectY { get; set; }

        /// <summary>
        /// The projection’s three-axis rotation to the specified angles, which must be a two- or
        /// three-element array of numbers [`lambda`, `phi`, `gamma`] specifying the rotation angles
        /// in degrees about each spherical axis. (These correspond to yaw, pitch and roll.)
        ///
        /// __Default value:__ `[0, 0, 0]`
        /// </summary>
        [JsonProperty("rotate",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Rotate { get; set; }

        /// <summary>
        /// The projection's scale (zoom) value, overriding automatic fitting.
        /// </summary>
        [JsonProperty("scale",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Scale { get; set; }

        [JsonProperty("spacing",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Spacing { get; set; }

        [JsonProperty("tilt",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Tilt { get; set; }

        /// <summary>
        /// The projection's translation (pan) value, overriding automatic fitting.
        /// </summary>
        [JsonProperty("translate",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Translate { get; set; }

        /// <summary>
        /// The cartographic projection to use. This value is case-insensitive, for example
        /// `"albers"` and `"Albers"` indicate the same projection type. You can find all valid
        /// projection types [in the
        /// documentation](https://vega.github.io/vega-lite/docs/projection.html#projection-types).
        ///
        /// __Default value:__ `mercator`
        /// </summary>
        [JsonProperty("type",
                      NullValueHandling = NullValueHandling.Ignore)]
        public ProjectionType? Type { get; set; }
    }
}
