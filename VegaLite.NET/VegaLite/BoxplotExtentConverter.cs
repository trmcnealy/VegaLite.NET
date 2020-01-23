using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BoxplotExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoxplotExtent) || t == typeof(BoxplotExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new BoxplotExtent { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "min-max")
                    {
                        return new BoxplotExtent { Enum = ExtentEnum.MinMax };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type BoxplotExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BoxplotExtent)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == ExtentEnum.MinMax)
                {
                    serializer.Serialize(writer, "min-max");
                    return;
                }
            }
            throw new Exception("Cannot marshal type BoxplotExtent");
        }

        public static readonly BoxplotExtentConverter Singleton = new BoxplotExtentConverter();
    }
}