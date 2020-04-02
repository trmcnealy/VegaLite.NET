using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ColorSchemeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ColorScheme) || t == typeof(ColorScheme?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new ColorScheme
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    SignalRef objectValue = serializer.Deserialize<SignalRef>(reader);

                    return new ColorScheme
                    {
                        SignalRef = objectValue
                    };
                case JsonToken.StartArray:
                    List<string> arrayValue = serializer.Deserialize<List<string>>(reader);

                    return new ColorScheme
                    {
                        StringArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ColorScheme");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ColorScheme value = (ColorScheme)untypedValue;

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.StringArray != null)
            {
                serializer.Serialize(writer,
                                     value.StringArray);

                return;
            }

            if(value.SignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.SignalRef);

                return;
            }

            throw new Exception("Cannot marshal type ColorScheme");
        }

        public static readonly ColorSchemeConverter Singleton = new ColorSchemeConverter();
    }
}
