namespace VegaLite.Schema
{
    public struct BottomCenter
    {
        public bool?     Bool;
        public SignalRef SignalRef;

        public static implicit operator BottomCenter(bool @bool)
        {
            return new BottomCenter
            {
                Bool = @bool
            };
        }

        public static implicit operator BottomCenter(SignalRef signalRef)
        {
            return new BottomCenter
            {
                SignalRef = signalRef
            };
        }
    }
}
