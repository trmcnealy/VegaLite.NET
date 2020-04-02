using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Source) || t == typeof(Source?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "scope":  return Source.Scope;
                case "view":   return Source.View;
                case "window": return Source.Window;
            }

            throw new Exception("Cannot unmarshal type Source");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            Source value = (Source)untypedValue;

            switch(value)
            {
                case Source.Scope:
                    serializer.Serialize(writer,
                                         "scope");

                    return;
                case Source.View:
                    serializer.Serialize(writer,
                                         "view");

                    return;
                case Source.Window:
                    serializer.Serialize(writer,
                                         "window");

                    return;
            }

            throw new Exception("Cannot marshal type Source");
        }

        public static readonly SourceConverter Singleton = new SourceConverter();
    }
}
