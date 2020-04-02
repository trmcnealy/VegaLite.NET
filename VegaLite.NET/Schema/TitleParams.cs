using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class TitleParams
    {
        /// <summary>
        /// Horizontal text alignment for title text. One of `"left"`, `"center"`, or `"right"`.
        /// </summary>
        [JsonProperty("align",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Align? Align { get; set; }

        /// <summary>
        /// The anchor position for placing the title. One of `"start"`, `"middle"`, or `"end"`. For
        /// example, with an orientation of top these anchor positions map to a left-, center-, or
        /// right-aligned title.
        ///
        /// __Default value:__ `"middle"` for
        /// [single](https://vega.github.io/vega-lite/docs/spec.html) and
        /// [layered](https://vega.github.io/vega-lite/docs/layer.html) views.
        /// `"start"` for other composite views.
        ///
        /// __Note:__ [For now](https://github.com/vega/vega-lite/issues/2875), `anchor` is only
        /// customizable only for [single](https://vega.github.io/vega-lite/docs/spec.html) and
        /// [layered](https://vega.github.io/vega-lite/docs/layer.html) views. For other composite
        /// views, `anchor` is always `"start"`.
        /// </summary>
        [JsonProperty("anchor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorEnum? Anchor { get; set; }

        /// <summary>
        /// Angle in degrees of title and subtitle text.
        /// </summary>
        [JsonProperty("angle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Angle { get; set; }

        /// <summary>
        /// Vertical text baseline for title and subtitle text. One of `"top"`, `"middle"`,
        /// `"bottom"`, or `"alphabetic"`.
        /// </summary>
        [JsonProperty("baseline",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Baseline? Baseline { get; set; }

        /// <summary>
        /// Text color for title text.
        /// </summary>
        [JsonProperty("color",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// Delta offset for title and subtitle text x-coordinate.
        /// </summary>
        [JsonProperty("dx",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Dx { get; set; }

        /// <summary>
        /// Delta offset for title and subtitle text y-coordinate.
        /// </summary>
        [JsonProperty("dy",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Dy { get; set; }

        /// <summary>
        /// Font name for title text.
        /// </summary>
        [JsonProperty("font",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// Font size in pixels for title text.
        /// </summary>
        [JsonProperty("fontSize",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Font style for title text.
        /// </summary>
        [JsonProperty("fontStyle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        /// <summary>
        /// Font weight for title text.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("fontWeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// The reference frame for the anchor position, one of `"bounds"` (to anchor relative to the
        /// full bounding box) or `"group"` (to anchor relative to the group width or height).
        /// </summary>
        [JsonProperty("frame",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Frame { get; set; }

        /// <summary>
        /// The maximum allowed length in pixels of title and subtitle text.
        /// </summary>
        [JsonProperty("limit",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line title text.
        /// </summary>
        [JsonProperty("lineHeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The orthogonal offset in pixels by which to displace the title group from its position
        /// along the edge of the chart.
        /// </summary>
        [JsonProperty("offset",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        /// <summary>
        /// Default title orientation (`"top"`, `"bottom"`, `"left"`, or `"right"`)
        /// </summary>
        [JsonProperty("orient",
                      NullValueHandling = NullValueHandling.Ignore)]
        public TitleOrient? Orient { get; set; }

        /// <summary>
        /// A [mark style property](https://vega.github.io/vega-lite/docs/config.html#style) to apply
        /// to the title text mark.
        ///
        /// __Default value:__ `"group-title"`.
        /// </summary>
        [JsonProperty("style",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Text? Style { get; set; }

        /// <summary>
        /// The subtitle Text.
        /// </summary>
        [JsonProperty("subtitle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public Text? Subtitle { get; set; }

        /// <summary>
        /// Text color for subtitle text.
        /// </summary>
        [JsonProperty("subtitleColor",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleColor { get; set; }

        /// <summary>
        /// Font name for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFont",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFont { get; set; }

        /// <summary>
        /// Font size in pixels for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFontSize",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitleFontSize { get; set; }

        /// <summary>
        /// Font style for subtitle text.
        /// </summary>
        [JsonProperty("subtitleFontStyle",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFontStyle { get; set; }

        /// <summary>
        /// Font weight for subtitle text.
        /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
        /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
        /// </summary>
        [JsonProperty("subtitleFontWeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? SubtitleFontWeight { get; set; }

        /// <summary>
        /// Line height in pixels for multi-line subtitle text.
        /// </summary>
        [JsonProperty("subtitleLineHeight",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitleLineHeight { get; set; }

        /// <summary>
        /// The padding in pixels between title and subtitle text.
        /// </summary>
        [JsonProperty("subtitlePadding",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? SubtitlePadding { get; set; }

        /// <summary>
        /// The title text.
        /// </summary>
        [JsonProperty("text",
                      Required = Required.Always)]
        public Text Text { get; set; }

        /// <summary>
        /// The integer z-index indicating the layering of the title group relative to other axis,
        /// mark and legend groups.
        ///
        /// __Default value:__ `0`.
        /// </summary>
        [JsonProperty("zindex",
                      NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }
}
