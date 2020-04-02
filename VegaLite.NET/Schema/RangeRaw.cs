using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct RangeRaw
    {
        public List<RangeRawArray> AnythingArray;
        public bool?               Bool;
        public double?             Double;
        public SignalRef           SignalRef;
        public string              String;

        public static implicit operator RangeRaw(List<RangeRawArray> anythingArray)
        {
            return new RangeRaw
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator RangeRaw(bool @bool)
        {
            return new RangeRaw
            {
                Bool = @bool
            };
        }

        public static implicit operator RangeRaw(double @double)
        {
            return new RangeRaw
            {
                Double = @double
            };
        }

        public static implicit operator RangeRaw(SignalRef signalRef)
        {
            return new RangeRaw
            {
                SignalRef = signalRef
            };
        }

        public static implicit operator RangeRaw(string @string)
        {
            return new RangeRaw
            {
                String = @string
            };
        }

        public bool IsNull { get { return AnythingArray == null && Bool == null && SignalRef == null && Double == null && String == null; } }
    }
}
