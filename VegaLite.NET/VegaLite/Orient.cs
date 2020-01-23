namespace VegaLite
{
    /// <summary>
    /// The orientation of the header label. One of `"top"`, `"bottom"`, `"left"` or `"right"`.
    ///
    /// The orientation of the header title. One of `"top"`, `"bottom"`, `"left"` or `"right"`.
    ///
    /// Orientation of the legend title.
    ///
    /// The orientation of the axis. One of `"top"`, `"bottom"`, `"left"` or `"right"`. The
    /// orientation can be used to further specialize the axis type (e.g., a y-axis oriented
    /// towards the right edge of the chart).
    ///
    /// __Default value:__ `"bottom"` for x-axes and `"left"` for y-axes.
    /// </summary>
    public enum Orient { Bottom, Left, Right, Top };
}