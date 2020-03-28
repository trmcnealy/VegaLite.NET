namespace VegaLite
{
    public struct ClearUnion
    {
        public bool?              Bool;
        public ClearDerivedStream ClearDerivedStream;
        public string             String;

        public static implicit operator ClearUnion(bool               @bool)               => new ClearUnion { Bool               = @bool };
        public static implicit operator ClearUnion(ClearDerivedStream clearDerivedStream) => new ClearUnion { ClearDerivedStream = clearDerivedStream };
        public static implicit operator ClearUnion(string             @string)             => new ClearUnion { String             = @string };
    }
}