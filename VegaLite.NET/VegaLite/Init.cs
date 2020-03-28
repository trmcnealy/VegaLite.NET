using System.Collections.Generic;

namespace VegaLite
{
    public struct Init
    {
        public Dictionary<string, InitValue>           AnythingMap;
        public List<Dictionary<string, SelectionInit>> AnythingMapArray;

        public static implicit operator Init(Dictionary<string, InitValue>           anythingMap)      => new Init { AnythingMap      = anythingMap };
        public static implicit operator Init(List<Dictionary<string, SelectionInit>> anythingMapArray) => new Init { AnythingMapArray = anythingMapArray };
    }
}