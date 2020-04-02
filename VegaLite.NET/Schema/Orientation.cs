namespace VegaLite.Schema
{
    /// <summary>
    /// The orientation of a non-stacked bar, tick, area, and line charts.
    /// The value is either horizontal (default) or vertical.
    /// - For bar, rule and tick, this determines whether the size of the bar and tick
    /// should be applied to x or y dimension.
    /// - For area, this property determines the orient property of the Vega output.
    /// - For line and trail marks, this property determines the sort order of the points in the
    /// line
    /// if `config.sortLineBy` is not specified.
    /// For stacked charts, this is always determined by the orientation of the stack;
    /// therefore explicitly specified value will be ignored.
    ///
    /// The default direction (`"horizontal"` or `"vertical"`) for gradient legends.
    ///
    /// __Default value:__ `"vertical"`.
    ///
    /// The default direction (`"horizontal"` or `"vertical"`) for symbol legends.
    ///
    /// __Default value:__ `"vertical"`.
    ///
    /// The direction of the legend, one of `"vertical"` or `"horizontal"`.
    ///
    /// __Default value:__
    /// - For top-/bottom-`orient`ed legends, `"horizontal"`
    /// - For left-/right-`orient`ed legends, `"vertical"`
    /// - For top/bottom-left/right-`orient`ed legends, `"horizontal"` for gradient legends and
    /// `"vertical"` for symbol legends.
    ///
    /// Orientation of the box plot. This is normally automatically determined based on types of
    /// fields on x and y channels. However, an explicit `orient` be specified when the
    /// orientation is ambiguous.
    ///
    /// __Default value:__ `"vertical"`.
    ///
    /// Orientation of the error bar. This is normally automatically determined, but can be
    /// specified when the orientation is ambiguous and cannot be automatically determined.
    ///
    /// Orientation of the error band. This is normally automatically determined, but can be
    /// specified when the orientation is ambiguous and cannot be automatically determined.
    /// </summary>
    public enum Orientation
    {
        Horizontal,
        Vertical
    };
}
