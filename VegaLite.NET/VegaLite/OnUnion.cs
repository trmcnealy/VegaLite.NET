namespace VegaLite
{
    public struct OnUnion
    {
        public OnDerivedStream OnDerivedStream;
        public string          String;

        public static implicit operator OnUnion(OnDerivedStream onDerivedStream) => new OnUnion { OnDerivedStream = onDerivedStream };
        public static implicit operator OnUnion(string          @string)          => new OnUnion { String          = @string };
    }
}