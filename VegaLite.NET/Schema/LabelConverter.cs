using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class LabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Label) || t == typeof(Label?);
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

                    return new Label
                    {
                        Double = doubleValue
                    };
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new Label
                    {
                        Bool = boolValue
                    };
            }

            throw new Exception("Cannot unmarshal type Label");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            Label value = (Label)untypedValue;

            if(value.Double != null)
            {
                serializer.Serialize(writer,
                                     value.Double.Value);

                return;
            }

            if(value.Bool != null)
            {
                serializer.Serialize(writer,
                                     value.Bool.Value);

                return;
            }

            throw new Exception("Cannot marshal type Label");
        }

        public static readonly LabelConverter Singleton = new LabelConverter();
    }
}
