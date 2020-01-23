using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ProjectionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProjectionType) || t == typeof(ProjectionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "albers":
                    return ProjectionType.Albers;
                case "albersUsa":
                    return ProjectionType.AlbersUsa;
                case "azimuthalEqualArea":
                    return ProjectionType.AzimuthalEqualArea;
                case "azimuthalEquidistant":
                    return ProjectionType.AzimuthalEquidistant;
                case "conicConformal":
                    return ProjectionType.ConicConformal;
                case "conicEqualArea":
                    return ProjectionType.ConicEqualArea;
                case "conicEquidistant":
                    return ProjectionType.ConicEquidistant;
                case "equalEarth":
                    return ProjectionType.EqualEarth;
                case "equirectangular":
                    return ProjectionType.Equirectangular;
                case "gnomonic":
                    return ProjectionType.Gnomonic;
                case "identity":
                    return ProjectionType.Identity;
                case "mercator":
                    return ProjectionType.Mercator;
                case "naturalEarth1":
                    return ProjectionType.NaturalEarth1;
                case "orthographic":
                    return ProjectionType.Orthographic;
                case "stereographic":
                    return ProjectionType.Stereographic;
                case "transverseMercator":
                    return ProjectionType.TransverseMercator;
            }
            throw new Exception("Cannot unmarshal type ProjectionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProjectionType)untypedValue;
            switch (value)
            {
                case ProjectionType.Albers:
                    serializer.Serialize(writer, "albers");
                    return;
                case ProjectionType.AlbersUsa:
                    serializer.Serialize(writer, "albersUsa");
                    return;
                case ProjectionType.AzimuthalEqualArea:
                    serializer.Serialize(writer, "azimuthalEqualArea");
                    return;
                case ProjectionType.AzimuthalEquidistant:
                    serializer.Serialize(writer, "azimuthalEquidistant");
                    return;
                case ProjectionType.ConicConformal:
                    serializer.Serialize(writer, "conicConformal");
                    return;
                case ProjectionType.ConicEqualArea:
                    serializer.Serialize(writer, "conicEqualArea");
                    return;
                case ProjectionType.ConicEquidistant:
                    serializer.Serialize(writer, "conicEquidistant");
                    return;
                case ProjectionType.EqualEarth:
                    serializer.Serialize(writer, "equalEarth");
                    return;
                case ProjectionType.Equirectangular:
                    serializer.Serialize(writer, "equirectangular");
                    return;
                case ProjectionType.Gnomonic:
                    serializer.Serialize(writer, "gnomonic");
                    return;
                case ProjectionType.Identity:
                    serializer.Serialize(writer, "identity");
                    return;
                case ProjectionType.Mercator:
                    serializer.Serialize(writer, "mercator");
                    return;
                case ProjectionType.NaturalEarth1:
                    serializer.Serialize(writer, "naturalEarth1");
                    return;
                case ProjectionType.Orthographic:
                    serializer.Serialize(writer, "orthographic");
                    return;
                case ProjectionType.Stereographic:
                    serializer.Serialize(writer, "stereographic");
                    return;
                case ProjectionType.TransverseMercator:
                    serializer.Serialize(writer, "transverseMercator");
                    return;
            }
            throw new Exception("Cannot marshal type ProjectionType");
        }

        public static readonly ProjectionTypeConverter Singleton = new ProjectionTypeConverter();
    }
}