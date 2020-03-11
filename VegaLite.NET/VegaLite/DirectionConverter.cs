using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class DirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Direction) || t == typeof(Direction?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "horizontal":
                            return new Direction { Enum = Orientation.Horizontal };
                        case "vertical":
                            return new Direction { Enum = Orientation.Vertical };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SignalRef>(reader);
                    return new Direction { SignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type Direction");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Direction)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Orientation.Horizontal:
                        serializer.Serialize(writer, "horizontal");
                        return;
                    case Orientation.Vertical:
                        serializer.Serialize(writer, "vertical");
                        return;
                }
            }
            if (value.SignalRef != null)
            {
                serializer.Serialize(writer, value.SignalRef);
                return;
            }
            throw new Exception("Cannot marshal type Direction");
        }

        public static readonly DirectionConverter Singleton = new DirectionConverter();
    }
}