using System.Collections.Generic;

namespace VegaLite
{
    public struct RangeRaw
    {
        public List<RangeRawArray> AnythingArray;
        public bool?               Bool;
        public double?             Double;
        public PurpleSignalRef     PurpleSignalRef;
        public string              String;

        public static implicit operator RangeRaw(List<RangeRawArray> AnythingArray)   => new RangeRaw { AnythingArray   = AnythingArray };
        public static implicit operator RangeRaw(bool                Bool)            => new RangeRaw { Bool            = Bool };
        public static implicit operator RangeRaw(double              Double)          => new RangeRaw { Double          = Double };
        public static implicit operator RangeRaw(PurpleSignalRef     PurpleSignalRef) => new RangeRaw { PurpleSignalRef = PurpleSignalRef };
        public static implicit operator RangeRaw(string              String)          => new RangeRaw { String          = String };
        public                          bool IsNull                                   => AnythingArray == null && Bool == null && PurpleSignalRef == null && Double == null && String == null;
    }
}