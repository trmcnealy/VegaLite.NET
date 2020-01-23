using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class TickCountConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickCount) || t == typeof(TickCount?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TickCount { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new TickCount { Enum = TimeInterval.Day };
                        case "hour":
                            return new TickCount { Enum = TimeInterval.Hour };
                        case "millisecond":
                            return new TickCount { Enum = TimeInterval.Millisecond };
                        case "minute":
                            return new TickCount { Enum = TimeInterval.Minute };
                        case "month":
                            return new TickCount { Enum = TimeInterval.Month };
                        case "second":
                            return new TickCount { Enum = TimeInterval.Second };
                        case "week":
                            return new TickCount { Enum = TimeInterval.Week };
                        case "year":
                            return new TickCount { Enum = TimeInterval.Year };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type TickCount");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TickCount)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TimeInterval.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case TimeInterval.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case TimeInterval.Millisecond:
                        serializer.Serialize(writer, "millisecond");
                        return;
                    case TimeInterval.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case TimeInterval.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case TimeInterval.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case TimeInterval.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case TimeInterval.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            throw new Exception("Cannot marshal type TickCount");
        }

        public static readonly TickCountConverter Singleton = new TickCountConverter();
    }
}