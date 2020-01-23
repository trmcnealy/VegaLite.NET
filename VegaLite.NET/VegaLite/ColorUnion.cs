namespace VegaLite
{
    /// <summary>
    /// Default color.
    ///
    /// __Default value:__ <span style="color: #4682b4;">&#9632;</span> `"#4682b4"`
    ///
    /// __Note:__
    /// - This property cannot be used in a [style
    /// config](https://vega.github.io/vega-lite/docs/mark.html#style-config).
    /// - The `fill` and `stroke` properties have higher precedence than `color` and will
    /// override `color`.
    /// </summary>
    public struct ColorUnion
    {
        public ColorLinearGradient ColorLinearGradient;
        public string              String;

        public static implicit operator ColorUnion(ColorLinearGradient ColorLinearGradient) => new ColorUnion { ColorLinearGradient = ColorLinearGradient };
        public static implicit operator ColorUnion(string              String)              => new ColorUnion { String              = String };
    }
}