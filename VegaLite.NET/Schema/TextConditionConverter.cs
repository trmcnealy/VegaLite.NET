using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TextConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(TextCondition) || t == typeof(TextCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateValueDefTextClass objectValue = serializer.Deserialize<ConditionalPredicateValueDefTextClass>(reader);

                    return new TextCondition
                    {
                        ConditionalPredicateValueDefTextClass = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalValueDefText> arrayValue = serializer.Deserialize<List<ConditionalValueDefText>>(reader);

                    return new TextCondition
                    {
                        ConditionalValueDefTextArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type TextCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            TextCondition value = (TextCondition)untypedValue;

            if(value.ConditionalValueDefTextArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalValueDefTextArray);

                return;
            }

            if(value.ConditionalPredicateValueDefTextClass != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateValueDefTextClass);

                return;
            }

            throw new Exception("Cannot marshal type TextCondition");
        }

        public static readonly TextConditionConverter Singleton = new TextConditionConverter();
    }
}
