using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ConditionalAxisPropertyNumberNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ConditionalAxisPropertyNumberNullCondition) || t == typeof(ConditionalAxisPropertyNumberNullCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefNumberNull objectValue = serializer.Deserialize<ConditionalPredicateValueDefNumberNull>(reader);

                    return new ConditionalAxisPropertyNumberNullCondition
                    {
                        ConditionalPredicateValueDefNumberNull = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalPredicateValueDefNumberNull> arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefNumberNull>>(reader);

                    return new ConditionalAxisPropertyNumberNullCondition
                    {
                        ConditionalPredicateValueDefNumberNullArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyNumberNullCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ConditionalAxisPropertyNumberNullCondition value = (ConditionalAxisPropertyNumberNullCondition)untypedValue;

            if(value.ConditionalPredicateValueDefNumberNullArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefNumberNullArray);

                return;
            }

            if(value.ConditionalPredicateValueDefNumberNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefNumberNull);

                return;
            }

            throw new Exception("Cannot marshal type ConditionalAxisPropertyNumberNullCondition");
        }

        public static readonly ConditionalAxisPropertyNumberNullConditionConverter Singleton = new ConditionalAxisPropertyNumberNullConditionConverter();
    }
}
