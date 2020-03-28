using System.Collections.Generic;

namespace VegaLite
{
    public struct SignalRefExtent
    {
        public List<RangeRawArray> AnythingArray;
        public SignalRef     SignalRef;

        public static implicit operator SignalRefExtent(List<RangeRawArray> anythingArray)   => new SignalRefExtent { AnythingArray   = anythingArray };
        public static implicit operator SignalRefExtent(SignalRef     signalRef) => new SignalRefExtent { SignalRef = signalRef };
    }
}