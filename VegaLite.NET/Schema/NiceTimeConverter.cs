using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class NiceTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(NiceTime) || t == typeof(NiceTime?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "day":    return NiceTime.Day;
                case "hour":   return NiceTime.Hour;
                case "minute": return NiceTime.Minute;
                case "month":  return NiceTime.Month;
                case "second": return NiceTime.Second;
                case "week":   return NiceTime.Week;
                case "year":   return NiceTime.Year;
            }

            throw new Exception("Cannot unmarshal type NiceTime");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            NiceTime value = (NiceTime)untypedValue;

            switch(value)
            {
                case NiceTime.Day:
                    serializer.Serialize(writer,
                                         "day");

                    return;
                case NiceTime.Hour:
                    serializer.Serialize(writer,
                                         "hour");

                    return;
                case NiceTime.Minute:
                    serializer.Serialize(writer,
                                         "minute");

                    return;
                case NiceTime.Month:
                    serializer.Serialize(writer,
                                         "month");

                    return;
                case NiceTime.Second:
                    serializer.Serialize(writer,
                                         "second");

                    return;
                case NiceTime.Week:
                    serializer.Serialize(writer,
                                         "week");

                    return;
                case NiceTime.Year:
                    serializer.Serialize(writer,
                                         "year");

                    return;
            }

            throw new Exception("Cannot marshal type NiceTime");
        }

        public static readonly NiceTimeConverter Singleton = new NiceTimeConverter();
    }
}
