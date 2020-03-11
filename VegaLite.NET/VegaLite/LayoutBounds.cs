namespace VegaLite
{
    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
    public struct LayoutBounds
    {
        public BoundsEnum?     Enum;
        public SignalRef SignalRef;

        public static implicit operator LayoutBounds(BoundsEnum      Enum)            => new LayoutBounds { Enum            = Enum };
        public static implicit operator LayoutBounds(SignalRef SignalRef) => new LayoutBounds { SignalRef = SignalRef };
    }
}