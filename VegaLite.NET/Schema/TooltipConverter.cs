using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TooltipConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Tooltip) || t == typeof(Tooltip?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Null: return new Tooltip();
                case JsonToken.StartObject:
                    FieldDefWithConditionStringFieldDefString objectValue = serializer.Deserialize<FieldDefWithConditionStringFieldDefString>(reader);

                    return new Tooltip
                    {
                        FieldDefWithConditionStringFieldDefString = objectValue
                    };
                case JsonToken.StartArray:
                    List<StringFieldDef> arrayValue = serializer.Deserialize<List<StringFieldDef>>(reader);

                    return new Tooltip
                    {
                        StringFieldDefArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type Tooltip");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Tooltip value = (Tooltip)untypedValue;

            if(value.IsNull)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            if(value.StringFieldDefArray != null)
            {
                serializer.Serialize(writer,
                                     value.StringFieldDefArray);

                return;
            }

            if(value.FieldDefWithConditionStringFieldDefString != null)
            {
                serializer.Serialize(writer,
                                     value.FieldDefWithConditionStringFieldDefString);

                return;
            }

            throw new Exception("Cannot marshal type Tooltip");
        }

        public static readonly TooltipConverter Singleton = new TooltipConverter();
    }
}
