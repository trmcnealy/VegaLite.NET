using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class DashConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dash) || t == typeof(Dash?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNull>(reader);
                    return new Dash { ConditionalAxisPropertyNumberNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<double>>(reader);
                    return new Dash { DoubleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Dash");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Dash)untypedValue;
            if (value.DoubleArray != null)
            {
                serializer.Serialize(writer, value.DoubleArray);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNull);
                return;
            }
            throw new Exception("Cannot marshal type Dash");
        }

        public static readonly DashConverter Singleton = new DashConverter();
    }
}