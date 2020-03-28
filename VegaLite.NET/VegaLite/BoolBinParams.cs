namespace VegaLite
{
    public struct BoolBinParams
    {
        public BinParams BinParams;
        public bool?     Bool;

        public static implicit operator BoolBinParams(BinParams binParams) => new BoolBinParams { BinParams = binParams };
        public static implicit operator BoolBinParams(bool      @bool)      => new BoolBinParams { Bool      = @bool };
        public                          bool IsNull                        => Bool == null && BinParams == null;
    }
}