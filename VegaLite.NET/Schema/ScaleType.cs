namespace VegaLite.Schema
{
    /// <summary>
    /// The type of scale. Vega-Lite supports the following categories of scale types:
    ///
    /// 1) [**Continuous Scales**](https://vega.github.io/vega-lite/docs/scale.html#continuous)
    /// -- mapping continuous domains to continuous output ranges
    /// ([`"linear"`](https://vega.github.io/vega-lite/docs/scale.html#linear),
    /// [`"pow"`](https://vega.github.io/vega-lite/docs/scale.html#pow),
    /// [`"sqrt"`](https://vega.github.io/vega-lite/docs/scale.html#sqrt),
    /// [`"symlog"`](https://vega.github.io/vega-lite/docs/scale.html#symlog),
    /// [`"log"`](https://vega.github.io/vega-lite/docs/scale.html#log),
    /// [`"time"`](https://vega.github.io/vega-lite/docs/scale.html#time),
    /// [`"utc"`](https://vega.github.io/vega-lite/docs/scale.html#utc).
    ///
    /// 2) [**Discrete Scales**](https://vega.github.io/vega-lite/docs/scale.html#discrete) --
    /// mapping discrete domains to discrete
    /// ([`"ordinal"`](https://vega.github.io/vega-lite/docs/scale.html#ordinal)) or continuous
    /// ([`"band"`](https://vega.github.io/vega-lite/docs/scale.html#band) and
    /// [`"point"`](https://vega.github.io/vega-lite/docs/scale.html#point)) output ranges.
    ///
    /// 3) [**Discretizing
    /// Scales**](https://vega.github.io/vega-lite/docs/scale.html#discretizing) -- mapping
    /// continuous domains to discrete output ranges
    /// [`"bin-ordinal"`](https://vega.github.io/vega-lite/docs/scale.html#bin-ordinal),
    /// [`"quantile"`](https://vega.github.io/vega-lite/docs/scale.html#quantile),
    /// [`"quantize"`](https://vega.github.io/vega-lite/docs/scale.html#quantize) and
    /// [`"threshold"`](https://vega.github.io/vega-lite/docs/scale.html#threshold).
    ///
    /// __Default value:__ please see the [scale type
    /// table](https://vega.github.io/vega-lite/docs/scale.html#type).
    /// </summary>
    public enum ScaleType
    {
        Band,
        BinOrdinal,
        Linear,
        Log,
        Ordinal,
        Point,
        Pow,
        Quantile,
        Quantize,
        Sqrt,
        Symlog,
        Threshold,
        Time,
        Utc
    };
}
