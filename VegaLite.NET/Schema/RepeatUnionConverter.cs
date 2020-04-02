using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RepeatUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RepeatUnion) || t == typeof(RepeatUnion?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    RepeatMapping objectValue = serializer.Deserialize<RepeatMapping>(reader);

                    return new RepeatUnion
                    {
                        RepeatMapping = objectValue
                    };
                case JsonToken.StartArray:
                    List<string> arrayValue = serializer.Deserialize<List<string>>(reader);

                    return new RepeatUnion
                    {
                        StringArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type RepeatUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            RepeatUnion value = (RepeatUnion)untypedValue;

            if(value.StringArray != null)
            {
                serializer.Serialize(writer,
                                     value.StringArray);

                return;
            }

            if(value.RepeatMapping != null)
            {
                serializer.Serialize(writer,
                                     value.RepeatMapping);

                return;
            }

            throw new Exception("Cannot marshal type RepeatUnion");
        }

        public static readonly RepeatUnionConverter Singleton = new RepeatUnionConverter();
    }
}
