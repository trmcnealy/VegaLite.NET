﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LtConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Lt) || t == typeof(Lt?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Lt { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Lt { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new Lt { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type Lt");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Lt)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type Lt");
        }

        public static readonly LtConverter Singleton = new LtConverter();
    }
}