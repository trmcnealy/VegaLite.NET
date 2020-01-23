namespace VegaLite
{
    /// <summary>
    /// The alignment to apply to grid rows and columns.
    /// The supported string values are `"all"`, `"each"`, and `"none"`.
    ///
    /// - For `"none"`, a flow layout will be used, in which adjacent subviews are simply placed
    /// one after the other.
    /// - For `"each"`, subviews will be aligned into a clean grid structure, but each row or
    /// column may be of variable size.
    /// - For `"all"`, subviews will be aligned and each row or column will be sized identically
    /// based on the maximum observed size. String values for this property will be applied to
    /// both grid rows and columns.
    ///
    /// Alternatively, an object value of the form `{"row": string, "column": string}` can be
    /// used to supply different alignments for rows and columns.
    ///
    /// __Default value:__ `"all"`.
    /// </summary>
    public struct AlignUnion
    {
        public LayoutAlign?      Enum;
        public RowColLayoutAlign RowColLayoutAlign;

        public static implicit operator AlignUnion(LayoutAlign       Enum)              => new AlignUnion { Enum              = Enum };
        public static implicit operator AlignUnion(RowColLayoutAlign RowColLayoutAlign) => new AlignUnion { RowColLayoutAlign = RowColLayoutAlign };
    }
}