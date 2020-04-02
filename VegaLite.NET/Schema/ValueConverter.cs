using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Value) || t == typeof(Value?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new Value();
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new Value
                    {
                        Double = doubleValue
                    };
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new Value
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new Value
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    TooltipContent objectValue = serializer.Deserialize<TooltipContent>(reader);

                    return new Value
                    {
                        TooltipContent = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Value");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Value value = (Value)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.TooltipContent != null)
            {
                serializer.Serialize(writer,
                                     value.TooltipContent);

                return;
            }

            throw new Exception("Cannot marshal type Value");
        }

        public static readonly ValueConverter Singleton = new ValueConverter();
    }
}
