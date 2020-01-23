namespace VegaLite
{
    public struct BoolBinParams
    {
        public BinParams BinParams;
        public bool?     Bool;

        public static implicit operator BoolBinParams(BinParams BinParams) => new BoolBinParams { BinParams = BinParams };
        public static implicit operator BoolBinParams(bool      Bool)      => new BoolBinParams { Bool      = Bool };
        public                          bool IsNull                        => Bool == null && BinParams == null;
    }
}