namespace VegaLite
{
    public struct FillUnion
    {
        public FillLinearGradient FillLinearGradient;
        public string             String;

        public static implicit operator FillUnion(FillLinearGradient FillLinearGradient) => new FillUnion { FillLinearGradient = FillLinearGradient };
        public static implicit operator FillUnion(string             String)             => new FillUnion { String             = String };
        public                          bool IsNull                                      => FillLinearGradient == null && String == null;
    }
}