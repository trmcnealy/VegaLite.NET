using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class KeyvalsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Keyvals) || t == typeof(Keyvals?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ImputeSequence>(reader);
                    return new Keyvals { ImputeSequence = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new Keyvals { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Keyvals");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Keyvals)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.ImputeSequence != null)
            {
                serializer.Serialize(writer, value.ImputeSequence);
                return;
            }
            throw new Exception("Cannot marshal type Keyvals");
        }

        public static readonly KeyvalsConverter Singleton = new KeyvalsConverter();
    }
}