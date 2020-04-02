namespace VegaLite.Schema
{
    /// <summary>
    /// How the visualization size should be determined. If a string, should be one of `"pad"`,
    /// `"fit"` or `"none"`.
    /// Object values can additionally specify parameters for content sizing and automatic
    /// resizing.
    ///
    /// __Default value__: `pad`
    /// </summary>
    public struct Autosize
    {
        public AutoSizeParams AutoSizeParams;
        public AutosizeType?  Enum;

        public static implicit operator Autosize(AutoSizeParams autoSizeParams)
        {
            return new Autosize
            {
                AutoSizeParams = autoSizeParams
            };
        }

        public static implicit operator Autosize(AutosizeType @enum)
        {
            return new Autosize
            {
                Enum = @enum
            };
        }
    }
}
