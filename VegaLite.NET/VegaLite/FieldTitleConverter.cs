using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FieldTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FieldTitle) || t == typeof(FieldTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "functional":
                    return FieldTitle.Functional;
                case "plain":
                    return FieldTitle.Plain;
                case "verbal":
                    return FieldTitle.Verbal;
            }
            throw new Exception("Cannot unmarshal type FieldTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FieldTitle)untypedValue;
            switch (value)
            {
                case FieldTitle.Functional:
                    serializer.Serialize(writer, "functional");
                    return;
                case FieldTitle.Plain:
                    serializer.Serialize(writer, "plain");
                    return;
                case FieldTitle.Verbal:
                    serializer.Serialize(writer, "verbal");
                    return;
            }
            throw new Exception("Cannot marshal type FieldTitle");
        }

        public static readonly FieldTitleConverter Singleton = new FieldTitleConverter();
    }
}