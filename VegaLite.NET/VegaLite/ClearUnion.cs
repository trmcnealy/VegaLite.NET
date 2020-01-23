namespace VegaLite
{
    public struct ClearUnion
    {
        public bool?              Bool;
        public ClearDerivedStream ClearDerivedStream;
        public string             String;

        public static implicit operator ClearUnion(bool               Bool)               => new ClearUnion { Bool               = Bool };
        public static implicit operator ClearUnion(ClearDerivedStream ClearDerivedStream) => new ClearUnion { ClearDerivedStream = ClearDerivedStream };
        public static implicit operator ClearUnion(string             String)             => new ClearUnion { String             = String };
    }
}