namespace VegaLite
{
    public struct FluffyBin
    {
        public BinParams BinParams;
        public bool?     Bool;
        public BinEnum?  Enum;

        public static implicit operator FluffyBin(BinParams binParams) => new FluffyBin { BinParams = binParams };
        public static implicit operator FluffyBin(bool      @bool)      => new FluffyBin { Bool      = @bool };
        public static implicit operator FluffyBin(BinEnum   @enum)      => new FluffyBin { Enum      = @enum };
        public                          bool IsNull                    => Bool == null && BinParams == null && Enum == null;
    }
}