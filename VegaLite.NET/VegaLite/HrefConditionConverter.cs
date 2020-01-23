﻿using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class HrefConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HrefCondition) || t == typeof(HrefCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefStringClass>(reader);
                    return new HrefCondition { ConditionalPredicateValueDefStringClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionElement>>(reader);
                    return new HrefCondition { ConditionElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type HrefCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HrefCondition)untypedValue;
            if (value.ConditionElementArray != null)
            {
                serializer.Serialize(writer, value.ConditionElementArray);
                return;
            }
            if (value.ConditionalPredicateValueDefStringClass != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefStringClass);
                return;
            }
            throw new Exception("Cannot marshal type HrefCondition");
        }

        public static readonly HrefConditionConverter Singleton = new HrefConditionConverter();
    }
}