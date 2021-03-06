﻿using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class EqualConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Equal) || t == typeof(Equal?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new Equal
                    {
                        Double = doubleValue
                    };
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new Equal
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new Equal
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    DateTime objectValue = serializer.Deserialize<DateTime>(reader);

                    return new Equal
                    {
                        DateTime = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Equal");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Equal value = (Equal)untypedValue;

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

            if(value.DateTime != null)
            {
                serializer.Serialize(writer,
                                     value.DateTime);

                return;
            }

            throw new Exception("Cannot marshal type Equal");
        }

        public static readonly EqualConverter Singleton = new EqualConverter();
    }
}
