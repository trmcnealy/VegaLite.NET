using System;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class InterpolateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Interpolate) || t == typeof(Interpolate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "basis":
                    return Interpolate.Basis;
                case "basis-closed":
                    return Interpolate.BasisClosed;
                case "basis-open":
                    return Interpolate.BasisOpen;
                case "bundle":
                    return Interpolate.Bundle;
                case "cardinal":
                    return Interpolate.Cardinal;
                case "cardinal-closed":
                    return Interpolate.CardinalClosed;
                case "cardinal-open":
                    return Interpolate.CardinalOpen;
                case "catmull-rom":
                    return Interpolate.CatmullRom;
                case "linear":
                    return Interpolate.Linear;
                case "linear-closed":
                    return Interpolate.LinearClosed;
                case "monotone":
                    return Interpolate.Monotone;
                case "natural":
                    return Interpolate.Natural;
                case "step":
                    return Interpolate.Step;
                case "step-after":
                    return Interpolate.StepAfter;
                case "step-before":
                    return Interpolate.StepBefore;
            }
            throw new Exception("Cannot unmarshal type Interpolate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Interpolate)untypedValue;
            switch (value)
            {
                case Interpolate.Basis:
                    serializer.Serialize(writer, "basis");
                    return;
                case Interpolate.BasisClosed:
                    serializer.Serialize(writer, "basis-closed");
                    return;
                case Interpolate.BasisOpen:
                    serializer.Serialize(writer, "basis-open");
                    return;
                case Interpolate.Bundle:
                    serializer.Serialize(writer, "bundle");
                    return;
                case Interpolate.Cardinal:
                    serializer.Serialize(writer, "cardinal");
                    return;
                case Interpolate.CardinalClosed:
                    serializer.Serialize(writer, "cardinal-closed");
                    return;
                case Interpolate.CardinalOpen:
                    serializer.Serialize(writer, "cardinal-open");
                    return;
                case Interpolate.CatmullRom:
                    serializer.Serialize(writer, "catmull-rom");
                    return;
                case Interpolate.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case Interpolate.LinearClosed:
                    serializer.Serialize(writer, "linear-closed");
                    return;
                case Interpolate.Monotone:
                    serializer.Serialize(writer, "monotone");
                    return;
                case Interpolate.Natural:
                    serializer.Serialize(writer, "natural");
                    return;
                case Interpolate.Step:
                    serializer.Serialize(writer, "step");
                    return;
                case Interpolate.StepAfter:
                    serializer.Serialize(writer, "step-after");
                    return;
                case Interpolate.StepBefore:
                    serializer.Serialize(writer, "step-before");
                    return;
            }
            throw new Exception("Cannot marshal type Interpolate");
        }

        public static readonly InterpolateConverter Singleton = new InterpolateConverter();
    }
}