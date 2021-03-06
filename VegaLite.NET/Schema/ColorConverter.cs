﻿using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ColorConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Color) || t == typeof(Color?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new Color();
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new Color
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    ConditionalAxisPropertyColorNull objectValue = serializer.Deserialize<ConditionalAxisPropertyColorNull>(reader);

                    return new Color
                    {
                        ConditionalAxisPropertyColorNull = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Color");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Color value = (Color)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.ConditionalAxisPropertyColorNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalAxisPropertyColorNull);

                return;
            }

            throw new Exception("Cannot marshal type Color");
        }

        public static readonly ColorConverter Singleton = new ColorConverter();
    }
}
