using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FontWeightConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontWeight) || t == typeof(FontWeight?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FontWeight { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bold":
                            return new FontWeight { Enum = PurpleFontWeight.Bold };
                        case "bolder":
                            return new FontWeight { Enum = PurpleFontWeight.Bolder };
                        case "lighter":
                            return new FontWeight { Enum = PurpleFontWeight.Lighter };
                        case "normal":
                            return new FontWeight { Enum = PurpleFontWeight.Normal };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type FontWeight");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FontWeight)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleFontWeight.Bold:
                        serializer.Serialize(writer, "bold");
                        return;
                    case PurpleFontWeight.Bolder:
                        serializer.Serialize(writer, "bolder");
                        return;
                    case PurpleFontWeight.Lighter:
                        serializer.Serialize(writer, "lighter");
                        return;
                    case PurpleFontWeight.Normal:
                        serializer.Serialize(writer, "normal");
                        return;
                }
            }
            throw new Exception("Cannot marshal type FontWeight");
        }

        public static readonly FontWeightConverter Singleton = new FontWeightConverter();
    }
}