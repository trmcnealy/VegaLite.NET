using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class BoxPlotDefExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoxPlotDefExtent) || t == typeof(BoxPlotDefExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new BoxPlotDefExtent { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "ci":
                            return new BoxPlotDefExtent { Enum = ExtentExtent.Ci };
                        case "iqr":
                            return new BoxPlotDefExtent { Enum = ExtentExtent.Iqr };
                        case "min-max":
                            return new BoxPlotDefExtent { Enum = ExtentExtent.MinMax };
                        case "stderr":
                            return new BoxPlotDefExtent { Enum = ExtentExtent.Stderr };
                        case "stdev":
                            return new BoxPlotDefExtent { Enum = ExtentExtent.Stdev };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type BoxPlotDefExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BoxPlotDefExtent)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ExtentExtent.Ci:
                        serializer.Serialize(writer, "ci");
                        return;
                    case ExtentExtent.Iqr:
                        serializer.Serialize(writer, "iqr");
                        return;
                    case ExtentExtent.MinMax:
                        serializer.Serialize(writer, "min-max");
                        return;
                    case ExtentExtent.Stderr:
                        serializer.Serialize(writer, "stderr");
                        return;
                    case ExtentExtent.Stdev:
                        serializer.Serialize(writer, "stdev");
                        return;
                }
            }
            throw new Exception("Cannot marshal type BoxPlotDefExtent");
        }

        public static readonly BoxPlotDefExtentConverter Singleton = new BoxPlotDefExtentConverter();
    }
}