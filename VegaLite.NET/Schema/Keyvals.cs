using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct Keyvals
    {
        public List<object>   AnythingArray;
        public ImputeSequence ImputeSequence;

        public static implicit operator Keyvals(List<object> anythingArray)
        {
            return new Keyvals
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator Keyvals(ImputeSequence imputeSequence)
        {
            return new Keyvals
            {
                ImputeSequence = imputeSequence
            };
        }
    }
}
