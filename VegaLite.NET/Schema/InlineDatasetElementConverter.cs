using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class InlineDatasetElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(InlineDatasetElement) || t == typeof(InlineDatasetElement?);
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

                    return new InlineDatasetElement
                    {
                        Double = doubleValue
                    };
                case JsonToken.Boolean:
                    bool boolValue = serializer.Deserialize<bool>(reader);

                    return new InlineDatasetElement
                    {
                        Bool = boolValue
                    };
                case JsonToken.String:
                case JsonToken.Date:
                    string stringValue = serializer.Deserialize<string>(reader);

                    return new InlineDatasetElement
                    {
                        String = stringValue
                    };
                case JsonToken.StartObject:
                    Dictionary<string, object> objectValue = serializer.Deserialize<Dictionary<string, object>>(reader);

                    return new InlineDatasetElement
                    {
                        AnythingMap = objectValue
                    };
            }

            throw new Exception("Cannot unmarshal type InlineDatasetElement");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            InlineDatasetElement value = (InlineDatasetElement)untypedValue;

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

            if(value.String != null)
            {
                serializer.Serialize(writer,
                                     value.String);

                return;
            }

            if(value.AnythingMap != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingMap);

                return;
            }

            throw new Exception("Cannot marshal type InlineDatasetElement");
        }

        public static readonly InlineDatasetElementConverter Singleton = new InlineDatasetElementConverter();
    }
}
