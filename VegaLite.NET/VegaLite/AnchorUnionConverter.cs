using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class AnchorUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AnchorUnion) || t == typeof(AnchorUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new AnchorUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "end":
                            return new AnchorUnion { Enum = TitleAnchorEnum.End };
                        case "middle":
                            return new AnchorUnion { Enum = TitleAnchorEnum.Middle };
                        case "start":
                            return new AnchorUnion { Enum = TitleAnchorEnum.Start };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SignalRef>(reader);
                    return new AnchorUnion { SignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type AnchorUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AnchorUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TitleAnchorEnum.End:
                        serializer.Serialize(writer, "end");
                        return;
                    case TitleAnchorEnum.Middle:
                        serializer.Serialize(writer, "middle");
                        return;
                    case TitleAnchorEnum.Start:
                        serializer.Serialize(writer, "start");
                        return;
                }
            }
            if (value.SignalRef != null)
            {
                serializer.Serialize(writer, value.SignalRef);
                return;
            }
            throw new Exception("Cannot marshal type AnchorUnion");
        }

        public static readonly AnchorUnionConverter Singleton = new AnchorUnionConverter();
    }
}