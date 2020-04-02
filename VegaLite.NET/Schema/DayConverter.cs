using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DayConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Day) || t == typeof(Day?);
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

                    return new Day
                    {
                        Double = doubleValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new Day
                    {
                        String = stringValue
                    };
            }

            throw new Exception("Cannot unmarshal type Day");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Day value = (Day)untypedValue;

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

            throw new Exception("Cannot marshal type Day");
        }

        public static readonly DayConverter Singleton = new DayConverter();
    }
}
