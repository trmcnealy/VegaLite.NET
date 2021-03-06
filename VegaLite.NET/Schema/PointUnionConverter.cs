﻿using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class PointUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(PointUnion) || t == typeof(PointUnion?);
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

                    return new PointUnion
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    if(stringValue == "transparent")
                    {
                        return new PointUnion
                        {
                            Enum = PointEnum.Transparent
                        };
                    }

                    break;
                case JsonToken.StartObject:
                    OverlayMarkDef objectValue = serializer.Deserialize<OverlayMarkDef>(reader);

                    return new PointUnion
                    {
                        OverlayMarkDef = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type PointUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            PointUnion value = (PointUnion)untypedValue;

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.Enum != null)
            {
                if(value.Enum == PointEnum.Transparent)
                {
                    serializer.Serialize(writer,
                                         "transparent");

                    return;
                }
            }

            if(value.OverlayMarkDef != null)
            {
                serializer.Serialize(writer,
                                     value.OverlayMarkDef);

                return;
            }

            throw new Exception("Cannot marshal type PointUnion");
        }

        public static readonly PointUnionConverter Singleton = new PointUnionConverter();
    }
}
