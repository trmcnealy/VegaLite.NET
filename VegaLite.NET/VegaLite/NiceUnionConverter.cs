using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class NiceUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NiceUnion) || t == typeof(NiceUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new NiceUnion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new NiceUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new NiceUnion { Enum = NiceTime.Day };
                        case "hour":
                            return new NiceUnion { Enum = NiceTime.Hour };
                        case "minute":
                            return new NiceUnion { Enum = NiceTime.Minute };
                        case "month":
                            return new NiceUnion { Enum = NiceTime.Month };
                        case "second":
                            return new NiceUnion { Enum = NiceTime.Second };
                        case "week":
                            return new NiceUnion { Enum = NiceTime.Week };
                        case "year":
                            return new NiceUnion { Enum = NiceTime.Year };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<NiceClass>(reader);
                    return new NiceUnion { NiceClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type NiceUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (NiceUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case NiceTime.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case NiceTime.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case NiceTime.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case NiceTime.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case NiceTime.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case NiceTime.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case NiceTime.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            if (value.NiceClass != null)
            {
                serializer.Serialize(writer, value.NiceClass);
                return;
            }
            throw new Exception("Cannot marshal type NiceUnion");
        }

        public static readonly NiceUnionConverter Singleton = new NiceUnionConverter();
    }
}