namespace VegaLite
{
    /// <summary>
    /// The default height when the plot has either a discrete y-field or no y-field.
    ///
    /// __Default value:__ a step size based on `config.view.step`.
    /// </summary>
    public struct DiscreteHeightUnion
    {
        public DiscreteHeightClass DiscreteHeightClass;
        public double?             Double;

        public static implicit operator DiscreteHeightUnion(DiscreteHeightClass DiscreteHeightClass) => new DiscreteHeightUnion { DiscreteHeightClass = DiscreteHeightClass };
        public static implicit operator DiscreteHeightUnion(double              Double)              => new DiscreteHeightUnion { Double              = Double };
    }
}