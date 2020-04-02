using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ShapeConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ShapeCondition) || t == typeof(ShapeCondition?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    ConditionalPredicateMarkPropFieldDefTypeForShapeClass objectValue = serializer.Deserialize<ConditionalPredicateMarkPropFieldDefTypeForShapeClass>(reader);

                    return new ShapeCondition
                    {
                        ConditionalPredicateMarkPropFieldDefTypeForShapeClass = objectValue
                    };
                case JsonToken.StartArray:
                    List<ConditionalStringValueDef> arrayValue = serializer.Deserialize<List<ConditionalStringValueDef>>(reader);

                    return new ShapeCondition
                    {
                        ConditionalStringValueDefArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type ShapeCondition");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ShapeCondition value = (ShapeCondition)untypedValue;

            if(value.ConditionalStringValueDefArray != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalStringValueDefArray);

                return;
            }

            if(value.ConditionalPredicateMarkPropFieldDefTypeForShapeClass != null)
            {
                serializer.Serialize(writer,
                                     value.ConditionalPredicateMarkPropFieldDefTypeForShapeClass);

                return;
            }

            throw new Exception("Cannot marshal type ShapeCondition");
        }

        public static readonly ShapeConditionConverter Singleton = new ShapeConditionConverter();
    }
}
