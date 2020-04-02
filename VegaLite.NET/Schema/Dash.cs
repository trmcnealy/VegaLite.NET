using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct Dash
    {
        public ConditionalAxisPropertyNumberNull ConditionalAxisPropertyNumberNull;
        public List<double>                      DoubleArray;

        public static implicit operator Dash(ConditionalAxisPropertyNumberNull conditionalAxisPropertyNumberNull)
        {
            return new Dash
            {
                ConditionalAxisPropertyNumberNull = conditionalAxisPropertyNumberNull
            };
        }

        public static implicit operator Dash(List<double> doubleArray)
        {
            return new Dash
            {
                DoubleArray = doubleArray
            };
        }
    }
}
