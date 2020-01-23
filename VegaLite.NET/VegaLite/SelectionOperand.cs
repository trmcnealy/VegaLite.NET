namespace VegaLite
{
    /// <summary>
    /// Filter using a selection name.
    ///
    /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
    /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
    /// </summary>
    public struct SelectionOperand
    {
        public Selection Selection;
        public string    String;

        public static implicit operator SelectionOperand(Selection Selection) => new SelectionOperand { Selection = Selection };
        public static implicit operator SelectionOperand(string    String)    => new SelectionOperand { String    = String };
    }
}