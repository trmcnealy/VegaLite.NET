using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BoxConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Box) || t == typeof(Box?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Box { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<MarkConfig>(reader);
                    return new Box { MarkConfig = objectValue };
            }
            throw new Exception("Cannot unmarshal type Box");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Box)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.MarkConfig != null)
            {
                serializer.Serialize(writer, value.MarkConfig);
                return;
            }
            throw new Exception("Cannot marshal type Box");
        }

        public static readonly BoxConverter Singleton = new BoxConverter();
    }
}