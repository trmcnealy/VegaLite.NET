namespace VegaLite
{
    /// <summary>
    /// Mode for stacking marks. One of `"zero"` (default), `"center"`, or `"normalize"`.
    /// The `"zero"` offset will stack starting at `0`. The `"center"` offset will center the
    /// stacks. The `"normalize"` offset will compute percentage values for each stack point,
    /// with output values in the range `[0,1]`.
    ///
    /// __Default value:__ `"zero"`
    /// </summary>
    public enum StackOffset { Center, Normalize, Zero };
}