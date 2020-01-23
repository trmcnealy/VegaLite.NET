using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class StrokeCapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeCap) || t == typeof(StrokeCap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "butt":
                    return StrokeCap.Butt;
                case "round":
                    return StrokeCap.Round;
                case "square":
                    return StrokeCap.Square;
            }
            throw new Exception("Cannot unmarshal type StrokeCap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StrokeCap)untypedValue;
            switch (value)
            {
                case StrokeCap.Butt:
                    serializer.Serialize(writer, "butt");
                    return;
                case StrokeCap.Round:
                    serializer.Serialize(writer, "round");
                    return;
                case StrokeCap.Square:
                    serializer.Serialize(writer, "square");
                    return;
            }
            throw new Exception("Cannot marshal type StrokeCap");
        }

        public static readonly StrokeCapConverter Singleton = new StrokeCapConverter();
    }
}