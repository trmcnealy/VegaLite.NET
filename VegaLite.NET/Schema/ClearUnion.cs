namespace VegaLite.Schema
{
    public struct ClearUnion
    {
        public bool?              Bool;
        public ClearDerivedStream ClearDerivedStream;
        public string             String;

        public static implicit operator ClearUnion(bool @bool)
        {
            return new ClearUnion
            {
                Bool = @bool
            };
        }

        public static implicit operator ClearUnion(ClearDerivedStream clearDerivedStream)
        {
            return new ClearUnion
            {
                ClearDerivedStream = clearDerivedStream
            };
        }

        public static implicit operator ClearUnion(string @string)
        {
            return new ClearUnion
            {
                String = @string
            };
        }
    }
}
