namespace VegaLite
{
    public struct Box
    {
        public bool?      Bool;
        public MarkConfig MarkConfig;

        public static implicit operator Box(bool       Bool)       => new Box { Bool       = Bool };
        public static implicit operator Box(MarkConfig MarkConfig) => new Box { MarkConfig = MarkConfig };
    }
}