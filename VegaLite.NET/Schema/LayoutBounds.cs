namespace VegaLite.Schema
{
    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
    public struct LayoutBounds
    {
        public BoundsEnum? Enum;
        public SignalRef   SignalRef;

        public static implicit operator LayoutBounds(BoundsEnum @enum)
        {
            return new LayoutBounds
            {
                Enum = @enum
            };
        }

        public static implicit operator LayoutBounds(SignalRef signalRef)
        {
            return new LayoutBounds
            {
                SignalRef = signalRef
            };
        }
    }
}
