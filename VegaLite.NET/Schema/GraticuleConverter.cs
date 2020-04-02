using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class GraticuleConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Graticule) || t == typeof(Graticule?);
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

                    return new Graticule
                    {
                        Bool = boolValue
                    };
                case JsonToken.StartObject:
                    GraticuleParams objectValue = serializer.Deserialize<GraticuleParams>(reader);

                    return new Graticule
                    {
                        GraticuleParams = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type Graticule");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Graticule value = (Graticule)untypedValue;

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            if(value.GraticuleParams != null)
            {
                serializer.Serialize(writer,
                                     value.GraticuleParams);

                return;
            }

            throw new Exception("Cannot marshal type Graticule");
        }

        public static readonly GraticuleConverter Singleton = new GraticuleConverter();
    }
}
