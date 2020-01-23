﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class GridOpacityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridOpacity) || t == typeof(GridOpacity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new GridOpacity { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new GridOpacity { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridOpacity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridOpacity)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type GridOpacity");
        }

        public static readonly GridOpacityConverter Singleton = new GridOpacityConverter();
    }
}