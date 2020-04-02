namespace VegaLite.Schema
{
    /// <summary>
    /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
    /// `"top"`, `"middle"`, `"bottom"`.
    ///
    /// __Default value:__ `"middle"`
    ///
    /// Vertical text baseline of axis tick labels, overriding the default setting for the
    /// current axis orientation. Can be `"top"`, `"middle"`, `"bottom"`, or `"alphabetic"`.
    ///
    /// Vertical text baseline for axis titles.
    ///
    /// Vertical text baseline for the header title. One of `"top"`, `"bottom"`, `"middle"`.
    ///
    /// __Default value:__ `"middle"`
    ///
    /// The position of the baseline of legend label, can be `"top"`, `"middle"`, `"bottom"`, or
    /// `"alphabetic"`.
    ///
    /// __Default value:__ `"middle"`.
    ///
    /// Vertical text baseline for legend titles.
    ///
    /// __Default value:__ `"top"`.
    ///
    /// Vertical text baseline for title and subtitle text. One of `"top"`, `"middle"`,
    /// `"bottom"`, or `"alphabetic"`.
    /// </summary>
    public enum Baseline
    {
        Alphabetic,
        Bottom,
        Middle,
        Top
    };
}
