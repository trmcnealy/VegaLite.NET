using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SphereUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SphereUnion) || t == typeof(SphereUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new SphereUnion { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SphereClass>(reader);
                    return new SphereUnion { SphereClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type SphereUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SphereUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.SphereClass != null)
            {
                serializer.Serialize(writer, value.SphereClass);
                return;
            }
            throw new Exception("Cannot marshal type SphereUnion");
        }

        public static readonly SphereUnionConverter Singleton = new SphereUnionConverter();
    }
}