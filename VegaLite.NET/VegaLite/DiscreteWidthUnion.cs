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

        public static implicit operator DiscreteWidthUnion(DiscreteWidthClass DiscreteWidthClass) => new DiscreteWidthUnion { DiscreteWidthClass = DiscreteWidthClass };
        public static implicit operator DiscreteWidthUnion(double             Double)             => new DiscreteWidthUnion { Double             = Double };
    }
}