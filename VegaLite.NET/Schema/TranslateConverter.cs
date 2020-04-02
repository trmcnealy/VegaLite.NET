using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TranslateConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Translate) || t == typeof(Translate?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new Translate
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new Translate
                    {
                        String = stringValue
                    };
            }

            throw new Exception("Cannot unmarshal type Translate");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Translate value = (Translate)untypedValue;

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            throw new Exception("Cannot marshal type Translate");
        }

        public static readonly TranslateConverter Singleton = new TranslateConverter();
    }
}
