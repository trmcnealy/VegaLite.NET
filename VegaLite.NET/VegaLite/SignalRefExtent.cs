using System.Collections.Generic;

namespace VegaLite
{
    public struct SignalRefExtent
    {
        public List<RangeRawArray> AnythingArray;
        public PurpleSignalRef     PurpleSignalRef;

        public static implicit operator SignalRefExtent(List<RangeRawArray> AnythingArray)   => new SignalRefExtent { AnythingArray   = AnythingArray };
        public static implicit operator SignalRefExtent(PurpleSignalRef     PurpleSignalRef) => new SignalRefExtent { PurpleSignalRef = PurpleSignalRef };
    }
}