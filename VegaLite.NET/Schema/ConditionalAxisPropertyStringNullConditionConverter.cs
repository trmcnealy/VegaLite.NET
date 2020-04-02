using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ConditionalAxisPropertyStringNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ConditionalAxisPropertyStringNullCondition) || t == typeof(ConditionalAxisPropertyStringNullCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateStringValueDef objectValue = serializer.Deserialize<ConditionalPredicateStringValueDef>(reader);

                    return new ConditionalAxisPropertyStringNullCondition
                    {
                        ConditionalPredicateStringValueDef = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalPredicateStringValueDef> arrayValue = serializer.Deserialize<List<ConditionalPredicateStringValueDef>>(reader);

                    return new ConditionalAxisPropertyStringNullCondition
                    {
                        ConditionalPredicateStringValueDefArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyStringNullCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ConditionalAxisPropertyStringNullCondition value = (ConditionalAxisPropertyStringNullCondition)untypedValue;

            if(value.ConditionalPredicateStringValueDefArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateStringValueDefArray);

                return;
            }

            if(value.ConditionalPredicateStringValueDef != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateStringValueDef);

                return;
            }

            throw new Exception("Cannot marshal type ConditionalAxisPropertyStringNullCondition");
        }

        public static readonly ConditionalAxisPropertyStringNullConditionConverter Singleton = new ConditionalAxisPropertyStringNullConditionConverter();
    }
}
