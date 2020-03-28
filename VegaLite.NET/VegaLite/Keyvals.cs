using System.Collections.Generic;

namespace VegaLite
{
    public struct Keyvals
    {
        public List<object>   AnythingArray;
        public ImputeSequence ImputeSequence;

        public static implicit operator Keyvals(List<object>   anythingArray)  => new Keyvals { AnythingArray  = anythingArray };
        public static implicit operator Keyvals(ImputeSequence imputeSequence) => new Keyvals { ImputeSequence = imputeSequence };
    }
}