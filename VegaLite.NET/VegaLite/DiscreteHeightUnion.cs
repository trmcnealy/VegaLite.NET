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

        public static implicit operator DiscreteHeightUnion(DiscreteHeightClass discreteHeightClass) => new DiscreteHeightUnion { DiscreteHeightClass = discreteHeightClass };
        public static implicit operator DiscreteHeightUnion(double              @double)              => new DiscreteHeightUnion { Double              = @double };
    }
}