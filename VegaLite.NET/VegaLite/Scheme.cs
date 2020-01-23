namespace VegaLite
{
    /// <summary>
    /// A string indicating a color
    /// [scheme](https://vega.github.io/vega-lite/docs/scale.html#scheme) name (e.g.,
    /// `"category10"` or `"blues"`) or a [scheme parameter
    /// object](https://vega.github.io/vega-lite/docs/scale.html#scheme-params).
    ///
    /// Discrete color schemes may be used with
    /// [discrete](https://vega.github.io/vega-lite/docs/scale.html#discrete) or
    /// [discretizing](https://vega.github.io/vega-lite/docs/scale.html#discretizing) scales.
    /// Continuous color schemes are intended for use with color scales.
    ///
    /// For the full list of supported schemes, please refer to the [Vega
    /// Scheme](https://vega.github.io/vega/docs/schemes/#reference) reference.
    /// </summary>
    public struct Scheme
    {
        public SchemeParams SchemeParams;
        public string       String;

        public static implicit operator Scheme(SchemeParams SchemeParams) => new Scheme { SchemeParams = SchemeParams };
        public static implicit operator Scheme(string       String)       => new Scheme { String       = String };
    }
}