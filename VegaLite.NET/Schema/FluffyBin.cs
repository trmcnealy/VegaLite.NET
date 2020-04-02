namespace VegaLite.Schema
{
    public struct FluffyBin
    {
        public BinParams BinParams;
        public bool?     Bool;
        public BinEnum?  Enum;

        public static implicit operator FluffyBin(BinParams binParams)
        {
            return new FluffyBin
            {
                BinParams = binParams
            };
        }

        public static implicit operator FluffyBin(bool @bool)
        {
            return new FluffyBin
            {
                Bool = @bool
            };
        }

        public static implicit operator FluffyBin(BinEnum @enum)
        {
            return new FluffyBin
            {
                Enum = @enum
            };
        }

        public bool IsNull { get { return Bool == null && BinParams == null && Enum == null; } }
    }
}
