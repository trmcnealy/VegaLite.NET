using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SelectionInitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionInit) || t == typeof(SelectionInit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new SelectionInit();
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new SelectionInit { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new SelectionInit { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new SelectionInit { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new SelectionInit { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type SelectionInit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SelectionInit)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type SelectionInit");
        }

        public static readonly SelectionInitConverter Singleton = new SelectionInitConverter();
    }
}