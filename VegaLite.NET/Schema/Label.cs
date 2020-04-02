namespace VegaLite.Schema
{
    /// <summary>
    /// Indicates if labels should be hidden if they exceed the axis range. If `false` (the
    /// default) no bounds overlap analysis is performed. If `true`, labels will be hidden if
    /// they exceed the axis range by more than 1 pixel. If this property is a number, it
    /// specifies the pixel tolerance: the maximum amount by which a label bounding box may
    /// exceed the axis range.
    ///
    /// __Default value:__ `false`.
    ///
    /// Indicates if the first and last axis labels should be aligned flush with the scale range.
    /// Flush alignment for a horizontal axis will left-align the first label and right-align the
    /// last label. For vertical axes, bottom and top text baselines are applied instead. If this
    /// property is a number, it also indicates the number of pixels by which to offset the first
    /// and last labels; for example, a value of 2 will flush-align the first and last labels and
    /// also push them 2 pixels outward from the center of the axis. The additional adjustment
    /// can sometimes help the labels better visually group with corresponding axis ticks.
    ///
    /// __Default value:__ `true` for axis of a continuous x-scale. Otherwise, `false`.
    /// </summary>
    public struct Label
    {
        public bool?   Bool;
        public double? Double;

        public static implicit operator Label(bool @bool)
        {
            return new Label
            {
                Bool = @bool
            };
        }

        public static implicit operator Label(double @double)
        {
            return new Label
            {
                Double = @double
            };
        }
    }
}
