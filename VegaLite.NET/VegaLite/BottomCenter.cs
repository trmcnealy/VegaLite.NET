namespace VegaLite
{
    public struct BottomCenter
    {
        public bool?           Bool;
        public SignalRef SignalRef;

        public static implicit operator BottomCenter(bool            Bool)            => new BottomCenter { Bool            = Bool };
        public static implicit operator BottomCenter(SignalRef SignalRef) => new BottomCenter { SignalRef = SignalRef };
    }
}