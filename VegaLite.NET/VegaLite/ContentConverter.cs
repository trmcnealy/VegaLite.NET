using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Content) || t == typeof(Content?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "data":
                    return Content.Data;
                case "encoding":
                    return Content.Encoding;
            }
            throw new Exception("Cannot unmarshal type Content");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Content)untypedValue;
            switch (value)
            {
                case Content.Data:
                    serializer.Serialize(writer, "data");
                    return;
                case Content.Encoding:
                    serializer.Serialize(writer, "encoding");
                    return;
            }
            throw new Exception("Cannot marshal type Content");
        }

        public static readonly ContentConverter Singleton = new ContentConverter();
    }
}