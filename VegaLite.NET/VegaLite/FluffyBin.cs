namespace VegaLite
{
    public struct FluffyBin
    {
        public BinParams BinParams;
        public bool?     Bool;
        public BinEnum?  Enum;

        public static implicit operator FluffyBin(BinParams BinParams) => new FluffyBin { BinParams = BinParams };
        public static implicit operator FluffyBin(bool      Bool)      => new FluffyBin { Bool      = Bool };
        public static implicit operator FluffyBin(BinEnum   Enum)      => new FluffyBin { Enum      = Enum };
        public                          bool IsNull                    => Bool == null && BinParams == null && Enum == null;
    }
}