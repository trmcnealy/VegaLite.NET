using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class TransformBinConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(TransformBin) || t == typeof(TransformBin?);
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

                    return new TransformBin
                    {
                        Bool = boolValue
                    };
                case JsonToken.StartObject:
                    BinParams objectValue = serializer.Deserialize<BinParams>(reader);

                    return new TransformBin
                    {
                        BinParams = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type TransformBin");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            TransformBin value = (TransformBin)untypedValue;

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.BinParams != null)
            {
                serializer.Serialize(writer,
                                     value.BinParams);

                return;
            }

            throw new Exception("Cannot marshal type TransformBin");
        }

        public static readonly TransformBinConverter Singleton = new TransformBinConverter();
    }
}
