namespace VegaLite
{
    /// <summary>
    /// Extending the domain so that it starts and ends on nice round values. This method
    /// typically modifies the scale’s domain, and may only extend the bounds to the nearest
    /// round value. Nicing is useful if the domain is computed from data and may be irregular.
    /// For example, for a domain of _[0.201479…, 0.996679…]_, a nice domain might be _[0.2,
    /// 1.0]_.
    ///
    /// For quantitative scales such as linear, `nice` can be either a boolean flag or a number.
    /// If `nice` is a number, it will represent a desired tick count. This allows greater
    /// control over the step size used to extend the bounds, guaranteeing that the returned
    /// ticks will exactly cover the domain.
    ///
    /// For temporal fields with time and utc scales, the `nice` value can be a string indicating
    /// the desired time interval. Legal values are `"millisecond"`, `"second"`, `"minute"`,
    /// `"hour"`, `"day"`, `"week"`, `"month"`, and `"year"`. Alternatively, `time` and `utc`
    /// scales can accept an object-valued interval specifier of the form `{"interval": "month",
    /// "step": 3}`, which includes a desired number of interval steps. Here, the domain would
    /// snap to quarter (Jan, Apr, Jul, Oct) boundaries.
    ///
    /// __Default value:__ `true` for unbinned _quantitative_ fields; `false` otherwise.
    /// </summary>
    public struct NiceUnion
    {
        public bool?     Bool;
        public double?   Double;
        public NiceTime? Enum;
        public NiceClass NiceClass;

        public static implicit operator NiceUnion(bool      @bool)      => new NiceUnion { Bool      = @bool };
        public static implicit operator NiceUnion(double    @double)    => new NiceUnion { Double    = @double };
        public static implicit operator NiceUnion(NiceTime  @enum)      => new NiceUnion { Enum      = @enum };
        public static implicit operator NiceUnion(NiceClass niceClass) => new NiceUnion { NiceClass = niceClass };
    }
}