using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Binding) || t == typeof(Binding?);
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

                    if(stringValue == "legend")
                    {
                        return new Binding
                        {
                            Enum = LegendBindingEnum.Legend
                        };
                    }

                    break;
                case JsonToken.StartObject:
                    Dictionary<string, AnyStream> objectValue = serializer.Deserialize<Dictionary<string, AnyStream>>(reader);

                    return new Binding
                    {
                        AnythingMap = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Binding");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Binding value = (Binding)untypedValue;

            if(value.Enum != null)
            {
                if(value.Enum == LegendBindingEnum.Legend)
                {
                    serializer.Serialize(writer,
                                         "legend");

                    return;
                }
            }

            if(value.AnythingMap != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingMap);

                return;
            }

            throw new Exception("Cannot marshal type Binding");
        }

        public static readonly BindingConverter Singleton = new BindingConverter();
    }
}
