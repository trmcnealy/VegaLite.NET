using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class StackConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Stack) || t == typeof(Stack?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Stack();
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Stack { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new Stack { Enum = StackOffset.Center };
                        case "normalize":
                            return new Stack { Enum = StackOffset.Normalize };
                        case "zero":
                            return new Stack { Enum = StackOffset.Zero };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type Stack");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Stack)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case StackOffset.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case StackOffset.Normalize:
                        serializer.Serialize(writer, "normalize");
                        return;
                    case StackOffset.Zero:
                        serializer.Serialize(writer, "zero");
                        return;
                }
            }
            throw new Exception("Cannot marshal type Stack");
        }

        public static readonly StackConverter Singleton = new StackConverter();
    }
}