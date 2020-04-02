using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class OnUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(OnUnion) || t == typeof(OnUnion?);
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

                    return new OnUnion
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    OnDerivedStream objectValue = serializer.Deserialize<OnDerivedStream>(reader);

                    return new OnUnion
                    {
                        OnDerivedStream = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type OnUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            OnUnion value = (OnUnion)untypedValue;

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.OnDerivedStream != null)
            {
                serializer.Serialize(writer,
                                     value.OnDerivedStream);

                return;
            }

            throw new Exception("Cannot marshal type OnUnion");
        }

        public static readonly OnUnionConverter Singleton = new OnUnionConverter();
    }
}
