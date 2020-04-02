namespace VegaLite.Schema
{
    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
    public struct AnchorUnion
    {
        public TitleAnchorEnum? Enum;
        public SignalRef        SignalRef;

        public static implicit operator AnchorUnion(TitleAnchorEnum @enum)
        {
            return new AnchorUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator AnchorUnion(SignalRef signalRef)
        {
            return new AnchorUnion
            {
                SignalRef = signalRef
            };
        }

        public bool IsNull { get { return SignalRef == null && Enum == null; } }
    }
}
