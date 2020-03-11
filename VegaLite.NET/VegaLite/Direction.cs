namespace VegaLite
{
    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
    public struct Direction
    {
        public Orientation?    Enum;
        public SignalRef SignalRef;

        public static implicit operator Direction(Orientation     Enum)            => new Direction { Enum            = Enum };
        public static implicit operator Direction(SignalRef SignalRef) => new Direction { SignalRef = SignalRef };
    }
}