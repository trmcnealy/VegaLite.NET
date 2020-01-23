using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Customized domain values.
    ///
    /// For _quantitative_ fields, `domain` can take the form of a two-element array with minimum
    /// and maximum values. [Piecewise
    /// scales](https://vega.github.io/vega-lite/docs/scale.html#piecewise) can be created by
    /// providing a `domain` with more than two entries.
    /// If the input field is aggregated, `domain` can also be a string value `"unaggregated"`,
    /// indicating that the domain should include the raw data values prior to the aggregation.
    ///
    /// For _temporal_ fields, `domain` can be a two-element array minimum and maximum values, in
    /// the form of either timestamps or the [DateTime definition
    /// objects](https://vega.github.io/vega-lite/docs/types.html#datetime).
    ///
    /// For _ordinal_ and _nominal_ fields, `domain` can be an array that lists valid input
    /// values.
    ///
    /// The `selection` property can be used to [interactively
    /// determine](https://vega.github.io/vega-lite/docs/selection.html#scale-domains) the scale
    /// domain.
    /// </summary>
    public struct DomainUnion
    {
        public List<Equal> AnythingArray;
        public DomainClass DomainClass;
        public Domain?     Enum;

        public static implicit operator DomainUnion(List<Equal> AnythingArray) => new DomainUnion { AnythingArray = AnythingArray };
        public static implicit operator DomainUnion(DomainClass DomainClass)   => new DomainUnion { DomainClass   = DomainClass };
        public static implicit operator DomainUnion(Domain      Enum)          => new DomainUnion { Enum          = Enum };
    }
}