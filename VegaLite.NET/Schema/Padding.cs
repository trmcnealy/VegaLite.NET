namespace VegaLite.Schema
{
    /// <summary>
    /// The default visualization padding, in pixels, from the edge of the visualization canvas
    /// to the data rectangle. If a number, specifies padding for all sides.
    /// If an object, the value should have the format `{"left": 5, "top": 5, "right": 5,
    /// "bottom": 5}` to specify padding for each side of the visualization.
    ///
    /// __Default value__: `5`
    /// </summary>
    public struct Padding
    {
        public double?      Double;
        public PaddingClass PaddingClass;

        public static implicit operator Padding(double @double)
        {
            return new Padding
            {
                Double = @double
            };
        }

        public static implicit operator Padding(PaddingClass paddingClass)
        {
            return new Padding
            {
                PaddingClass = paddingClass
            };
        }
    }
}
