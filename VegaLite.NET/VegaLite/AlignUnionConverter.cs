using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AlignUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlignUnion) || t == typeof(AlignUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "all":
                            return new AlignUnion { Enum = LayoutAlign.All };
                        case "each":
                            return new AlignUnion { Enum = LayoutAlign.Each };
                        case "none":
                            return new AlignUnion { Enum = LayoutAlign.None };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RowColLayoutAlign>(reader);
                    return new AlignUnion { RowColLayoutAlign = objectValue };
            }
            throw new Exception("Cannot unmarshal type AlignUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AlignUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LayoutAlign.All:
                        serializer.Serialize(writer, "all");
                        return;
                    case LayoutAlign.Each:
                        serializer.Serialize(writer, "each");
                        return;
                    case LayoutAlign.None:
                        serializer.Serialize(writer, "none");
                        return;
                }
            }
            if (value.RowColLayoutAlign != null)
            {
                serializer.Serialize(writer, value.RowColLayoutAlign);
                return;
            }
            throw new Exception("Cannot marshal type AlignUnion");
        }

        public static readonly AlignUnionConverter Singleton = new AlignUnionConverter();
    }
}