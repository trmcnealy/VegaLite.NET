namespace VegaLite
{
    public struct Box
    {
        public bool?      Bool;
        public MarkConfig MarkConfig;

        public static implicit operator Box(bool       @bool)       => new Box { Bool       = @bool };
        public static implicit operator Box(MarkConfig markConfig) => new Box { MarkConfig = markConfig };
    }
}