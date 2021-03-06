﻿using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BottomCenterConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(BottomCenter) || t == typeof(BottomCenter?);
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

                    return new BottomCenter
                    {
                        Bool = boolValue
                    };
                case JsonToken.StartObject:
                    SignalRef objectValue = serializer.Deserialize<SignalRef>(reader);

                    return new BottomCenter
                    {
                        SignalRef = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type BottomCenter");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            BottomCenter value = (BottomCenter)untypedValue;

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.SignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.SignalRef);

                return;
            }

            throw new Exception("Cannot marshal type BottomCenter");
        }

        public static readonly BottomCenterConverter Singleton = new BottomCenterConverter();
    }
}
