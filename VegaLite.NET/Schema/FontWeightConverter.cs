﻿using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class FontWeightConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(FontWeight) || t == typeof(FontWeight?);
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

                    return new FontWeight
                    {
                        Double = doubleValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    switch(stringValue)
                    {
                        case "bold":
                            return new FontWeight
                            {
                                Enum = FontWeightEnum.Bold
                            };
                        case "bolder":
                            return new FontWeight
                            {
                                Enum = FontWeightEnum.Bolder
                            };
                        case "lighter":
                            return new FontWeight
                            {
                                Enum = FontWeightEnum.Lighter
                            };
                        case "normal":
                            return new FontWeight
                            {
                                Enum = FontWeightEnum.Normal
                            };
                    }

                    break;
            }

            throw new Exception("Cannot unmarshal type FontWeight");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            FontWeight value = (FontWeight)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.Enum != null)
            {
                switch(value.Enum)
                {
                    case FontWeightEnum.Bold:
                        serializer.Serialize(writer,
                                             "bold");

                        return;
                    case FontWeightEnum.Bolder:
                        serializer.Serialize(writer,
                                             "bolder");

                        return;
                    case FontWeightEnum.Lighter:
                        serializer.Serialize(writer,
                                             "lighter");

                        return;
                    case FontWeightEnum.Normal:
                        serializer.Serialize(writer,
                                             "normal");

                        return;
                }
            }

            throw new Exception("Cannot marshal type FontWeight");
        }

        public static readonly FontWeightConverter Singleton = new FontWeightConverter();
    }
}
