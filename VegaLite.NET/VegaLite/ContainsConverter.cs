using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ContainsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Contains) || t == typeof(Contains?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "content":
                    return Contains.Content;
                case "padding":
                    return Contains.Padding;
            }
            throw new Exception("Cannot unmarshal type Contains");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Contains)untypedValue;
            switch (value)
            {
                case Contains.Content:
                    serializer.Serialize(writer, "content");
                    return;
                case Contains.Padding:
                    serializer.Serialize(writer, "padding");
                    return;
            }
            throw new Exception("Cannot marshal type Contains");
        }

        public static readonly ContainsConverter Singleton = new ContainsConverter();
    }
}