namespace VegaLite
{
    public struct BottomCenter
    {
        public bool?           Bool;
        public SignalRef SignalRef;

        public static implicit operator BottomCenter(bool            @bool)            => new BottomCenter { Bool            = @bool };
        public static implicit operator BottomCenter(SignalRef signalRef) => new BottomCenter { SignalRef = signalRef };
    }
}