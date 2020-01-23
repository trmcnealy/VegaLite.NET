﻿namespace VegaLite
{
    /// <summary>
    /// Aggregation function for the field
    /// (e.g., `"mean"`, `"sum"`, `"median"`, `"min"`, `"max"`, `"count"`).
    ///
    /// __Default value:__ `undefined` (None)
    ///
    /// __See also:__ [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html)
    /// documentation.
    /// </summary>
    public struct Aggregate
    {
        public ArgmDef            ArgmDef;
        public NonArgAggregateOp? Enum;

        public static implicit operator Aggregate(ArgmDef           ArgmDef) => new Aggregate { ArgmDef = ArgmDef };
        public static implicit operator Aggregate(NonArgAggregateOp Enum)    => new Aggregate { Enum    = Enum };
    }
}