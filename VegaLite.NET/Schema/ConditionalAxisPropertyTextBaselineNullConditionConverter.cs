﻿using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ConditionalAxisPropertyTextBaselineNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ConditionalAxisPropertyTextBaselineNullCondition) || t == typeof(ConditionalAxisPropertyTextBaselineNullCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefTextBaselineNull objectValue = serializer.Deserialize<ConditionalPredicateValueDefTextBaselineNull>(reader);

                    return new ConditionalAxisPropertyTextBaselineNullCondition
                    {
                        ConditionalPredicateValueDefTextBaselineNull = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalPredicateValueDefTextBaselineNull> arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefTextBaselineNull>>(reader);

                    return new ConditionalAxisPropertyTextBaselineNullCondition
                    {
                        ConditionalPredicateValueDefTextBaselineNullArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyTextBaselineNullCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ConditionalAxisPropertyTextBaselineNullCondition value = (ConditionalAxisPropertyTextBaselineNullCondition)untypedValue;

            if(value.ConditionalPredicateValueDefTextBaselineNullArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefTextBaselineNullArray);

                return;
            }

            if(value.ConditionalPredicateValueDefTextBaselineNull != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefTextBaselineNull);

                return;
            }

            throw new Exception("Cannot marshal type ConditionalAxisPropertyTextBaselineNullCondition");
        }

        public static readonly ConditionalAxisPropertyTextBaselineNullConditionConverter Singleton = new ConditionalAxisPropertyTextBaselineNullConditionConverter();
    }
}
