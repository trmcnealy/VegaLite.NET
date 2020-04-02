namespace VegaLite.Schema
{
    public struct OnUnion
    {
        public OnDerivedStream OnDerivedStream;
        public string          String;

        public static implicit operator OnUnion(OnDerivedStream onDerivedStream)
        {
            return new OnUnion
            {
                OnDerivedStream = onDerivedStream
            };
        }

        public static implicit operator OnUnion(string @string)
        {
            return new OnUnion
            {
                String = @string
            };
        }
    }
}
