using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ConditionalAxisPropertyFontStyleNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ConditionalAxisPropertyFontStyleNullCondition) || t == typeof(ConditionalAxisPropertyFontStyleNullCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefFontStyleNull objectValue = serializer.Deserialize<ConditionalPredicateValueDefFontStyleNull>(reader);

                    return new ConditionalAxisPropertyFontStyleNullCondition
                    {
                        ConditionalPredicateValueDefFontStyleNull = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalPredicateValueDefFontStyleNull> arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefFontStyleNull>>(reader);

                    return new ConditionalAxisPropertyFontStyleNullCondition
                    {
                        ConditionalPredicateValueDefFontStyleNullArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyFontStyleNullCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ConditionalAxisPropertyFontStyleNullCondition value = (ConditionalAxisPropertyFontStyleNullCondition)untypedValue;

            if(value.ConditionalPredicateValueDefFontStyleNullArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefFontStyleNullArray);

                return;
            }

            if(value.ConditionalPredicateValueDefFontStyleNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefFontStyleNull);

                return;
            }

            throw new Exception("Cannot marshal type ConditionalAxisPropertyFontStyleNullCondition");
        }

        public static readonly ConditionalAxisPropertyFontStyleNullConditionConverter Singleton = new ConditionalAxisPropertyFontStyleNullConditionConverter();
    }
}
