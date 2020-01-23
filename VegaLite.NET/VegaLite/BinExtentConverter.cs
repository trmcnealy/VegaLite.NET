using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BinExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BinExtent) || t == typeof(BinExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinExtentClass>(reader);
                    return new BinExtent { BinExtentClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<double>>(reader);
                    return new BinExtent { DoubleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type BinExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BinExtent)untypedValue;
            if (value.DoubleArray != null)
            {
                serializer.Serialize(writer, value.DoubleArray);
                return;
            }
            if (value.BinExtentClass != null)
            {
                serializer.Serialize(writer, value.BinExtentClass);
                return;
            }
            throw new Exception("Cannot marshal type BinExtent");
        }

        public static readonly BinExtentConverter Singleton = new BinExtentConverter();
    }
}