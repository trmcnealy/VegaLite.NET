﻿using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ConditionalPredicateValueDefFontWeightNullValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalPredicateValueDefFontWeightNullValue) || t == typeof(ConditionalPredicateValueDefFontWeightNullValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ConditionalPredicateValueDefFontWeightNullValue { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ConditionalPredicateValueDefFontWeightNullValue { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bold":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Bold };
                        case "bolder":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Bolder };
                        case "lighter":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Lighter };
                        case "normal":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Normal };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type ConditionalPredicateValueDefFontWeightNullValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalPredicateValueDefFontWeightNullValue)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleFontWeight.Bold:
                        serializer.Serialize(writer, "bold");
                        return;
                    case PurpleFontWeight.Bolder:
                        serializer.Serialize(writer, "bolder");
                        return;
                    case PurpleFontWeight.Lighter:
                        serializer.Serialize(writer, "lighter");
                        return;
                    case PurpleFontWeight.Normal:
                        serializer.Serialize(writer, "normal");
                        return;
                }
            }
            throw new Exception("Cannot marshal type ConditionalPredicateValueDefFontWeightNullValue");
        }

        public static readonly ConditionalPredicateValueDefFontWeightNullValueConverter Singleton = new ConditionalPredicateValueDefFontWeightNullValueConverter();
    }
}