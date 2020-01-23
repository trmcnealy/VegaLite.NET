using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LabelFontWeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFontWeightUnion) || t == typeof(LabelFontWeightUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LabelFontWeightUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bold":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Bold };
                        case "bolder":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Bolder };
                        case "lighter":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Lighter };
                        case "normal":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Normal };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyFontWeightNull>(reader);
                    return new LabelFontWeightUnion { ConditionalAxisPropertyFontWeightNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelFontWeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFontWeightUnion)untypedValue;
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
            if (value.ConditionalAxisPropertyFontWeightNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyFontWeightNull);
                return;
            }
            throw new Exception("Cannot marshal type LabelFontWeightUnion");
        }

        public static readonly LabelFontWeightUnionConverter Singleton = new LabelFontWeightUnionConverter();
    }
}