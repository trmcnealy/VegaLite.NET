namespace VegaLite
{
    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
    public struct AnchorUnion
    {
        public TitleAnchorEnum? Enum;
        public SignalRef  SignalRef;

        public static implicit operator AnchorUnion(TitleAnchorEnum @enum)            => new AnchorUnion { Enum            = @enum };
        public static implicit operator AnchorUnion(SignalRef signalRef) => new AnchorUnion { SignalRef = signalRef };
        public                          bool IsNull                                  => SignalRef == null && Enum == null;
    }
}