using System.Collections.Generic;

namespace VegaLite
{
    public struct Dash
    {
        public ConditionalAxisPropertyNumberNull ConditionalAxisPropertyNumberNull;
        public List<double>                      DoubleArray;

        public static implicit operator Dash(ConditionalAxisPropertyNumberNull ConditionalAxisPropertyNumberNull) => new Dash { ConditionalAxisPropertyNumberNull = ConditionalAxisPropertyNumberNull };
        public static implicit operator Dash(List<double>                      DoubleArray)                       => new Dash { DoubleArray                       = DoubleArray };
    }
}