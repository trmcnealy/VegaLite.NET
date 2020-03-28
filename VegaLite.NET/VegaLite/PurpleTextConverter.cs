using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class PurpleTextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleText) || t == typeof(PurpleText?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new PurpleText();
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new PurpleText { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new PurpleText { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleText");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleText)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type PurpleText");
        }

        public static readonly PurpleTextConverter Singleton = new PurpleTextConverter();
    }
}