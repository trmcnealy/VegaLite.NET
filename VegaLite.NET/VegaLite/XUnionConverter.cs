using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class XUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(XUnion) || t == typeof(XUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new XUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "width")
                    {
                        return new XUnion { Enum = PurpleValue.Width };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type XUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (XUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == PurpleValue.Width)
                {
                    serializer.Serialize(writer, "width");
                    return;
                }
            }
            throw new Exception("Cannot marshal type XUnion");
        }

        public static readonly XUnionConverter Singleton = new XUnionConverter();
    }
}