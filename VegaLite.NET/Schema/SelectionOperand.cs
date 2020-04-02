namespace VegaLite.Schema
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

        public static implicit operator SelectionOperand(Selection selection)
        {
            return new SelectionOperand
            {
                Selection = selection
            };
        }

        public static implicit operator SelectionOperand(string @string)
        {
            return new SelectionOperand
            {
                String = @string
            };
        }
    }
}
