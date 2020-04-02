namespace VegaLite.Schema
{
    public struct Box
    {
        public bool?      Bool;
        public MarkConfig MarkConfig;

        public static implicit operator Box(bool @bool)
        {
            return new Box
            {
                Bool = @bool
            };
        }

        public static implicit operator Box(MarkConfig markConfig)
        {
            return new Box
            {
                MarkConfig = markConfig
            };
        }
    }
}
