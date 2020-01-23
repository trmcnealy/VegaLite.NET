namespace VegaLite
{
    public struct BottomCenter
    {
        public bool?           Bool;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator BottomCenter(bool            Bool)            => new BottomCenter { Bool            = Bool };
        public static implicit operator BottomCenter(PurpleSignalRef PurpleSignalRef) => new BottomCenter { PurpleSignalRef = PurpleSignalRef };
    }
}