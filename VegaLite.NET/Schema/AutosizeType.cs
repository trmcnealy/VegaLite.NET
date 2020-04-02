namespace VegaLite.Schema
{
    /// <summary>
    /// The sizing format type. One of `"pad"`, `"fit"`, `"fit-x"`, `"fit-y"`,  or `"none"`. See
    /// the [autosize type](https://vega.github.io/vega-lite/docs/size.html#autosize)
    /// documentation for descriptions of each.
    ///
    /// __Default value__: `"pad"`
    /// </summary>
    public enum AutosizeType
    {
        Fit,
        FitX,
        FitY,
        None,
        Pad
    };
}
