using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class InitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Init) || t == typeof(Init?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, InitValue>>(reader);
                    return new Init { AnythingMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Dictionary<string, SelectionInit>>>(reader);
                    return new Init { AnythingMapArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Init");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Init)untypedValue;
            if (value.AnythingMapArray != null)
            {
                serializer.Serialize(writer, value.AnythingMapArray);
                return;
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type Init");
        }

        public static readonly InitConverter Singleton = new InitConverter();
    }
}