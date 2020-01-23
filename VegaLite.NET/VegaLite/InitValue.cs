using System.Collections.Generic;

namespace VegaLite
{
    public struct InitValue
    {
        public List<Equal> AnythingArray;
        public bool?       Bool;
        public DateTime    DateTime;
        public double?     Double;
        public string      String;

        public static implicit operator InitValue(List<Equal> AnythingArray) => new InitValue { AnythingArray = AnythingArray };
        public static implicit operator InitValue(bool        Bool)          => new InitValue { Bool          = Bool };
        public static implicit operator InitValue(DateTime    DateTime)      => new InitValue { DateTime      = DateTime };
        public static implicit operator InitValue(double      Double)        => new InitValue { Double        = Double };
        public static implicit operator InitValue(string      String)        => new InitValue { String        = String };
        public                          bool IsNull                          => AnythingArray == null && Bool == null && DateTime == null && Double == null && String == null;
    }
}