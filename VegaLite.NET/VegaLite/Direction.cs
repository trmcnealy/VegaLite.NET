namespace VegaLite
{
    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
    public struct Direction
    {
        public Orientation?    Enum;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator Direction(Orientation     Enum)            => new Direction { Enum            = Enum };
        public static implicit operator Direction(PurpleSignalRef PurpleSignalRef) => new Direction { PurpleSignalRef = PurpleSignalRef };
    }
}