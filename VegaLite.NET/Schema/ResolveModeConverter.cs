using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class ResolveModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ResolveMode) || t == typeof(ResolveMode?);
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
                case "independent": return ResolveMode.Independent;
                case "shared":      return ResolveMode.Shared;
            }

            throw new Exception("Cannot unmarshal type ResolveMode");
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

            ResolveMode value = (ResolveMode)untypedValue;

            switch(value)
            {
                case ResolveMode.Independent:
                    serializer.Serialize(writer,
                                         "independent");

                    return;
                case ResolveMode.Shared:
                    serializer.Serialize(writer,
                                         "shared");

                    return;
            }

            throw new Exception("Cannot marshal type ResolveMode");
        }

        public static readonly ResolveModeConverter Singleton = new ResolveModeConverter();
    }
}
