namespace VegaLite.Schema
{
    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
    public struct Direction
    {
        public Orientation? Enum;
        public SignalRef    SignalRef;

        public static implicit operator Direction(Orientation @enum)
        {
            return new Direction
            {
                Enum = @enum
            };
        }

        public static implicit operator Direction(SignalRef signalRef)
        {
            return new Direction
            {
                SignalRef = signalRef
            };
        }
    }
}
