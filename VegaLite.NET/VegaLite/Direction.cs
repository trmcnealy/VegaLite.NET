namespace VegaLite
{
    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
    public struct Direction
    {
        public Orientation?    Enum;
        public SignalRef SignalRef;

        public static implicit operator Direction(Orientation     @enum)            => new Direction { Enum            = @enum };
        public static implicit operator Direction(SignalRef signalRef) => new Direction { SignalRef = signalRef };
    }
}