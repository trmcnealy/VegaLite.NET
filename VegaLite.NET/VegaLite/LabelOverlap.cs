namespace VegaLite
{
    /// <summary>
    /// The strategy to use for resolving overlap of axis labels. If `false` (the default), no
    /// overlap reduction is attempted. If set to `true` or `"parity"`, a strategy of removing
    /// every other label is used (this works well for standard linear axes). If set to
    /// `"greedy"`, a linear scan of the labels is performed, removing any labels that overlaps
    /// with the last visible label (this often works better for log-scaled axes).
    ///
    /// __Default value:__ `true` for non-nominal fields with non-log scales; `"greedy"` for log
    /// scales; otherwise `false`.
    ///
    /// The strategy to use for resolving overlap of labels in gradient legends. If `false`, no
    /// overlap reduction is attempted. If set to `true` or `"parity"`, a strategy of removing
    /// every other label is used. If set to `"greedy"`, a linear scan of the labels is
    /// performed, removing any label that overlaps with the last visible label (this often works
    /// better for log-scaled axes).
    ///
    /// __Default value:__ `"greedy"` for `log scales otherwise `true`.
    ///
    /// The strategy to use for resolving overlap of labels in gradient legends. If `false`, no
    /// overlap reduction is attempted. If set to `true` (default) or `"parity"`, a strategy of
    /// removing every other label is used. If set to `"greedy"`, a linear scan of the labels is
    /// performed, removing any label that overlaps with the last visible label (this often works
    /// better for log-scaled axes).
    ///
    /// __Default value:__ `true`.
    /// </summary>
    public struct LabelOverlap
    {
        public bool?             Bool;
        public LabelOverlapEnum? Enum;

        public static implicit operator LabelOverlap(bool             Bool) => new LabelOverlap { Bool = Bool };
        public static implicit operator LabelOverlap(LabelOverlapEnum Enum) => new LabelOverlap { Enum = Enum };
    }
}