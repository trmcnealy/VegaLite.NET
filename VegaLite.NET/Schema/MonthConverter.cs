using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class MonthConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Month) || t == typeof(Month?);
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

                    return new Month
                    {
                        Double = doubleValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new Month
                    {
                        String = stringValue
                    };
            }

            throw new Exception("Cannot unmarshal type Month");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Month value = (Month)untypedValue;

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

            throw new Exception("Cannot marshal type Month");
        }

        public static readonly MonthConverter Singleton = new MonthConverter();
    }
}
