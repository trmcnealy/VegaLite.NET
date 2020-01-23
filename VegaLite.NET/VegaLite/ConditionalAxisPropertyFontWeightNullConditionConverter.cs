using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ConditionalAxisPropertyFontWeightNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyFontWeightNullCondition) || t == typeof(ConditionalAxisPropertyFontWeightNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefFontWeightNull>(reader);
                    return new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefFontWeightNull>>(reader);
                    return new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyFontWeightNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyFontWeightNullCondition)untypedValue;
            if (value.ConditionalPredicateValueDefFontWeightNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefFontWeightNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefFontWeightNull != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefFontWeightNull);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyFontWeightNullCondition");
        }

        public static readonly ConditionalAxisPropertyFontWeightNullConditionConverter Singleton = new ConditionalAxisPropertyFontWeightNullConditionConverter();
    }
}