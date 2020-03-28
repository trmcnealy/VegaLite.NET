using System.Collections.Generic;

namespace VegaLite
{
    public struct RangeRaw
    {
        public List<RangeRawArray> AnythingArray;
        public bool?               Bool;
        public double?             Double;
        public SignalRef     SignalRef;
        public string              String;

        public static implicit operator RangeRaw(List<RangeRawArray> anythingArray)   => new RangeRaw { AnythingArray   = anythingArray };
        public static implicit operator RangeRaw(bool                @bool)            => new RangeRaw { Bool            = @bool };
        public static implicit operator RangeRaw(double              @double)          => new RangeRaw { Double          = @double };
        public static implicit operator RangeRaw(SignalRef     signalRef) => new RangeRaw { SignalRef = signalRef };
        public static implicit operator RangeRaw(string              @string)          => new RangeRaw { String          = @string };
        public                          bool IsNull                                   => AnythingArray == null && Bool == null && SignalRef == null && Double == null && String == null;
    }
}