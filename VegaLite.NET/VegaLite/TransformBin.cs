namespace VegaLite
{
    /// <summary>
    /// An object indicating bin properties, or simply `true` for using default bin parameters.
    /// </summary>
    public struct TransformBin
    {
        public BinParams BinParams;
        public bool?     Bool;

        public static implicit operator TransformBin(BinParams binParams) => new TransformBin { BinParams = binParams };
        public static implicit operator TransformBin(bool      @bool)      => new TransformBin { Bool      = @bool };
    }
}