namespace VegaLite
{
    public struct SpecificationCenter
    {
        public bool?         Bool;
        public RowColBoolean RowColBoolean;

        public static implicit operator SpecificationCenter(bool          Bool)          => new SpecificationCenter { Bool          = Bool };
        public static implicit operator SpecificationCenter(RowColBoolean RowColBoolean) => new SpecificationCenter { RowColBoolean = RowColBoolean };
    }
}