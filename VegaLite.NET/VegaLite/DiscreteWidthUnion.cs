namespace VegaLite
{
    /// <summary>
    /// The default width when the plot has either a discrete x-field or no x-field.
    ///
    /// __Default value:__ a step size based on `config.view.step`.
    /// </summary>
    public struct DiscreteWidthUnion
    {
        public DiscreteWidthClass DiscreteWidthClass;
        public double?            Double;

        public static implicit operator DiscreteWidthUnion(DiscreteWidthClass discreteWidthClass) => new DiscreteWidthUnion { DiscreteWidthClass = discreteWidthClass };
        public static implicit operator DiscreteWidthUnion(double             @double)             => new DiscreteWidthUnion { Double             = @double };
    }
}