namespace VegaLite
{
    public struct SpecificationCenter
    {
        public bool?         Bool;
        public RowColBoolean RowColBoolean;

        public static implicit operator SpecificationCenter(bool          @bool)          => new SpecificationCenter { Bool          = @bool };
        public static implicit operator SpecificationCenter(RowColBoolean rowColBoolean) => new SpecificationCenter { RowColBoolean = rowColBoolean };
    }
}