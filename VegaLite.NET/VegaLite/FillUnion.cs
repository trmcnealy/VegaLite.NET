namespace VegaLite
{
    public struct FillUnion
    {
        public FillLinearGradient FillLinearGradient;
        public string             String;

        public static implicit operator FillUnion(FillLinearGradient fillLinearGradient) => new FillUnion { FillLinearGradient = fillLinearGradient };
        public static implicit operator FillUnion(string             @string)             => new FillUnion { String             = @string };
        public                          bool IsNull                                      => FillLinearGradient == null && String == null;
    }
}