using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BindUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(BindUnion) || t == typeof(BindUnion?);
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

                    switch(stringValue)
                    {
                        case "legend":
                            return new BindUnion
                            {
                                Enum = SelectionLegendBinding.Legend
                            };
                        case "scales":
                            return new BindUnion
                            {
                                Enum = SelectionLegendBinding.Scales
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    Dictionary<string, AnyStream> objectValue = serializer.Deserialize<Dictionary<string, AnyStream>>(reader);

                    return new BindUnion
                    {
                        AnythingMap = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type BindUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            BindUnion value = (BindUnion)untypedValue;

            if(value.Enum != null)
            {
                switch(value.Enum)
                {
                    case SelectionLegendBinding.Legend:
                        serializer.Serialize(writer,
                                             "legend");

                        return;
                    case SelectionLegendBinding.Scales:
                        serializer.Serialize(writer,
                                             "scales");

                        return;
                }
            }

            if(value.AnythingMap != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingMap);

                return;
            }

            throw new Exception("Cannot marshal type BindUnion");
        }

        public static readonly BindUnionConverter Singleton = new BindUnionConverter();
    }
}
