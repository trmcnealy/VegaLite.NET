﻿using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class TextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Text) || t == typeof(Text?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Text { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new Text { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Text");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Text)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type Text");
        }

        public static readonly TextConverter Singleton = new TextConverter();
    }
}