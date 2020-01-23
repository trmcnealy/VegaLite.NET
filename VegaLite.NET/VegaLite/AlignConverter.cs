using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Align) || t == typeof(Align?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return Align.Center;
                case "left":
                    return Align.Left;
                case "right":
                    return Align.Right;
            }
            throw new Exception("Cannot unmarshal type Align");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Align)untypedValue;
            switch (value)
            {
                case Align.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case Align.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case Align.Right:
                    serializer.Serialize(writer, "right");
                    return;
            }
            throw new Exception("Cannot marshal type Align");
        }

        public static readonly AlignConverter Singleton = new AlignConverter();
    }
}