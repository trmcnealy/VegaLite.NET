using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RepeatEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RepeatEnum) || t == typeof(RepeatEnum?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "column": return RepeatEnum.Column;
                case "repeat": return RepeatEnum.Repeat;
                case "row":    return RepeatEnum.Row;
            }

            throw new Exception("Cannot unmarshal type RepeatEnum");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            RepeatEnum value = (RepeatEnum)untypedValue;

            switch(value)
            {
                case RepeatEnum.Column:
                    serializer.Serialize(writer,
                                         "column");

                    return;
                case RepeatEnum.Repeat:
                    serializer.Serialize(writer,
                                         "repeat");

                    return;
                case RepeatEnum.Row:
                    serializer.Serialize(writer,
                                         "row");

                    return;
            }

            throw new Exception("Cannot marshal type RepeatEnum");
        }

        public static readonly RepeatEnumConverter Singleton = new RepeatEnumConverter();
    }
}
