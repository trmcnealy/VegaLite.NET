using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ConditionalAxisPropertyNumberNullConditionUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ConditionalAxisPropertyNumberNullConditionUnion) || t == typeof(ConditionalAxisPropertyNumberNullConditionUnion?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefNumberNullElement objectValue = serializer.Deserialize<ConditionalPredicateValueDefNumberNullElement>(reader);

                    return new ConditionalAxisPropertyNumberNullConditionUnion
                    {
                        ConditionalPredicateValueDefNumberNullElement = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalPredicateValueDefNumberNullElement> arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefNumberNullElement>>(reader);

                    return new ConditionalAxisPropertyNumberNullConditionUnion
                    {
                        ConditionalPredicateValueDefNumberNullElementArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyNumberNullConditionUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ConditionalAxisPropertyNumberNullConditionUnion value = (ConditionalAxisPropertyNumberNullConditionUnion)untypedValue;

            if(value.ConditionalPredicateValueDefNumberNullElementArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefNumberNullElementArray);

                return;
            }

            if(value.ConditionalPredicateValueDefNumberNullElement != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefNumberNullElement);

                return;
            }

            throw new Exception("Cannot marshal type ConditionalAxisPropertyNumberNullConditionUnion");
        }

        public static readonly ConditionalAxisPropertyNumberNullConditionUnionConverter Singleton = new ConditionalAxisPropertyNumberNullConditionUnionConverter();
    }
}
