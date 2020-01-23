using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class HeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HeightUnion) || t == typeof(HeightUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new HeightUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "container")
                    {
                        return new HeightUnion { Enum = HeightEnum.Container };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Step>(reader);
                    return new HeightUnion { Step = objectValue };
            }
            throw new Exception("Cannot unmarshal type HeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HeightUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == HeightEnum.Container)
                {
                    serializer.Serialize(writer, "container");
                    return;
                }
            }
            if (value.Step != null)
            {
                serializer.Serialize(writer, value.Step);
                return;
            }
            throw new Exception("Cannot marshal type HeightUnion");
        }

        public static readonly HeightUnionConverter Singleton = new HeightUnionConverter();
    }
}