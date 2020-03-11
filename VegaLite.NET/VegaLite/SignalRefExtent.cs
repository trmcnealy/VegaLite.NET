using System.Collections.Generic;

namespace VegaLite
{
    public struct SignalRefExtent
    {
        public List<RangeRawArray> AnythingArray;
        public SignalRef     SignalRef;

        public static implicit operator SignalRefExtent(List<RangeRawArray> AnythingArray)   => new SignalRefExtent { AnythingArray   = AnythingArray };
        public static implicit operator SignalRefExtent(SignalRef     SignalRef) => new SignalRefExtent { SignalRef = SignalRef };
    }
}