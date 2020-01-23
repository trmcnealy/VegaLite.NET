﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class InvalidConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Invalid) || t == typeof(Invalid?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "filter")
            {
                return Invalid.Filter;
            }
            throw new Exception("Cannot unmarshal type Invalid");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Invalid)untypedValue;
            if (value == Invalid.Filter)
            {
                serializer.Serialize(writer, "filter");
                return;
            }
            throw new Exception("Cannot marshal type Invalid");
        }

        public static readonly InvalidConverter Singleton = new InvalidConverter();
    }
}