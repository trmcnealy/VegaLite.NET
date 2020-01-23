using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class OrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Orient) || t == typeof(Orient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return Orient.Bottom;
                case "left":
                    return Orient.Left;
                case "right":
                    return Orient.Right;
                case "top":
                    return Orient.Top;
            }
            throw new Exception("Cannot unmarshal type Orient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Orient)untypedValue;
            switch (value)
            {
                case Orient.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case Orient.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case Orient.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case Orient.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type Orient");
        }

        public static readonly OrientConverter Singleton = new OrientConverter();
    }
}