using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct InitValue
    {
        public List<Equal> AnythingArray;
        public bool?       Bool;
        public DateTime    DateTime;
        public double?     Double;
        public string      String;

        public static implicit operator InitValue(List<Equal> anythingArray)
        {
            return new InitValue
            {
                AnythingArray = anythingArray
            };
        }

        public static implicit operator InitValue(bool @bool)
        {
            return new InitValue
            {
                Bool = @bool
            };
        }

        public static implicit operator InitValue(DateTime dateTime)
        {
            return new InitValue
            {
                DateTime = dateTime
            };
        }

        public static implicit operator InitValue(double @double)
        {
            return new InitValue
            {
                Double = @double
            };
        }

        public static implicit operator InitValue(string @string)
        {
            return new InitValue
            {
                String = @string
            };
        }

        public bool IsNull { get { return AnythingArray == null && Bool == null && DateTime == null && Double == null && String == null; } }
    }
}
