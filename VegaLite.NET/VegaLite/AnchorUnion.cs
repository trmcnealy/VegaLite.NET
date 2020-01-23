namespace VegaLite
{
    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
    public struct AnchorUnion
    {
        public TitleAnchorEnum? Enum;
        public PurpleSignalRef  PurpleSignalRef;

        public static implicit operator AnchorUnion(TitleAnchorEnum Enum)            => new AnchorUnion { Enum            = Enum };
        public static implicit operator AnchorUnion(PurpleSignalRef PurpleSignalRef) => new AnchorUnion { PurpleSignalRef = PurpleSignalRef };
        public                          bool IsNull                                  => PurpleSignalRef == null && Enum == null;
    }
}