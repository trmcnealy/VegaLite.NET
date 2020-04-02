using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class PurpleTextConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(PurpleText) || t == typeof(PurpleText?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new PurpleText();
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new PurpleText
                    {
                        String = stringValue
                    };
                case JsonToken.StartArray:
                    List<string> arrayValue = serializer.Deserialize<List<string>>(reader);

                    return new PurpleText
                    {
                        StringArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type PurpleText");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            PurpleText value = (PurpleText)untypedValue;

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

            if(value.StringArray != null)
            {
                serializer.Serialize(writer,
                                     value.StringArray);

                return;
            }

            throw new Exception("Cannot marshal type PurpleText");
        }

        public static readonly PurpleTextConverter Singleton = new PurpleTextConverter();
    }
}
