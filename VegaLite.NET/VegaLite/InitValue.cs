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

        public static implicit operator InitValue(List<Equal> anythingArray) => new InitValue { AnythingArray = anythingArray };
        public static implicit operator InitValue(bool        @bool)          => new InitValue { Bool          = @bool };
        public static implicit operator InitValue(DateTime    dateTime)      => new InitValue { DateTime      = dateTime };
        public static implicit operator InitValue(double      @double)        => new InitValue { Double        = @double };
        public static implicit operator InitValue(string      @string)        => new InitValue { String        = @string };
        public                          bool IsNull                          => AnythingArray == null && Bool == null && DateTime == null && Double == null && String == null;
    }
}