using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ConditionalAxisPropertyColorNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ConditionalAxisPropertyColorNullCondition) || t == typeof(ConditionalAxisPropertyColorNullCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefColorNull objectValue = serializer.Deserialize<ConditionalPredicateValueDefColorNull>(reader);

                    return new ConditionalAxisPropertyColorNullCondition
                    {
                        ConditionalPredicateValueDefColorNull = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalPredicateValueDefColorNull> arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefColorNull>>(reader);

                    return new ConditionalAxisPropertyColorNullCondition
                    {
                        ConditionalPredicateValueDefColorNullArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyColorNullCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ConditionalAxisPropertyColorNullCondition value = (ConditionalAxisPropertyColorNullCondition)untypedValue;

            if(value.ConditionalPredicateValueDefColorNullArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefColorNullArray);

                return;
            }

            if(value.ConditionalPredicateValueDefColorNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefColorNull);

                return;
            }

            throw new Exception("Cannot marshal type ConditionalAxisPropertyColorNullCondition");
        }

        public static readonly ConditionalAxisPropertyColorNullConditionConverter Singleton = new ConditionalAxisPropertyColorNullConditionConverter();
    }
}
