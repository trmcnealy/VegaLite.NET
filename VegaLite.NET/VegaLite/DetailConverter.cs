using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class DetailConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Detail) || t == typeof(Detail?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TypedFieldDef>(reader);
                    return new Detail { TypedFieldDef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TypedFieldDef>>(reader);
                    return new Detail { TypedFieldDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Detail");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Detail)untypedValue;
            if (value.TypedFieldDefArray != null)
            {
                serializer.Serialize(writer, value.TypedFieldDefArray);
                return;
            }
            if (value.TypedFieldDef != null)
            {
                serializer.Serialize(writer, value.TypedFieldDef);
                return;
            }
            throw new Exception("Cannot marshal type Detail");
        }

        public static readonly DetailConverter Singleton = new DetailConverter();
    }
}