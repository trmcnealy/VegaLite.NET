using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class StrokeJoinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeJoin) || t == typeof(StrokeJoin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bevel":
                    return StrokeJoin.Bevel;
                case "miter":
                    return StrokeJoin.Miter;
                case "round":
                    return StrokeJoin.Round;
            }
            throw new Exception("Cannot unmarshal type StrokeJoin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StrokeJoin)untypedValue;
            switch (value)
            {
                case StrokeJoin.Bevel:
                    serializer.Serialize(writer, "bevel");
                    return;
                case StrokeJoin.Miter:
                    serializer.Serialize(writer, "miter");
                    return;
                case StrokeJoin.Round:
                    serializer.Serialize(writer, "round");
                    return;
            }
            throw new Exception("Cannot marshal type StrokeJoin");
        }

        public static readonly StrokeJoinConverter Singleton = new StrokeJoinConverter();
    }
}