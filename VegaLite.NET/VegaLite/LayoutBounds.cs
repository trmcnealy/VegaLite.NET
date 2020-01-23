namespace VegaLite
{
    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
    public struct LayoutBounds
    {
        public BoundsEnum?     Enum;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator LayoutBounds(BoundsEnum      Enum)            => new LayoutBounds { Enum            = Enum };
        public static implicit operator LayoutBounds(PurpleSignalRef PurpleSignalRef) => new LayoutBounds { PurpleSignalRef = PurpleSignalRef };
    }
}