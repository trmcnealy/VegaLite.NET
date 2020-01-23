namespace VegaLite
{
    public struct OnUnion
    {
        public OnDerivedStream OnDerivedStream;
        public string          String;

        public static implicit operator OnUnion(OnDerivedStream OnDerivedStream) => new OnUnion { OnDerivedStream = OnDerivedStream };
        public static implicit operator OnUnion(string          String)          => new OnUnion { String          = String };
    }
}