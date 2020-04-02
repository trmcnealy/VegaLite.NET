using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ValueUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ValueUnion) || t == typeof(ValueUnion?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new ValueUnion();
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new ValueUnion
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    ValueLinearGradient objectValue = serializer.Deserialize<ValueLinearGradient>(reader);

                    return new ValueUnion
                    {
                        ValueLinearGradient = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type ValueUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            ValueUnion value = (ValueUnion)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.ValueLinearGradient != null)
            {
                serializer.Serialize(writer,
                                     value.ValueLinearGradient);

                return;
            }

            throw new Exception("Cannot marshal type ValueUnion");
        }

        public static readonly ValueUnionConverter Singleton = new ValueUnionConverter();
    }
}
