namespace VegaLite
{
    /// <summary>
    /// The extent of the whiskers. Available options include:
    /// - `"min-max"`: min and max are the lower and upper whiskers respectively.
    /// - A number representing multiple of the interquartile range. This number will be
    /// multiplied by the IQR to determine whisker boundary, which spans from the smallest data
    /// to the largest data within the range _[Q1 - k * IQR, Q3 + k * IQR]_ where _Q1_ and _Q3_
    /// are the first and third quartiles while _IQR_ is the interquartile range (_Q3-Q1_).
    ///
    /// __Default value:__ `1.5`.
    /// </summary>
    public struct BoxplotExtent
    {
        public double?     Double;
        public ExtentEnum? Enum;

        public static implicit operator BoxplotExtent(double     Double) => new BoxplotExtent { Double = Double };
        public static implicit operator BoxplotExtent(ExtentEnum Enum)   => new BoxplotExtent { Enum   = Enum };
    }
}