using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class CategoryUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(CategoryUnion) || t == typeof(CategoryUnion?);
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

                    switch(stringValue)
                    {
                        case "category":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Category
                            };
                        case "diverging":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Diverging
                            };
                        case "heatmap":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Heatmap
                            };
                        case "height":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Height
                            };
                        case "ordinal":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Ordinal
                            };
                        case "ramp":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Ramp
                            };
                        case "symbol":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Symbol
                            };
                        case "width":
                            return new CategoryUnion
                            {
                                Enum = RangeEnum.Width
                            };
                    }

                    break;
                case JsonToken.StartObject:
                    CategorySignalRef objectValue = serializer.Deserialize<CategorySignalRef>(reader);

                    return new CategoryUnion
                    {
                        CategorySignalRef = objectValue
                    };
                case JsonToken.StartArray:
                    List<RangeRaw> arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);

                    return new CategoryUnion
                    {
                        AnythingArray = arrayValue
                    };
            }

            throw new Exception("Cannot unmarshal type CategoryUnion");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            CategoryUnion value = (CategoryUnion)untypedValue;

            if(value.Enum != null)
            {
                switch(value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer,
                                             "category");

                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer,
                                             "diverging");

                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer,
                                             "heatmap");

                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer,
                                             "height");

                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer,
                                             "ordinal");

                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer,
                                             "ramp");

                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer,
                                             "symbol");

                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer,
                                             "width");

                        return;
                }
            }

            if(value.AnythingArray != null)
            {
                serializer.Serialize(writer,
                                     value.AnythingArray);

                return;
            }

            if(value.CategorySignalRef != null)
            {
                serializer.Serialize(writer,
                                     value.CategorySignalRef);

                return;
            }

            throw new Exception("Cannot marshal type CategoryUnion");
        }

        public static readonly CategoryUnionConverter Singleton = new CategoryUnionConverter();
    }
}
