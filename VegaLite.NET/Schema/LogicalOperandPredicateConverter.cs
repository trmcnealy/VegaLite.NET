using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LogicalOperandPredicateConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(LogicalOperandPredicate) || t == typeof(LogicalOperandPredicate?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new LogicalOperandPredicate
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    Predicate objectValue = serializer.Deserialize<Predicate>(reader);

                    return new LogicalOperandPredicate
                    {
                        Predicate = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type LogicalOperandPredicate");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            LogicalOperandPredicate value = (LogicalOperandPredicate)untypedValue;

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.Predicate != null)
            {
                serializer.Serialize(writer,
                                     value.Predicate);

                return;
            }

            throw new Exception("Cannot marshal type LogicalOperandPredicate");
        }

        public static readonly LogicalOperandPredicateConverter Singleton = new LogicalOperandPredicateConverter();
    }
}
