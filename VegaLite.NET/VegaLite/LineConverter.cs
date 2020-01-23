﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class LineConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Line) || t == typeof(Line?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Line { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OverlayMarkDef>(reader);
                    return new Line { OverlayMarkDef = objectValue };
            }
            throw new Exception("Cannot unmarshal type Line");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Line)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.OverlayMarkDef != null)
            {
                serializer.Serialize(writer, value.OverlayMarkDef);
                return;
            }
            throw new Exception("Cannot marshal type Line");
        }

        public static readonly LineConverter Singleton = new LineConverter();
    }
}