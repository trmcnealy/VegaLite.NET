using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class BoxplotExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(BoxplotExtent) || t == typeof(BoxplotExtent?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    double doubleValue = serializer.Deserialize<double>(reader);

                    return new BoxplotExtent
                    {
                        Double = doubleValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    if(stringValue == "min-max")
                    {
                        return new BoxplotExtent
                        {
                            Enum = ExtentEnum.MinMax
                        };
                    }

                    break;
            }

            throw new Exception("Cannot unmarshal type BoxplotExtent");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            BoxplotExtent value = (BoxplotExtent)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.Enum != null)
            {
                if(value.Enum == ExtentEnum.MinMax)
                {
                    serializer.Serialize(writer,
                                         "min-max");

                    return;
                }
            }

            throw new Exception("Cannot marshal type BoxplotExtent");
        }

        public static readonly BoxplotExtentConverter Singleton = new BoxplotExtentConverter();
    }
}
