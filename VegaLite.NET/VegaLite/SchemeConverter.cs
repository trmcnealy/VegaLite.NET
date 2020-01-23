using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SchemeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Scheme) || t == typeof(Scheme?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Scheme { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SchemeParams>(reader);
                    return new Scheme { SchemeParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type Scheme");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Scheme)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.SchemeParams != null)
            {
                serializer.Serialize(writer, value.SchemeParams);
                return;
            }
            throw new Exception("Cannot marshal type Scheme");
        }

        public static readonly SchemeConverter Singleton = new SchemeConverter();
    }
}