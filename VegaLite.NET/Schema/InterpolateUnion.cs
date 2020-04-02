namespace VegaLite.Schema
{
    /// <summary>
    /// The interpolation method for range values. By default, a general interpolator for
    /// numbers, dates, strings and colors (in HCL space) is used. For color ranges, this
    /// property allows interpolation in alternative color spaces. Legal values include `rgb`,
    /// `hsl`, `hsl-long`, `lab`, `hcl`, `hcl-long`, `cubehelix` and `cubehelix-long` ('-long'
    /// variants use longer paths in polar coordinate spaces). If object-valued, this property
    /// accepts an object with a string-valued _type_ property and an optional numeric _gamma_
    /// property applicable to rgb and cubehelix interpolators. For more, see the [d3-interpolate
    /// documentation](https://github.com/d3/d3-interpolate).
    ///
    /// * __Default value:__ `hcl`
    /// </summary>
    public struct InterpolateUnion
    {
        public ScaleInterpolate?      Enum;
        public ScaleInterpolateParams ScaleInterpolateParams;

        public static implicit operator InterpolateUnion(ScaleInterpolate @enum)
        {
            return new InterpolateUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator InterpolateUnion(ScaleInterpolateParams scaleInterpolateParams)
        {
            return new InterpolateUnion
            {
                ScaleInterpolateParams = scaleInterpolateParams
            };
        }
    }
}
