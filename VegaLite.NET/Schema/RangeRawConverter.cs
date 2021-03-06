﻿using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class RangeRawConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(RangeRaw) || t == typeof(RangeRaw?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new RangeRaw();
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new RangeRaw
                    {
                        Double = doubleValue
                    };
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new RangeRaw
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new RangeRaw
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    SignalRef objectValue = serializer.Deserialize<SignalRef>(reader);

                    return new RangeRaw
                    {
                        SignalRef = objectValue
                    };
                case JsonToken.StartArray:
                    List<RangeRawArray> arrayValue = serializer.Deserialize<List<RangeRawArray>>(reader);

                    return new RangeRaw
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type RangeRaw");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            RangeRaw value = (RangeRaw)untypedValue;

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

            if(value.SignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.SignalRef);

                return;
            }

            throw new Exception("Cannot marshal type RangeRaw");
        }

        public static readonly RangeRawConverter Singleton = new RangeRawConverter();
    }
}
