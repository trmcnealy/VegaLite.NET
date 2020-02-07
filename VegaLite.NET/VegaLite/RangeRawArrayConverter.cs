﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class RangeRawArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeRawArray) || t == typeof(RangeRawArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new RangeRawArray { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new RangeRawArray { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type RangeRawArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeRawArray)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type RangeRawArray");
        }

        public static readonly RangeRawArrayConverter Singleton = new RangeRawArrayConverter();
    }
}