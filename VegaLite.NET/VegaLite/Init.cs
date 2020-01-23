using System.Collections.Generic;

namespace VegaLite
{
    public struct Init
    {
        public Dictionary<string, InitValue>           AnythingMap;
        public List<Dictionary<string, SelectionInit>> AnythingMapArray;

        public static implicit operator Init(Dictionary<string, InitValue>           AnythingMap)      => new Init { AnythingMap      = AnythingMap };
        public static implicit operator Init(List<Dictionary<string, SelectionInit>> AnythingMapArray) => new Init { AnythingMapArray = AnythingMapArray };
    }
}