using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    internal class ConditionUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionUnion) || t == typeof(ConditionUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalDef>(reader);
                    return new ConditionUnion { ConditionalDef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalNumberValueDef>>(reader);
                    return new ConditionUnion { ConditionalNumberValueDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionUnion)untypedValue;
            if (value.ConditionalNumberValueDefArray != null)
            {
                serializer.Serialize(writer, value.ConditionalNumberValueDefArray);
                return;
            }
            if (value.ConditionalDef != null)
            {
                serializer.Serialize(writer, value.ConditionalDef);
                return;
            }
            throw new Exception("Cannot marshal type ConditionUnion");
        }

        public static readonly ConditionUnionConverter Singleton = new ConditionUnionConverter();
    }
}