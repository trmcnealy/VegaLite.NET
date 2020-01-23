using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// The range of the scale. One of:
    ///
    /// - A string indicating a [pre-defined named scale
    /// range](https://vega.github.io/vega-lite/docs/scale.html#range-config) (e.g., example,
    /// `"symbol"`, or `"diverging"`).
    ///
    /// - For [continuous scales](https://vega.github.io/vega-lite/docs/scale.html#continuous),
    /// two-element array indicating  minimum and maximum values, or an array with more than two
    /// entries for specifying a [piecewise
    /// scale](https://vega.github.io/vega-lite/docs/scale.html#piecewise).
    ///
    /// - For [discrete](https://vega.github.io/vega-lite/docs/scale.html#discrete) and
    /// [discretizing](https://vega.github.io/vega-lite/docs/scale.html#discretizing) scales, an
    /// array of desired output values.
    ///
    /// __Notes:__
    ///
    /// 1) For color scales you can also specify a color
    /// [`scheme`](https://vega.github.io/vega-lite/docs/scale.html#scheme) instead of `range`.
    ///
    /// 2) Any directly specified `range` for `x` and `y` channels will be ignored. Range can be
    /// customized via the view's corresponding
    /// [size](https://vega.github.io/vega-lite/docs/size.html) (`width` and `height`).
    /// </summary>
    public struct ScaleRange
    {
        public List<RangeRange> AnythingArray;
        public RangeEnum?       Enum;

        public static implicit operator ScaleRange(List<RangeRange> AnythingArray) => new ScaleRange { AnythingArray = AnythingArray };
        public static implicit operator ScaleRange(RangeEnum        Enum)          => new ScaleRange { Enum          = Enum };
    }
}