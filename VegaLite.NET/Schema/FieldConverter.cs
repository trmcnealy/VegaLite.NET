using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class FieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Field) || t == typeof(Field?);
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

                    return new Field
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    RepeatRef objectValue = serializer.Deserialize<RepeatRef>(reader);

                    return new Field
                    {
                        RepeatRef = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Field");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Field value = (Field)untypedValue;

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.RepeatRef != null)
            {
                serializer.Serialize(writer,
                                     value.RepeatRef);

                return;
            }

            throw new Exception("Cannot marshal type Field");
        }

        public static readonly FieldConverter Singleton = new FieldConverter();
    }
}
