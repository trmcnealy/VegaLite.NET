using System.Collections.Generic;

namespace VegaLite
{
    public struct Dash
    {
        public ConditionalAxisPropertyNumberNull ConditionalAxisPropertyNumberNull;
        public List<double>                      DoubleArray;

        public static implicit operator Dash(ConditionalAxisPropertyNumberNull conditionalAxisPropertyNumberNull) => new Dash { ConditionalAxisPropertyNumberNull = conditionalAxisPropertyNumberNull };
        public static implicit operator Dash(List<double>                      doubleArray)                       => new Dash { DoubleArray                       = doubleArray };
    }
}