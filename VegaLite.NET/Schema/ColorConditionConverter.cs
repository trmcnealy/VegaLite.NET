using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ColorConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ColorCondition) || t == typeof(ColorCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefGradientStringNullClass objectValue = serializer.Deserialize<ConditionalPredicateValueDefGradientStringNullClass>(reader);

                    return new ColorCondition
                    {
                        ConditionalPredicateValueDefGradientStringNullClass = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalValueDefGradientStringNull> arrayValue = serializer.Deserialize<List<ConditionalValueDefGradientStringNull>>(reader);

                    return new ColorCondition
                    {
                        ConditionalValueDefGradientStringNullArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ColorCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ColorCondition value = (ColorCondition)untypedValue;

            if(value.ConditionalValueDefGradientStringNullArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalValueDefGradientStringNullArray);

                return;
            }

            if(value.ConditionalPredicateValueDefGradientStringNullClass != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefGradientStringNullClass);

                return;
            }

            throw new Exception("Cannot marshal type ColorCondition");
        }

        public static readonly ColorConditionConverter Singleton = new ColorConditionConverter();
    }
}
