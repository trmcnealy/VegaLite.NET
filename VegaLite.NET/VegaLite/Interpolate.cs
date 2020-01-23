﻿namespace VegaLite
{
    /// <summary>
    /// The line interpolation method to use for line and area marks. One of the following:
    /// - `"linear"`: piecewise linear segments, as in a polyline.
    /// - `"linear-closed"`: close the linear segments to form a polygon.
    /// - `"step"`: alternate between horizontal and vertical segments, as in a step function.
    /// - `"step-before"`: alternate between vertical and horizontal segments, as in a step
    /// function.
    /// - `"step-after"`: alternate between horizontal and vertical segments, as in a step
    /// function.
    /// - `"basis"`: a B-spline, with control point duplication on the ends.
    /// - `"basis-open"`: an open B-spline; may not intersect the start or end.
    /// - `"basis-closed"`: a closed B-spline, as in a loop.
    /// - `"cardinal"`: a Cardinal spline, with control point duplication on the ends.
    /// - `"cardinal-open"`: an open Cardinal spline; may not intersect the start or end, but
    /// will intersect other control points.
    /// - `"cardinal-closed"`: a closed Cardinal spline, as in a loop.
    /// - `"bundle"`: equivalent to basis, except the tension parameter is used to straighten the
    /// spline.
    /// - `"monotone"`: cubic interpolation that preserves monotonicity in y.
    ///
    /// The line interpolation method for the error band. One of the following:
    /// - `"linear"`: piecewise linear segments, as in a polyline.
    /// - `"linear-closed"`: close the linear segments to form a polygon.
    /// - `"step"`: a piecewise constant function (a step function) consisting of alternating
    /// horizontal and vertical lines. The y-value changes at the midpoint of each pair of
    /// adjacent x-values.
    /// - `"step-before"`: a piecewise constant function (a step function) consisting of
    /// alternating horizontal and vertical lines. The y-value changes before the x-value.
    /// - `"step-after"`: a piecewise constant function (a step function) consisting of
    /// alternating horizontal and vertical lines. The y-value changes after the x-value.
    /// - `"basis"`: a B-spline, with control point duplication on the ends.
    /// - `"basis-open"`: an open B-spline; may not intersect the start or end.
    /// - `"basis-closed"`: a closed B-spline, as in a loop.
    /// - `"cardinal"`: a Cardinal spline, with control point duplication on the ends.
    /// - `"cardinal-open"`: an open Cardinal spline; may not intersect the start or end, but
    /// will intersect other control points.
    /// - `"cardinal-closed"`: a closed Cardinal spline, as in a loop.
    /// - `"bundle"`: equivalent to basis, except the tension parameter is used to straighten the
    /// spline.
    /// - `"monotone"`: cubic interpolation that preserves monotonicity in y.
    /// </summary>
    public enum Interpolate { Basis, BasisClosed, BasisOpen, Bundle, Cardinal, CardinalClosed, CardinalOpen, CatmullRom, Linear, LinearClosed, Monotone, Natural, Step, StepAfter, StepBefore };
}