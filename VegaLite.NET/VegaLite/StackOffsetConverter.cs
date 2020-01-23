using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class StackOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StackOffset) || t == typeof(StackOffset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return StackOffset.Center;
                case "normalize":
                    return StackOffset.Normalize;
                case "zero":
                    return StackOffset.Zero;
            }
            throw new Exception("Cannot unmarshal type StackOffset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StackOffset)untypedValue;
            switch (value)
            {
                case StackOffset.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case StackOffset.Normalize:
                    serializer.Serialize(writer, "normalize");
                    return;
                case StackOffset.Zero:
                    serializer.Serialize(writer, "zero");
                    return;
            }
            throw new Exception("Cannot marshal type StackOffset");
        }

        public static readonly StackOffsetConverter Singleton = new StackOffsetConverter();
    }
}