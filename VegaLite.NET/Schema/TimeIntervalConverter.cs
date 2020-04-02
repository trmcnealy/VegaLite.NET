using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TimeIntervalConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(TimeInterval) || t == typeof(TimeInterval?);
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
                case "day":         return TimeInterval.Day;
                case "hour":        return TimeInterval.Hour;
                case "millisecond": return TimeInterval.Millisecond;
                case "minute":      return TimeInterval.Minute;
                case "month":       return TimeInterval.Month;
                case "second":      return TimeInterval.Second;
                case "week":        return TimeInterval.Week;
                case "year":        return TimeInterval.Year;
            }

            throw new Exception("Cannot unmarshal type TimeInterval");
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

            TimeInterval value = (TimeInterval)untypedValue;

            switch(value)
            {
                case TimeInterval.Day:
                    serializer.Serialize(writer,
                                         "day");

                    return;
                case TimeInterval.Hour:
                    serializer.Serialize(writer,
                                         "hour");

                    return;
                case TimeInterval.Millisecond:
                    serializer.Serialize(writer,
                                         "millisecond");

                    return;
                case TimeInterval.Minute:
                    serializer.Serialize(writer,
                                         "minute");

                    return;
                case TimeInterval.Month:
                    serializer.Serialize(writer,
                                         "month");

                    return;
                case TimeInterval.Second:
                    serializer.Serialize(writer,
                                         "second");

                    return;
                case TimeInterval.Week:
                    serializer.Serialize(writer,
                                         "week");

                    return;
                case TimeInterval.Year:
                    serializer.Serialize(writer,
                                         "year");

                    return;
            }

            throw new Exception("Cannot marshal type TimeInterval");
        }

        public static readonly TimeIntervalConverter Singleton = new TimeIntervalConverter();
    }
}
