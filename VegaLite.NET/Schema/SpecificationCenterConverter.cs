using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SpecificationCenterConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(SpecificationCenter) || t == typeof(SpecificationCenter?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            switch(reader.TokenType)
            {
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new SpecificationCenter
                    {
                        Bool = boolValue
                    };
                case JsonToken.StartObject:
                    RowColBoolean objectValue = serializer.Deserialize<RowColBoolean>(reader);

                    return new SpecificationCenter
                    {
                        RowColBoolean = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type SpecificationCenter");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            SpecificationCenter value = (SpecificationCenter)untypedValue;

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.RowColBoolean != null)
            {
                serializer.Serialize(writer,
                                     value.RowColBoolean);

                return;
            }

            throw new Exception("Cannot marshal type SpecificationCenter");
        }

        public static readonly SpecificationCenterConverter Singleton = new SpecificationCenterConverter();
    }
}
