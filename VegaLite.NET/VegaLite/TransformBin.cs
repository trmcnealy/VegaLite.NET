namespace VegaLite
{
    /// <summary>
    /// An object indicating bin properties, or simply `true` for using default bin parameters.
    /// </summary>
    public struct TransformBin
    {
        public BinParams BinParams;
        public bool?     Bool;

        public static implicit operator TransformBin(BinParams BinParams) => new TransformBin { BinParams = BinParams };
        public static implicit operator TransformBin(bool      Bool)      => new TransformBin { Bool      = Bool };
    }
}