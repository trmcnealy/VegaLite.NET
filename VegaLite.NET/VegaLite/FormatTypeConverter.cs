using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FormatTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FormatType) || t == typeof(FormatType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "number":
                    return FormatType.Number;
                case "time":
                    return FormatType.Time;
            }
            throw new Exception("Cannot unmarshal type FormatType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FormatType)untypedValue;
            switch (value)
            {
                case FormatType.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case FormatType.Time:
                    serializer.Serialize(writer, "time");
                    return;
            }
            throw new Exception("Cannot marshal type FormatType");
        }

        public static readonly FormatTypeConverter Singleton = new FormatTypeConverter();
    }
}