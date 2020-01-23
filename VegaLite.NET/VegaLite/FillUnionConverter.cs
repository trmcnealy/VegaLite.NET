﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class FillUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FillUnion) || t == typeof(FillUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FillUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new FillUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FillLinearGradient>(reader);
                    return new FillUnion { FillLinearGradient = objectValue };
            }
            throw new Exception("Cannot unmarshal type FillUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FillUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.FillLinearGradient != null)
            {
                serializer.Serialize(writer, value.FillLinearGradient);
                return;
            }
            throw new Exception("Cannot marshal type FillUnion");
        }

        public static readonly FillUnionConverter Singleton = new FillUnionConverter();
    }
}