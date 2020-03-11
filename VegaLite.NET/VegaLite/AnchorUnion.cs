namespace VegaLite
{
    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
    public struct AnchorUnion
    {
        public TitleAnchorEnum? Enum;
        public SignalRef  SignalRef;

        public static implicit operator AnchorUnion(TitleAnchorEnum Enum)            => new AnchorUnion { Enum            = Enum };
        public static implicit operator AnchorUnion(SignalRef SignalRef) => new AnchorUnion { SignalRef = SignalRef };
        public                          bool IsNull                                  => SignalRef == null && Enum == null;
    }
}