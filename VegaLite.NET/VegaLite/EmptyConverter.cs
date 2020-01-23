using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class EmptyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Empty) || t == typeof(Empty?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return Empty.All;
                case "none":
                    return Empty.None;
            }
            throw new Exception("Cannot unmarshal type Empty");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Empty)untypedValue;
            switch (value)
            {
                case Empty.All:
                    serializer.Serialize(writer, "all");
                    return;
                case Empty.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type Empty");
        }

        public static readonly EmptyConverter Singleton = new EmptyConverter();
    }
}