using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class YUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(YUnion) || t == typeof(YUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new YUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "height")
                    {
                        return new YUnion { Enum = HeightValue.Height };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type YUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (YUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == HeightValue.Height)
                {
                    serializer.Serialize(writer, "height");
                    return;
                }
            }
            throw new Exception("Cannot marshal type YUnion");
        }

        public static readonly YUnionConverter Singleton = new YUnionConverter();
    }
}