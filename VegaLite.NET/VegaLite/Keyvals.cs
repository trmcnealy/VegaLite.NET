using System.Collections.Generic;

namespace VegaLite
{
    public struct Keyvals
    {
        public List<object>   AnythingArray;
        public ImputeSequence ImputeSequence;

        public static implicit operator Keyvals(List<object>   AnythingArray)  => new Keyvals { AnythingArray  = AnythingArray };
        public static implicit operator Keyvals(ImputeSequence ImputeSequence) => new Keyvals { ImputeSequence = ImputeSequence };
    }
}