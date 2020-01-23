using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ClearUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClearUnion) || t == typeof(ClearUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ClearUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ClearUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ClearDerivedStream>(reader);
                    return new ClearUnion { ClearDerivedStream = objectValue };
            }
            throw new Exception("Cannot unmarshal type ClearUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ClearUnion)untypedValue;
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
            if (value.ClearDerivedStream != null)
            {
                serializer.Serialize(writer, value.ClearDerivedStream);
                return;
            }
            throw new Exception("Cannot marshal type ClearUnion");
        }

        public static readonly ClearUnionConverter Singleton = new ClearUnionConverter();
    }
}