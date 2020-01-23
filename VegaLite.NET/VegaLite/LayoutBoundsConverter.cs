using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LayoutBoundsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutBounds) || t == typeof(LayoutBounds?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "flush":
                            return new LayoutBounds { Enum = BoundsEnum.Flush };
                        case "full":
                            return new LayoutBounds { Enum = BoundsEnum.Full };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new LayoutBounds { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type LayoutBounds");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayoutBounds)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case BoundsEnum.Flush:
                        serializer.Serialize(writer, "flush");
                        return;
                    case BoundsEnum.Full:
                        serializer.Serialize(writer, "full");
                        return;
                }
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type LayoutBounds");
        }

        public static readonly LayoutBoundsConverter Singleton = new LayoutBoundsConverter();
    }
}