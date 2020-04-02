using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class DetailConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Detail) || t == typeof(Detail?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.StartObject:
                    TypedFieldDef objectValue = serializer.Deserialize<TypedFieldDef>(reader);

                    return new Detail
                    {
                        TypedFieldDef = objectValue
                    };
                case JsonToken.StartArray:
                    List<TypedFieldDef> arrayValue = serializer.Deserialize<List<TypedFieldDef>>(reader);

                    return new Detail
                    {
                        TypedFieldDefArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type Detail");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Detail value = (Detail)untypedValue;

            if(value.TypedFieldDefArray != null)
            {
                serializer.Serialize(writer,
                                     value.TypedFieldDefArray);

                return;
            }

            if(value.TypedFieldDef != null)
            {
                serializer.Serialize(writer,
                                     value.TypedFieldDef);

                return;
            }

            throw new Exception("Cannot marshal type Detail");
        }

        public static readonly DetailConverter Singleton = new DetailConverter();
    }
}
