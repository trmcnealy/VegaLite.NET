namespace VegaLite.Schema
{
    public struct BoolBinParams
    {
        public BinParams BinParams;
        public bool?     Bool;

        public static implicit operator BoolBinParams(BinParams binParams)
        {
            return new BoolBinParams
            {
                BinParams = binParams
            };
        }

        public static implicit operator BoolBinParams(bool @bool)
        {
            return new BoolBinParams
            {
                Bool = @bool
            };
        }

        public bool IsNull { get { return Bool == null && BinParams == null; } }
    }
}
