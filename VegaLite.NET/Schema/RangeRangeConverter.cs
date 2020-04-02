using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RangeRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RangeRange) || t == typeof(RangeRange?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new RangeRange
                    {
                        Double = doubleValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new RangeRange
                    {
                        String = stringValue
                    };
            }

            throw new Exception("Cannot unmarshal type RangeRange");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            RangeRange value = (RangeRange)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            throw new Exception("Cannot marshal type RangeRange");
        }

        public static readonly RangeRangeConverter Singleton = new RangeRangeConverter();
    }
}
