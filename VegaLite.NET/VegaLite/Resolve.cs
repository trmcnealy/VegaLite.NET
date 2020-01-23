using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// Scale, axis, and legend resolutions for view composition specifications.
    ///
    /// Defines how scales, axes, and legends from different specs should be combined. Resolve is
    /// a mapping from `scale`, `axis`, and `legend` to a mapping from channels to resolutions.
    /// Scales and guides can be resolved to be `"independent"` or `"shared"`.
    /// </summary>
    public class Resolve
    {
        [JsonProperty("axis", NullValueHandling = NullValueHandling.Ignore)]
        public AxisResolveMap Axis { get; set; }

        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public LegendResolveMap Legend { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleResolveMap Scale { get; set; }
    }
}