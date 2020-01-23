using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class SelectionResolutionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionResolution) || t == typeof(SelectionResolution?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "global":
                    return SelectionResolution.Global;
                case "intersect":
                    return SelectionResolution.Intersect;
                case "union":
                    return SelectionResolution.Union;
            }
            throw new Exception("Cannot unmarshal type SelectionResolution");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SelectionResolution)untypedValue;
            switch (value)
            {
                case SelectionResolution.Global:
                    serializer.Serialize(writer, "global");
                    return;
                case SelectionResolution.Intersect:
                    serializer.Serialize(writer, "intersect");
                    return;
                case SelectionResolution.Union:
                    serializer.Serialize(writer, "union");
                    return;
            }
            throw new Exception("Cannot marshal type SelectionResolution");
        }

        public static readonly SelectionResolutionConverter Singleton = new SelectionResolutionConverter();
    }
}