using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class InitValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(InitValue) || t == typeof(InitValue?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new InitValue();
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new InitValue
                    {
                        Double = doubleValue
                    };
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new InitValue
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new InitValue
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    DateTime objectValue = serializer.Deserialize<DateTime>(reader);

                    return new InitValue
                    {
                        DateTime = objectValue
                    };
                case JsonToken.StartArray:
                    List<Equal> arrayValue = serializer.Deserialize<List<Equal>>(reader);

                    return new InitValue
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type InitValue");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            InitValue value = (InitValue)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

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

            if(value.AnythingArray != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingArray);

                return;
            }

            if(value.DateTime != null)
            {
                serializer.Serialize(writer,
                                     value.DateTime);

                return;
            }

            throw new Exception("Cannot marshal type InitValue");
        }

        public static readonly InitValueConverter Singleton = new InitValueConverter();
    }
}
