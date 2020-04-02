using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct SignalRefExtent
    {
        public List<RangeRawArray> AnythingArray;
        public SignalRef           SignalRef;

        public static implicit operator SignalRefExtent(List<RangeRawArray> anythingArray)
        {
            return new SignalRefExtent
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator SignalRefExtent(SignalRef signalRef)
        {
            return new SignalRefExtent
            {
                SignalRef = signalRef
            };
        }
    }
}
