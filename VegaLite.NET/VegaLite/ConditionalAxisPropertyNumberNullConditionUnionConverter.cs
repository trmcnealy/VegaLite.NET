using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ConditionalAxisPropertyNumberNullConditionUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyNumberNullConditionUnion) || t == typeof(ConditionalAxisPropertyNumberNullConditionUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefNumberNullElement>(reader);
                    return new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElement = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefNumberNullElement>>(reader);
                    return new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyNumberNullConditionUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyNumberNullConditionUnion)untypedValue;
            if (value.ConditionalPredicateValueDefNumberNullElementArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefNumberNullElementArray);
                return;
            }
            if (value.ConditionalPredicateValueDefNumberNullElement != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefNumberNullElement);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyNumberNullConditionUnion");
        }

        public static readonly ConditionalAxisPropertyNumberNullConditionUnionConverter Singleton = new ConditionalAxisPropertyNumberNullConditionUnionConverter();
    }
}