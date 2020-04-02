namespace VegaLite.Schema
{
    public struct FillUnion
    {
        public FillLinearGradient FillLinearGradient;
        public string             String;

        public static implicit operator FillUnion(FillLinearGradient fillLinearGradient)
        {
            return new FillUnion
            {
                FillLinearGradient = fillLinearGradient
            };
        }

        public static implicit operator FillUnion(string @string)
        {
            return new FillUnion
            {
                String = @string
            };
        }

        public bool IsNull { get { return FillLinearGradient == null && String == null; } }
    }
}
