using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class TypeForShapeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeForShape) || t == typeof(TypeForShape?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "geojson":
                    return TypeForShape.Geojson;
                case "nominal":
                    return TypeForShape.Nominal;
                case "ordinal":
                    return TypeForShape.Ordinal;
            }
            throw new Exception("Cannot unmarshal type TypeForShape");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeForShape)untypedValue;
            switch (value)
            {
                case TypeForShape.Geojson:
                    serializer.Serialize(writer, "geojson");
                    return;
                case TypeForShape.Nominal:
                    serializer.Serialize(writer, "nominal");
                    return;
                case TypeForShape.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
            }
            throw new Exception("Cannot marshal type TypeForShape");
        }

        public static readonly TypeForShapeConverter Singleton = new TypeForShapeConverter();
    }
}