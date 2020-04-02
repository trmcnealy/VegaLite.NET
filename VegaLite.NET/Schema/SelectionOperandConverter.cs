using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SelectionOperandConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(SelectionOperand) || t == typeof(SelectionOperand?);
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

                    return new SelectionOperand
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    Selection objectValue = serializer.Deserialize<Selection>(reader);

                    return new SelectionOperand
                    {
                        Selection = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type SelectionOperand");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            SelectionOperand value = (SelectionOperand)untypedValue;

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.Selection != null)
            {
                serializer.Serialize(writer,
                                     value.Selection);

                return;
            }

            throw new Exception("Cannot marshal type SelectionOperand");
        }

        public static readonly SelectionOperandConverter Singleton = new SelectionOperandConverter();
    }
}
