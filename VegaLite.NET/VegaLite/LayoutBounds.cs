namespace VegaLite
{
    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
    public struct LayoutBounds
    {
        public BoundsEnum?     Enum;
        public SignalRef SignalRef;

        public static implicit operator LayoutBounds(BoundsEnum      @enum)            => new LayoutBounds { Enum            = @enum };
        public static implicit operator LayoutBounds(SignalRef signalRef) => new LayoutBounds { SignalRef = signalRef };
    }
}