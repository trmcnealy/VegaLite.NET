using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VegaLite
{
    public partial class Specification
    {
        public static Specification FromJson(string json) => JsonConvert.DeserializeObject<Specification>(json, VegaLite.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Specification self) => JsonConvert.SerializeObject(self, VegaLite.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AlignUnionConverter.Singleton,
                LayoutAlignConverter.Singleton,
                AutosizeConverter.Singleton,
                ContainsConverter.Singleton,
                AutosizeTypeConverter.Singleton,
                BoundsEnumConverter.Singleton,
                SpecificationCenterConverter.Singleton,
                DataFormatTypeConverter.Singleton,
                GraticuleConverter.Singleton,
                SphereUnionConverter.Singleton,
                InlineDatasetConverter.Singleton,
                InlineDatasetElementConverter.Singleton,
                AggregateConverter.Singleton,
                NonArgAggregateOpConverter.Singleton,
                PurpleBinConverter.Singleton,
                BinExtentConverter.Singleton,
                SingleDefUnitChannelConverter.Singleton,
                ColorConditionConverter.Singleton,
                SelectionOperandConverter.Singleton,
                LogicalOperandPredicateConverter.Singleton,
                EqualConverter.Singleton,
                DayConverter.Singleton,
                MonthConverter.Singleton,
                LtConverter.Singleton,
                PurpleRangeConverter.Singleton,
                TimeUnitConverter.Singleton,
                ValueUnionConverter.Singleton,
                GradientConverter.Singleton,
                FieldConverter.Singleton,
                RepeatEnumConverter.Singleton,
                OrientationConverter.Singleton,
                FormatTypeConverter.Singleton,
                AlignConverter.Singleton,
                BaselineConverter.Singleton,
                FontWeightConverter.Singleton,
                PurpleFontWeightConverter.Singleton,
                LabelOverlapConverter.Singleton,
                LabelOverlapEnumConverter.Singleton,
                LegendOrientConverter.Singleton,
                TickCountConverter.Singleton,
                TimeIntervalConverter.Singleton,
                PurpleTextConverter.Singleton,
                TitleAnchorEnumConverter.Singleton,
                OrientConverter.Singleton,
                LegendTypeConverter.Singleton,
                DomainUnionConverter.Singleton,
                DomainConverter.Singleton,
                InterpolateUnionConverter.Singleton,
                ScaleInterpolateParamsTypeConverter.Singleton,
                ScaleInterpolateConverter.Singleton,
                NiceUnionConverter.Singleton,
                NiceTimeConverter.Singleton,
                ScaleRangeConverter.Singleton,
                RangeRangeConverter.Singleton,
                RangeEnumConverter.Singleton,
                SchemeConverter.Singleton,
                ScaleTypeConverter.Singleton,
                SortUnionConverter.Singleton,
                SortByChannelConverter.Singleton,
                SortOrderConverter.Singleton,
                SortConverter.Singleton,
                StandardTypeConverter.Singleton,
                SortArrayConverter.Singleton,
                DetailConverter.Singleton,
                FluffyBinConverter.Singleton,
                BinEnumConverter.Singleton,
                SpacingConverter.Singleton,
                ConditionUnionConverter.Singleton,
                HrefConditionConverter.Singleton,
                LatitudeTypeConverter.Singleton,
                OrderConverter.Singleton,
                ShapeConditionConverter.Singleton,
                TypeForShapeConverter.Singleton,
                TextConditionConverter.Singleton,
                TextConverter.Singleton,
                TooltipConverter.Singleton,
                ColorConverter.Singleton,
                ConditionalAxisPropertyColorNullConditionConverter.Singleton,
                DashConverter.Singleton,
                ConditionalAxisPropertyNumberNullConditionConverter.Singleton,
                GridDashOffsetConverter.Singleton,
                ConditionalAxisPropertyNumberNullConditionUnionConverter.Singleton,
                GridOpacityConverter.Singleton,
                GridWidthConverter.Singleton,
                LabelAlignConverter.Singleton,
                TextBaselineConverter.Singleton,
                ConditionalAxisPropertyTextBaselineNullConditionConverter.Singleton,
                LabelConverter.Singleton,
                LabelFontConverter.Singleton,
                ConditionalAxisPropertyStringNullConditionConverter.Singleton,
                LabelFontStyleConverter.Singleton,
                ConditionalAxisPropertyFontStyleNullConditionConverter.Singleton,
                LabelFontWeightUnionConverter.Singleton,
                ConditionalAxisPropertyFontWeightNullConditionConverter.Singleton,
                ConditionalPredicateValueDefFontWeightNullValueConverter.Singleton,
                TickBandConverter.Singleton,
                KeyvalsConverter.Singleton,
                ImputeParamsMethodConverter.Singleton,
                StackConverter.Singleton,
                StackOffsetConverter.Singleton,
                XUnionConverter.Singleton,
                PurpleValueConverter.Singleton,
                YUnionConverter.Singleton,
                FluffyValueConverter.Singleton,
                HeightUnionConverter.Singleton,
                HeightEnumConverter.Singleton,
                AnyMarkConverter.Singleton,
                BoxConverter.Singleton,
                ColorUnionConverter.Singleton,
                CursorConverter.Singleton,
                DirConverter.Singleton,
                FillUnionConverter.Singleton,
                InterpolateConverter.Singleton,
                InvalidConverter.Singleton,
                StrokeCapConverter.Singleton,
                StrokeJoinConverter.Singleton,
                ValueConverter.Singleton,
                ContentConverter.Singleton,
                BoxPlotDefExtentConverter.Singleton,
                ExtentExtentConverter.Singleton,
                LineConverter.Singleton,
                PointUnionConverter.Singleton,
                PointEnumConverter.Singleton,
                BoxPlotConverter.Singleton,
                ProjectionTypeConverter.Singleton,
                ResolveModeConverter.Singleton,
                BindUnionConverter.Singleton,
                PurpleStreamConverter.Singleton,
                MarkTypeConverter.Singleton,
                SourceConverter.Singleton,
                PurpleLegendBindingConverter.Singleton,
                ClearUnionConverter.Singleton,
                EmptyConverter.Singleton,
                InitConverter.Singleton,
                SelectionInitConverter.Singleton,
                InitValueConverter.Singleton,
                OnUnionConverter.Singleton,
                SelectionResolutionConverter.Singleton,
                TranslateConverter.Singleton,
                SelectionDefTypeConverter.Singleton,
                LayerTitleConverter.Singleton,
                TitleOrientConverter.Singleton,
                AggregateOpConverter.Singleton,
                TransformBinConverter.Singleton,
                TransformMethodConverter.Singleton,
                OpConverter.Singleton,
                RepeatUnionConverter.Singleton,
                BoxplotExtentConverter.Singleton,
                ExtentEnumConverter.Singleton,
                ErrorbandExtentConverter.Singleton,
                FieldTitleConverter.Singleton,
                AnchorUnionConverter.Singleton,
                LayoutBoundsConverter.Singleton,
                BottomCenterConverter.Singleton,
                DirectionConverter.Singleton,
                RangeRawArrayConverter.Singleton,
                PaddingConverter.Singleton,
                CategoryUnionConverter.Singleton,
                RangeRawConverter.Singleton,
                SignalRefExtentConverter.Singleton,
                ColorSchemeConverter.Singleton,
                DivergingUnionConverter.Singleton,
                HeatmapUnionConverter.Singleton,
                OrdinalUnionConverter.Singleton,
                RampUnionConverter.Singleton,
                BindConverter.Singleton,
                LegendBindingConverter.Singleton,
                LegendBindingEnumConverter.Singleton,
                BindingConverter.Singleton,
                FluffyStreamConverter.Singleton,
                DiscreteHeightUnionConverter.Singleton,
                DiscreteWidthUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AlignUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlignUnion) || t == typeof(AlignUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "all":
                            return new AlignUnion { Enum = LayoutAlign.All };
                        case "each":
                            return new AlignUnion { Enum = LayoutAlign.Each };
                        case "none":
                            return new AlignUnion { Enum = LayoutAlign.None };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RowColLayoutAlign>(reader);
                    return new AlignUnion { RowColLayoutAlign = objectValue };
            }
            throw new Exception("Cannot unmarshal type AlignUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AlignUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LayoutAlign.All:
                        serializer.Serialize(writer, "all");
                        return;
                    case LayoutAlign.Each:
                        serializer.Serialize(writer, "each");
                        return;
                    case LayoutAlign.None:
                        serializer.Serialize(writer, "none");
                        return;
                }
            }
            if (value.RowColLayoutAlign != null)
            {
                serializer.Serialize(writer, value.RowColLayoutAlign);
                return;
            }
            throw new Exception("Cannot marshal type AlignUnion");
        }

        public static readonly AlignUnionConverter Singleton = new AlignUnionConverter();
    }

    internal class LayoutAlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutAlign) || t == typeof(LayoutAlign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return LayoutAlign.All;
                case "each":
                    return LayoutAlign.Each;
                case "none":
                    return LayoutAlign.None;
            }
            throw new Exception("Cannot unmarshal type LayoutAlign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LayoutAlign)untypedValue;
            switch (value)
            {
                case LayoutAlign.All:
                    serializer.Serialize(writer, "all");
                    return;
                case LayoutAlign.Each:
                    serializer.Serialize(writer, "each");
                    return;
                case LayoutAlign.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type LayoutAlign");
        }

        public static readonly LayoutAlignConverter Singleton = new LayoutAlignConverter();
    }

    internal class AutosizeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Autosize) || t == typeof(Autosize?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "fit":
                            return new Autosize { Enum = AutosizeType.Fit };
                        case "fit-x":
                            return new Autosize { Enum = AutosizeType.FitX };
                        case "fit-y":
                            return new Autosize { Enum = AutosizeType.FitY };
                        case "none":
                            return new Autosize { Enum = AutosizeType.None };
                        case "pad":
                            return new Autosize { Enum = AutosizeType.Pad };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AutoSizeParams>(reader);
                    return new Autosize { AutoSizeParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type Autosize");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Autosize)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case AutosizeType.Fit:
                        serializer.Serialize(writer, "fit");
                        return;
                    case AutosizeType.FitX:
                        serializer.Serialize(writer, "fit-x");
                        return;
                    case AutosizeType.FitY:
                        serializer.Serialize(writer, "fit-y");
                        return;
                    case AutosizeType.None:
                        serializer.Serialize(writer, "none");
                        return;
                    case AutosizeType.Pad:
                        serializer.Serialize(writer, "pad");
                        return;
                }
            }
            if (value.AutoSizeParams != null)
            {
                serializer.Serialize(writer, value.AutoSizeParams);
                return;
            }
            throw new Exception("Cannot marshal type Autosize");
        }

        public static readonly AutosizeConverter Singleton = new AutosizeConverter();
    }

    internal class ContainsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Contains) || t == typeof(Contains?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "content":
                    return Contains.Content;
                case "padding":
                    return Contains.Padding;
            }
            throw new Exception("Cannot unmarshal type Contains");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Contains)untypedValue;
            switch (value)
            {
                case Contains.Content:
                    serializer.Serialize(writer, "content");
                    return;
                case Contains.Padding:
                    serializer.Serialize(writer, "padding");
                    return;
            }
            throw new Exception("Cannot marshal type Contains");
        }

        public static readonly ContainsConverter Singleton = new ContainsConverter();
    }

    internal class AutosizeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AutosizeType) || t == typeof(AutosizeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fit":
                    return AutosizeType.Fit;
                case "fit-x":
                    return AutosizeType.FitX;
                case "fit-y":
                    return AutosizeType.FitY;
                case "none":
                    return AutosizeType.None;
                case "pad":
                    return AutosizeType.Pad;
            }
            throw new Exception("Cannot unmarshal type AutosizeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AutosizeType)untypedValue;
            switch (value)
            {
                case AutosizeType.Fit:
                    serializer.Serialize(writer, "fit");
                    return;
                case AutosizeType.FitX:
                    serializer.Serialize(writer, "fit-x");
                    return;
                case AutosizeType.FitY:
                    serializer.Serialize(writer, "fit-y");
                    return;
                case AutosizeType.None:
                    serializer.Serialize(writer, "none");
                    return;
                case AutosizeType.Pad:
                    serializer.Serialize(writer, "pad");
                    return;
            }
            throw new Exception("Cannot marshal type AutosizeType");
        }

        public static readonly AutosizeTypeConverter Singleton = new AutosizeTypeConverter();
    }

    internal class BoundsEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoundsEnum) || t == typeof(BoundsEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "flush":
                    return BoundsEnum.Flush;
                case "full":
                    return BoundsEnum.Full;
            }
            throw new Exception("Cannot unmarshal type BoundsEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BoundsEnum)untypedValue;
            switch (value)
            {
                case BoundsEnum.Flush:
                    serializer.Serialize(writer, "flush");
                    return;
                case BoundsEnum.Full:
                    serializer.Serialize(writer, "full");
                    return;
            }
            throw new Exception("Cannot marshal type BoundsEnum");
        }

        public static readonly BoundsEnumConverter Singleton = new BoundsEnumConverter();
    }

    internal class SpecificationCenterConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SpecificationCenter) || t == typeof(SpecificationCenter?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new SpecificationCenter { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RowColBoolean>(reader);
                    return new SpecificationCenter { RowColBoolean = objectValue };
            }
            throw new Exception("Cannot unmarshal type SpecificationCenter");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SpecificationCenter)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.RowColBoolean != null)
            {
                serializer.Serialize(writer, value.RowColBoolean);
                return;
            }
            throw new Exception("Cannot marshal type SpecificationCenter");
        }

        public static readonly SpecificationCenterConverter Singleton = new SpecificationCenterConverter();
    }

    internal class MinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length >= 1 && value.Length <= 1)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length >= 1 && value.Length <= 1)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly MinMaxLengthCheckConverter Singleton = new MinMaxLengthCheckConverter();
    }

    internal class DataFormatTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DataFormatType) || t == typeof(DataFormatType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "csv":
                    return DataFormatType.Csv;
                case "dsv":
                    return DataFormatType.Dsv;
                case "json":
                    return DataFormatType.Json;
                case "topojson":
                    return DataFormatType.Topojson;
                case "tsv":
                    return DataFormatType.Tsv;
            }
            throw new Exception("Cannot unmarshal type DataFormatType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DataFormatType)untypedValue;
            switch (value)
            {
                case DataFormatType.Csv:
                    serializer.Serialize(writer, "csv");
                    return;
                case DataFormatType.Dsv:
                    serializer.Serialize(writer, "dsv");
                    return;
                case DataFormatType.Json:
                    serializer.Serialize(writer, "json");
                    return;
                case DataFormatType.Topojson:
                    serializer.Serialize(writer, "topojson");
                    return;
                case DataFormatType.Tsv:
                    serializer.Serialize(writer, "tsv");
                    return;
            }
            throw new Exception("Cannot marshal type DataFormatType");
        }

        public static readonly DataFormatTypeConverter Singleton = new DataFormatTypeConverter();
    }

    internal class GraticuleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Graticule) || t == typeof(Graticule?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Graticule { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<GraticuleParams>(reader);
                    return new Graticule { GraticuleParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type Graticule");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Graticule)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.GraticuleParams != null)
            {
                serializer.Serialize(writer, value.GraticuleParams);
                return;
            }
            throw new Exception("Cannot marshal type Graticule");
        }

        public static readonly GraticuleConverter Singleton = new GraticuleConverter();
    }

    internal class SphereUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SphereUnion) || t == typeof(SphereUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new SphereUnion { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SphereClass>(reader);
                    return new SphereUnion { SphereClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type SphereUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SphereUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.SphereClass != null)
            {
                serializer.Serialize(writer, value.SphereClass);
                return;
            }
            throw new Exception("Cannot marshal type SphereUnion");
        }

        public static readonly SphereUnionConverter Singleton = new SphereUnionConverter();
    }

    internal class InlineDatasetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InlineDataset) || t == typeof(InlineDataset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new InlineDataset { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, object>>(reader);
                    return new InlineDataset { AnythingMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<InlineDatasetElement>>(reader);
                    return new InlineDataset { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type InlineDataset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InlineDataset)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type InlineDataset");
        }

        public static readonly InlineDatasetConverter Singleton = new InlineDatasetConverter();
    }

    internal class InlineDatasetElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InlineDatasetElement) || t == typeof(InlineDatasetElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new InlineDatasetElement { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new InlineDatasetElement { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new InlineDatasetElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, object>>(reader);
                    return new InlineDatasetElement { AnythingMap = objectValue };
            }
            throw new Exception("Cannot unmarshal type InlineDatasetElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InlineDatasetElement)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type InlineDatasetElement");
        }

        public static readonly InlineDatasetElementConverter Singleton = new InlineDatasetElementConverter();
    }

    internal class AggregateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Aggregate) || t == typeof(Aggregate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "average":
                            return new Aggregate { Enum = NonArgAggregateOp.Average };
                        case "ci0":
                            return new Aggregate { Enum = NonArgAggregateOp.Ci0 };
                        case "ci1":
                            return new Aggregate { Enum = NonArgAggregateOp.Ci1 };
                        case "count":
                            return new Aggregate { Enum = NonArgAggregateOp.Count };
                        case "distinct":
                            return new Aggregate { Enum = NonArgAggregateOp.Distinct };
                        case "max":
                            return new Aggregate { Enum = NonArgAggregateOp.Max };
                        case "mean":
                            return new Aggregate { Enum = NonArgAggregateOp.Mean };
                        case "median":
                            return new Aggregate { Enum = NonArgAggregateOp.Median };
                        case "min":
                            return new Aggregate { Enum = NonArgAggregateOp.Min };
                        case "missing":
                            return new Aggregate { Enum = NonArgAggregateOp.Missing };
                        case "q1":
                            return new Aggregate { Enum = NonArgAggregateOp.Q1 };
                        case "q3":
                            return new Aggregate { Enum = NonArgAggregateOp.Q3 };
                        case "stderr":
                            return new Aggregate { Enum = NonArgAggregateOp.Stderr };
                        case "stdev":
                            return new Aggregate { Enum = NonArgAggregateOp.Stdev };
                        case "stdevp":
                            return new Aggregate { Enum = NonArgAggregateOp.Stdevp };
                        case "sum":
                            return new Aggregate { Enum = NonArgAggregateOp.Sum };
                        case "valid":
                            return new Aggregate { Enum = NonArgAggregateOp.Valid };
                        case "values":
                            return new Aggregate { Enum = NonArgAggregateOp.Values };
                        case "variance":
                            return new Aggregate { Enum = NonArgAggregateOp.Variance };
                        case "variancep":
                            return new Aggregate { Enum = NonArgAggregateOp.Variancep };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ArgmDef>(reader);
                    return new Aggregate { ArgmDef = objectValue };
            }
            throw new Exception("Cannot unmarshal type Aggregate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Aggregate)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case NonArgAggregateOp.Average:
                        serializer.Serialize(writer, "average");
                        return;
                    case NonArgAggregateOp.Ci0:
                        serializer.Serialize(writer, "ci0");
                        return;
                    case NonArgAggregateOp.Ci1:
                        serializer.Serialize(writer, "ci1");
                        return;
                    case NonArgAggregateOp.Count:
                        serializer.Serialize(writer, "count");
                        return;
                    case NonArgAggregateOp.Distinct:
                        serializer.Serialize(writer, "distinct");
                        return;
                    case NonArgAggregateOp.Max:
                        serializer.Serialize(writer, "max");
                        return;
                    case NonArgAggregateOp.Mean:
                        serializer.Serialize(writer, "mean");
                        return;
                    case NonArgAggregateOp.Median:
                        serializer.Serialize(writer, "median");
                        return;
                    case NonArgAggregateOp.Min:
                        serializer.Serialize(writer, "min");
                        return;
                    case NonArgAggregateOp.Missing:
                        serializer.Serialize(writer, "missing");
                        return;
                    case NonArgAggregateOp.Q1:
                        serializer.Serialize(writer, "q1");
                        return;
                    case NonArgAggregateOp.Q3:
                        serializer.Serialize(writer, "q3");
                        return;
                    case NonArgAggregateOp.Stderr:
                        serializer.Serialize(writer, "stderr");
                        return;
                    case NonArgAggregateOp.Stdev:
                        serializer.Serialize(writer, "stdev");
                        return;
                    case NonArgAggregateOp.Stdevp:
                        serializer.Serialize(writer, "stdevp");
                        return;
                    case NonArgAggregateOp.Sum:
                        serializer.Serialize(writer, "sum");
                        return;
                    case NonArgAggregateOp.Valid:
                        serializer.Serialize(writer, "valid");
                        return;
                    case NonArgAggregateOp.Values:
                        serializer.Serialize(writer, "values");
                        return;
                    case NonArgAggregateOp.Variance:
                        serializer.Serialize(writer, "variance");
                        return;
                    case NonArgAggregateOp.Variancep:
                        serializer.Serialize(writer, "variancep");
                        return;
                }
            }
            if (value.ArgmDef != null)
            {
                serializer.Serialize(writer, value.ArgmDef);
                return;
            }
            throw new Exception("Cannot marshal type Aggregate");
        }

        public static readonly AggregateConverter Singleton = new AggregateConverter();
    }

    internal class NonArgAggregateOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NonArgAggregateOp) || t == typeof(NonArgAggregateOp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "average":
                    return NonArgAggregateOp.Average;
                case "ci0":
                    return NonArgAggregateOp.Ci0;
                case "ci1":
                    return NonArgAggregateOp.Ci1;
                case "count":
                    return NonArgAggregateOp.Count;
                case "distinct":
                    return NonArgAggregateOp.Distinct;
                case "max":
                    return NonArgAggregateOp.Max;
                case "mean":
                    return NonArgAggregateOp.Mean;
                case "median":
                    return NonArgAggregateOp.Median;
                case "min":
                    return NonArgAggregateOp.Min;
                case "missing":
                    return NonArgAggregateOp.Missing;
                case "q1":
                    return NonArgAggregateOp.Q1;
                case "q3":
                    return NonArgAggregateOp.Q3;
                case "stderr":
                    return NonArgAggregateOp.Stderr;
                case "stdev":
                    return NonArgAggregateOp.Stdev;
                case "stdevp":
                    return NonArgAggregateOp.Stdevp;
                case "sum":
                    return NonArgAggregateOp.Sum;
                case "valid":
                    return NonArgAggregateOp.Valid;
                case "values":
                    return NonArgAggregateOp.Values;
                case "variance":
                    return NonArgAggregateOp.Variance;
                case "variancep":
                    return NonArgAggregateOp.Variancep;
            }
            throw new Exception("Cannot unmarshal type NonArgAggregateOp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NonArgAggregateOp)untypedValue;
            switch (value)
            {
                case NonArgAggregateOp.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case NonArgAggregateOp.Ci0:
                    serializer.Serialize(writer, "ci0");
                    return;
                case NonArgAggregateOp.Ci1:
                    serializer.Serialize(writer, "ci1");
                    return;
                case NonArgAggregateOp.Count:
                    serializer.Serialize(writer, "count");
                    return;
                case NonArgAggregateOp.Distinct:
                    serializer.Serialize(writer, "distinct");
                    return;
                case NonArgAggregateOp.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case NonArgAggregateOp.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case NonArgAggregateOp.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case NonArgAggregateOp.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case NonArgAggregateOp.Missing:
                    serializer.Serialize(writer, "missing");
                    return;
                case NonArgAggregateOp.Q1:
                    serializer.Serialize(writer, "q1");
                    return;
                case NonArgAggregateOp.Q3:
                    serializer.Serialize(writer, "q3");
                    return;
                case NonArgAggregateOp.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case NonArgAggregateOp.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
                case NonArgAggregateOp.Stdevp:
                    serializer.Serialize(writer, "stdevp");
                    return;
                case NonArgAggregateOp.Sum:
                    serializer.Serialize(writer, "sum");
                    return;
                case NonArgAggregateOp.Valid:
                    serializer.Serialize(writer, "valid");
                    return;
                case NonArgAggregateOp.Values:
                    serializer.Serialize(writer, "values");
                    return;
                case NonArgAggregateOp.Variance:
                    serializer.Serialize(writer, "variance");
                    return;
                case NonArgAggregateOp.Variancep:
                    serializer.Serialize(writer, "variancep");
                    return;
            }
            throw new Exception("Cannot marshal type NonArgAggregateOp");
        }

        public static readonly NonArgAggregateOpConverter Singleton = new NonArgAggregateOpConverter();
    }

    internal class PurpleBinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleBin) || t == typeof(PurpleBin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new PurpleBin { };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new PurpleBin { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinParams>(reader);
                    return new PurpleBin { BinParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type PurpleBin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleBin)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.BinParams != null)
            {
                serializer.Serialize(writer, value.BinParams);
                return;
            }
            throw new Exception("Cannot marshal type PurpleBin");
        }

        public static readonly PurpleBinConverter Singleton = new PurpleBinConverter();
    }

    internal class BinExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BinExtent) || t == typeof(BinExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinExtentClass>(reader);
                    return new BinExtent { BinExtentClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<double>>(reader);
                    return new BinExtent { DoubleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type BinExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BinExtent)untypedValue;
            if (value.DoubleArray != null)
            {
                serializer.Serialize(writer, value.DoubleArray);
                return;
            }
            if (value.BinExtentClass != null)
            {
                serializer.Serialize(writer, value.BinExtentClass);
                return;
            }
            throw new Exception("Cannot marshal type BinExtent");
        }

        public static readonly BinExtentConverter Singleton = new BinExtentConverter();
    }

    internal class SingleDefUnitChannelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SingleDefUnitChannel) || t == typeof(SingleDefUnitChannel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "color":
                    return SingleDefUnitChannel.Color;
                case "fill":
                    return SingleDefUnitChannel.Fill;
                case "fillOpacity":
                    return SingleDefUnitChannel.FillOpacity;
                case "href":
                    return SingleDefUnitChannel.Href;
                case "key":
                    return SingleDefUnitChannel.Key;
                case "latitude":
                    return SingleDefUnitChannel.Latitude;
                case "latitude2":
                    return SingleDefUnitChannel.Latitude2;
                case "longitude":
                    return SingleDefUnitChannel.Longitude;
                case "longitude2":
                    return SingleDefUnitChannel.Longitude2;
                case "opacity":
                    return SingleDefUnitChannel.Opacity;
                case "shape":
                    return SingleDefUnitChannel.Shape;
                case "size":
                    return SingleDefUnitChannel.Size;
                case "stroke":
                    return SingleDefUnitChannel.Stroke;
                case "strokeOpacity":
                    return SingleDefUnitChannel.StrokeOpacity;
                case "strokeWidth":
                    return SingleDefUnitChannel.StrokeWidth;
                case "text":
                    return SingleDefUnitChannel.Text;
                case "url":
                    return SingleDefUnitChannel.Url;
                case "x":
                    return SingleDefUnitChannel.X;
                case "x2":
                    return SingleDefUnitChannel.X2;
                case "y":
                    return SingleDefUnitChannel.Y;
                case "y2":
                    return SingleDefUnitChannel.Y2;
            }
            throw new Exception("Cannot unmarshal type SingleDefUnitChannel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SingleDefUnitChannel)untypedValue;
            switch (value)
            {
                case SingleDefUnitChannel.Color:
                    serializer.Serialize(writer, "color");
                    return;
                case SingleDefUnitChannel.Fill:
                    serializer.Serialize(writer, "fill");
                    return;
                case SingleDefUnitChannel.FillOpacity:
                    serializer.Serialize(writer, "fillOpacity");
                    return;
                case SingleDefUnitChannel.Href:
                    serializer.Serialize(writer, "href");
                    return;
                case SingleDefUnitChannel.Key:
                    serializer.Serialize(writer, "key");
                    return;
                case SingleDefUnitChannel.Latitude:
                    serializer.Serialize(writer, "latitude");
                    return;
                case SingleDefUnitChannel.Latitude2:
                    serializer.Serialize(writer, "latitude2");
                    return;
                case SingleDefUnitChannel.Longitude:
                    serializer.Serialize(writer, "longitude");
                    return;
                case SingleDefUnitChannel.Longitude2:
                    serializer.Serialize(writer, "longitude2");
                    return;
                case SingleDefUnitChannel.Opacity:
                    serializer.Serialize(writer, "opacity");
                    return;
                case SingleDefUnitChannel.Shape:
                    serializer.Serialize(writer, "shape");
                    return;
                case SingleDefUnitChannel.Size:
                    serializer.Serialize(writer, "size");
                    return;
                case SingleDefUnitChannel.Stroke:
                    serializer.Serialize(writer, "stroke");
                    return;
                case SingleDefUnitChannel.StrokeOpacity:
                    serializer.Serialize(writer, "strokeOpacity");
                    return;
                case SingleDefUnitChannel.StrokeWidth:
                    serializer.Serialize(writer, "strokeWidth");
                    return;
                case SingleDefUnitChannel.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case SingleDefUnitChannel.Url:
                    serializer.Serialize(writer, "url");
                    return;
                case SingleDefUnitChannel.X:
                    serializer.Serialize(writer, "x");
                    return;
                case SingleDefUnitChannel.X2:
                    serializer.Serialize(writer, "x2");
                    return;
                case SingleDefUnitChannel.Y:
                    serializer.Serialize(writer, "y");
                    return;
                case SingleDefUnitChannel.Y2:
                    serializer.Serialize(writer, "y2");
                    return;
            }
            throw new Exception("Cannot marshal type SingleDefUnitChannel");
        }

        public static readonly SingleDefUnitChannelConverter Singleton = new SingleDefUnitChannelConverter();
    }

    internal class ColorConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColorCondition) || t == typeof(ColorCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefGradientStringNullClass>(reader);
                    return new ColorCondition { ConditionalPredicateValueDefGradientStringNullClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalValueDefGradientStringNull>>(reader);
                    return new ColorCondition { ConditionalValueDefGradientStringNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ColorCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColorCondition)untypedValue;
            if (value.ConditionalValueDefGradientStringNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalValueDefGradientStringNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefGradientStringNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefGradientStringNullClass);
                return;
            }
            throw new Exception("Cannot marshal type ColorCondition");
        }

        public static readonly ColorConditionConverter Singleton = new ColorConditionConverter();
    }

    internal class SelectionOperandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionOperand) || t == typeof(SelectionOperand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new SelectionOperand { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Selection>(reader);
                    return new SelectionOperand { Selection = objectValue };
            }
            throw new Exception("Cannot unmarshal type SelectionOperand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SelectionOperand)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Selection != null)
            {
                serializer.Serialize(writer, value.Selection);
                return;
            }
            throw new Exception("Cannot marshal type SelectionOperand");
        }

        public static readonly SelectionOperandConverter Singleton = new SelectionOperandConverter();
    }

    internal class LogicalOperandPredicateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LogicalOperandPredicate) || t == typeof(LogicalOperandPredicate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LogicalOperandPredicate { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Predicate>(reader);
                    return new LogicalOperandPredicate { Predicate = objectValue };
            }
            throw new Exception("Cannot unmarshal type LogicalOperandPredicate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LogicalOperandPredicate)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Predicate != null)
            {
                serializer.Serialize(writer, value.Predicate);
                return;
            }
            throw new Exception("Cannot marshal type LogicalOperandPredicate");
        }

        public static readonly LogicalOperandPredicateConverter Singleton = new LogicalOperandPredicateConverter();
    }

    internal class EqualConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Equal) || t == typeof(Equal?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Equal { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Equal { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Equal { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new Equal { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type Equal");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Equal)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type Equal");
        }

        public static readonly EqualConverter Singleton = new EqualConverter();
    }

    internal class DayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Day) || t == typeof(Day?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Day { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Day { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Day");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Day)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Day");
        }

        public static readonly DayConverter Singleton = new DayConverter();
    }

    internal class MonthConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Month) || t == typeof(Month?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Month { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Month { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Month");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Month)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Month");
        }

        public static readonly MonthConverter Singleton = new MonthConverter();
    }

    internal class LtConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Lt) || t == typeof(Lt?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Lt { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Lt { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new Lt { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type Lt");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Lt)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type Lt");
        }

        public static readonly LtConverter Singleton = new LtConverter();
    }

    internal class PurpleRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleRange) || t == typeof(PurpleRange?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new PurpleRange { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new PurpleRange { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new PurpleRange { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type PurpleRange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleRange)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type PurpleRange");
        }

        public static readonly PurpleRangeConverter Singleton = new PurpleRangeConverter();
    }

    internal class TimeUnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimeUnit) || t == typeof(TimeUnit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "date":
                    return TimeUnit.Date;
                case "day":
                    return TimeUnit.Day;
                case "hours":
                    return TimeUnit.Hours;
                case "hoursminutes":
                    return TimeUnit.Hoursminutes;
                case "hoursminutesseconds":
                    return TimeUnit.Hoursminutesseconds;
                case "milliseconds":
                    return TimeUnit.Milliseconds;
                case "minutes":
                    return TimeUnit.Minutes;
                case "minutesseconds":
                    return TimeUnit.Minutesseconds;
                case "month":
                    return TimeUnit.Month;
                case "monthdate":
                    return TimeUnit.Monthdate;
                case "monthdatehours":
                    return TimeUnit.Monthdatehours;
                case "quarter":
                    return TimeUnit.Quarter;
                case "quartermonth":
                    return TimeUnit.Quartermonth;
                case "seconds":
                    return TimeUnit.Seconds;
                case "secondsmilliseconds":
                    return TimeUnit.Secondsmilliseconds;
                case "utcdate":
                    return TimeUnit.Utcdate;
                case "utcday":
                    return TimeUnit.Utcday;
                case "utchours":
                    return TimeUnit.Utchours;
                case "utchoursminutes":
                    return TimeUnit.Utchoursminutes;
                case "utchoursminutesseconds":
                    return TimeUnit.Utchoursminutesseconds;
                case "utcmilliseconds":
                    return TimeUnit.Utcmilliseconds;
                case "utcminutes":
                    return TimeUnit.Utcminutes;
                case "utcminutesseconds":
                    return TimeUnit.Utcminutesseconds;
                case "utcmonth":
                    return TimeUnit.Utcmonth;
                case "utcmonthdate":
                    return TimeUnit.Utcmonthdate;
                case "utcmonthdatehours":
                    return TimeUnit.Utcmonthdatehours;
                case "utcquarter":
                    return TimeUnit.Utcquarter;
                case "utcquartermonth":
                    return TimeUnit.Utcquartermonth;
                case "utcseconds":
                    return TimeUnit.Utcseconds;
                case "utcsecondsmilliseconds":
                    return TimeUnit.Utcsecondsmilliseconds;
                case "utcyear":
                    return TimeUnit.Utcyear;
                case "utcyearmonth":
                    return TimeUnit.Utcyearmonth;
                case "utcyearmonthdate":
                    return TimeUnit.Utcyearmonthdate;
                case "utcyearmonthdatehours":
                    return TimeUnit.Utcyearmonthdatehours;
                case "utcyearmonthdatehoursminutes":
                    return TimeUnit.Utcyearmonthdatehoursminutes;
                case "utcyearmonthdatehoursminutesseconds":
                    return TimeUnit.Utcyearmonthdatehoursminutesseconds;
                case "utcyearquarter":
                    return TimeUnit.Utcyearquarter;
                case "utcyearquartermonth":
                    return TimeUnit.Utcyearquartermonth;
                case "year":
                    return TimeUnit.Year;
                case "yearmonth":
                    return TimeUnit.Yearmonth;
                case "yearmonthdate":
                    return TimeUnit.Yearmonthdate;
                case "yearmonthdatehours":
                    return TimeUnit.Yearmonthdatehours;
                case "yearmonthdatehoursminutes":
                    return TimeUnit.Yearmonthdatehoursminutes;
                case "yearmonthdatehoursminutesseconds":
                    return TimeUnit.Yearmonthdatehoursminutesseconds;
                case "yearquarter":
                    return TimeUnit.Yearquarter;
                case "yearquartermonth":
                    return TimeUnit.Yearquartermonth;
            }
            throw new Exception("Cannot unmarshal type TimeUnit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TimeUnit)untypedValue;
            switch (value)
            {
                case TimeUnit.Date:
                    serializer.Serialize(writer, "date");
                    return;
                case TimeUnit.Day:
                    serializer.Serialize(writer, "day");
                    return;
                case TimeUnit.Hours:
                    serializer.Serialize(writer, "hours");
                    return;
                case TimeUnit.Hoursminutes:
                    serializer.Serialize(writer, "hoursminutes");
                    return;
                case TimeUnit.Hoursminutesseconds:
                    serializer.Serialize(writer, "hoursminutesseconds");
                    return;
                case TimeUnit.Milliseconds:
                    serializer.Serialize(writer, "milliseconds");
                    return;
                case TimeUnit.Minutes:
                    serializer.Serialize(writer, "minutes");
                    return;
                case TimeUnit.Minutesseconds:
                    serializer.Serialize(writer, "minutesseconds");
                    return;
                case TimeUnit.Month:
                    serializer.Serialize(writer, "month");
                    return;
                case TimeUnit.Monthdate:
                    serializer.Serialize(writer, "monthdate");
                    return;
                case TimeUnit.Monthdatehours:
                    serializer.Serialize(writer, "monthdatehours");
                    return;
                case TimeUnit.Quarter:
                    serializer.Serialize(writer, "quarter");
                    return;
                case TimeUnit.Quartermonth:
                    serializer.Serialize(writer, "quartermonth");
                    return;
                case TimeUnit.Seconds:
                    serializer.Serialize(writer, "seconds");
                    return;
                case TimeUnit.Secondsmilliseconds:
                    serializer.Serialize(writer, "secondsmilliseconds");
                    return;
                case TimeUnit.Utcdate:
                    serializer.Serialize(writer, "utcdate");
                    return;
                case TimeUnit.Utcday:
                    serializer.Serialize(writer, "utcday");
                    return;
                case TimeUnit.Utchours:
                    serializer.Serialize(writer, "utchours");
                    return;
                case TimeUnit.Utchoursminutes:
                    serializer.Serialize(writer, "utchoursminutes");
                    return;
                case TimeUnit.Utchoursminutesseconds:
                    serializer.Serialize(writer, "utchoursminutesseconds");
                    return;
                case TimeUnit.Utcmilliseconds:
                    serializer.Serialize(writer, "utcmilliseconds");
                    return;
                case TimeUnit.Utcminutes:
                    serializer.Serialize(writer, "utcminutes");
                    return;
                case TimeUnit.Utcminutesseconds:
                    serializer.Serialize(writer, "utcminutesseconds");
                    return;
                case TimeUnit.Utcmonth:
                    serializer.Serialize(writer, "utcmonth");
                    return;
                case TimeUnit.Utcmonthdate:
                    serializer.Serialize(writer, "utcmonthdate");
                    return;
                case TimeUnit.Utcmonthdatehours:
                    serializer.Serialize(writer, "utcmonthdatehours");
                    return;
                case TimeUnit.Utcquarter:
                    serializer.Serialize(writer, "utcquarter");
                    return;
                case TimeUnit.Utcquartermonth:
                    serializer.Serialize(writer, "utcquartermonth");
                    return;
                case TimeUnit.Utcseconds:
                    serializer.Serialize(writer, "utcseconds");
                    return;
                case TimeUnit.Utcsecondsmilliseconds:
                    serializer.Serialize(writer, "utcsecondsmilliseconds");
                    return;
                case TimeUnit.Utcyear:
                    serializer.Serialize(writer, "utcyear");
                    return;
                case TimeUnit.Utcyearmonth:
                    serializer.Serialize(writer, "utcyearmonth");
                    return;
                case TimeUnit.Utcyearmonthdate:
                    serializer.Serialize(writer, "utcyearmonthdate");
                    return;
                case TimeUnit.Utcyearmonthdatehours:
                    serializer.Serialize(writer, "utcyearmonthdatehours");
                    return;
                case TimeUnit.Utcyearmonthdatehoursminutes:
                    serializer.Serialize(writer, "utcyearmonthdatehoursminutes");
                    return;
                case TimeUnit.Utcyearmonthdatehoursminutesseconds:
                    serializer.Serialize(writer, "utcyearmonthdatehoursminutesseconds");
                    return;
                case TimeUnit.Utcyearquarter:
                    serializer.Serialize(writer, "utcyearquarter");
                    return;
                case TimeUnit.Utcyearquartermonth:
                    serializer.Serialize(writer, "utcyearquartermonth");
                    return;
                case TimeUnit.Year:
                    serializer.Serialize(writer, "year");
                    return;
                case TimeUnit.Yearmonth:
                    serializer.Serialize(writer, "yearmonth");
                    return;
                case TimeUnit.Yearmonthdate:
                    serializer.Serialize(writer, "yearmonthdate");
                    return;
                case TimeUnit.Yearmonthdatehours:
                    serializer.Serialize(writer, "yearmonthdatehours");
                    return;
                case TimeUnit.Yearmonthdatehoursminutes:
                    serializer.Serialize(writer, "yearmonthdatehoursminutes");
                    return;
                case TimeUnit.Yearmonthdatehoursminutesseconds:
                    serializer.Serialize(writer, "yearmonthdatehoursminutesseconds");
                    return;
                case TimeUnit.Yearquarter:
                    serializer.Serialize(writer, "yearquarter");
                    return;
                case TimeUnit.Yearquartermonth:
                    serializer.Serialize(writer, "yearquartermonth");
                    return;
            }
            throw new Exception("Cannot marshal type TimeUnit");
        }

        public static readonly TimeUnitConverter Singleton = new TimeUnitConverter();
    }

    internal class ValueUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueUnion) || t == typeof(ValueUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ValueUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ValueUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ValueLinearGradient>(reader);
                    return new ValueUnion { ValueLinearGradient = objectValue };
            }
            throw new Exception("Cannot unmarshal type ValueUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValueUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ValueLinearGradient != null)
            {
                serializer.Serialize(writer, value.ValueLinearGradient);
                return;
            }
            throw new Exception("Cannot marshal type ValueUnion");
        }

        public static readonly ValueUnionConverter Singleton = new ValueUnionConverter();
    }

    internal class GradientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gradient) || t == typeof(Gradient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "linear":
                    return Gradient.Linear;
                case "radial":
                    return Gradient.Radial;
            }
            throw new Exception("Cannot unmarshal type Gradient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gradient)untypedValue;
            switch (value)
            {
                case Gradient.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case Gradient.Radial:
                    serializer.Serialize(writer, "radial");
                    return;
            }
            throw new Exception("Cannot marshal type Gradient");
        }

        public static readonly GradientConverter Singleton = new GradientConverter();
    }

    internal class FieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Field) || t == typeof(Field?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Field { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RepeatRef>(reader);
                    return new Field { RepeatRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type Field");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Field)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.RepeatRef != null)
            {
                serializer.Serialize(writer, value.RepeatRef);
                return;
            }
            throw new Exception("Cannot marshal type Field");
        }

        public static readonly FieldConverter Singleton = new FieldConverter();
    }

    internal class RepeatEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RepeatEnum) || t == typeof(RepeatEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "column":
                    return RepeatEnum.Column;
                case "repeat":
                    return RepeatEnum.Repeat;
                case "row":
                    return RepeatEnum.Row;
            }
            throw new Exception("Cannot unmarshal type RepeatEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RepeatEnum)untypedValue;
            switch (value)
            {
                case RepeatEnum.Column:
                    serializer.Serialize(writer, "column");
                    return;
                case RepeatEnum.Repeat:
                    serializer.Serialize(writer, "repeat");
                    return;
                case RepeatEnum.Row:
                    serializer.Serialize(writer, "row");
                    return;
            }
            throw new Exception("Cannot marshal type RepeatEnum");
        }

        public static readonly RepeatEnumConverter Singleton = new RepeatEnumConverter();
    }

    internal class OrientationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Orientation) || t == typeof(Orientation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "horizontal":
                    return Orientation.Horizontal;
                case "vertical":
                    return Orientation.Vertical;
            }
            throw new Exception("Cannot unmarshal type Orientation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Orientation)untypedValue;
            switch (value)
            {
                case Orientation.Horizontal:
                    serializer.Serialize(writer, "horizontal");
                    return;
                case Orientation.Vertical:
                    serializer.Serialize(writer, "vertical");
                    return;
            }
            throw new Exception("Cannot marshal type Orientation");
        }

        public static readonly OrientationConverter Singleton = new OrientationConverter();
    }

    internal class FormatTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FormatType) || t == typeof(FormatType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "number":
                    return FormatType.Number;
                case "time":
                    return FormatType.Time;
            }
            throw new Exception("Cannot unmarshal type FormatType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FormatType)untypedValue;
            switch (value)
            {
                case FormatType.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case FormatType.Time:
                    serializer.Serialize(writer, "time");
                    return;
            }
            throw new Exception("Cannot marshal type FormatType");
        }

        public static readonly FormatTypeConverter Singleton = new FormatTypeConverter();
    }

    internal class AlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Align) || t == typeof(Align?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return Align.Center;
                case "left":
                    return Align.Left;
                case "right":
                    return Align.Right;
            }
            throw new Exception("Cannot unmarshal type Align");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Align)untypedValue;
            switch (value)
            {
                case Align.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case Align.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case Align.Right:
                    serializer.Serialize(writer, "right");
                    return;
            }
            throw new Exception("Cannot marshal type Align");
        }

        public static readonly AlignConverter Singleton = new AlignConverter();
    }

    internal class BaselineConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Baseline) || t == typeof(Baseline?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "alphabetic":
                    return Baseline.Alphabetic;
                case "bottom":
                    return Baseline.Bottom;
                case "middle":
                    return Baseline.Middle;
                case "top":
                    return Baseline.Top;
            }
            throw new Exception("Cannot unmarshal type Baseline");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Baseline)untypedValue;
            switch (value)
            {
                case Baseline.Alphabetic:
                    serializer.Serialize(writer, "alphabetic");
                    return;
                case Baseline.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case Baseline.Middle:
                    serializer.Serialize(writer, "middle");
                    return;
                case Baseline.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type Baseline");
        }

        public static readonly BaselineConverter Singleton = new BaselineConverter();
    }

    internal class FontWeightConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontWeight) || t == typeof(FontWeight?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FontWeight { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bold":
                            return new FontWeight { Enum = PurpleFontWeight.Bold };
                        case "bolder":
                            return new FontWeight { Enum = PurpleFontWeight.Bolder };
                        case "lighter":
                            return new FontWeight { Enum = PurpleFontWeight.Lighter };
                        case "normal":
                            return new FontWeight { Enum = PurpleFontWeight.Normal };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type FontWeight");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FontWeight)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleFontWeight.Bold:
                        serializer.Serialize(writer, "bold");
                        return;
                    case PurpleFontWeight.Bolder:
                        serializer.Serialize(writer, "bolder");
                        return;
                    case PurpleFontWeight.Lighter:
                        serializer.Serialize(writer, "lighter");
                        return;
                    case PurpleFontWeight.Normal:
                        serializer.Serialize(writer, "normal");
                        return;
                }
            }
            throw new Exception("Cannot marshal type FontWeight");
        }

        public static readonly FontWeightConverter Singleton = new FontWeightConverter();
    }

    internal class PurpleFontWeightConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleFontWeight) || t == typeof(PurpleFontWeight?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bold":
                    return PurpleFontWeight.Bold;
                case "bolder":
                    return PurpleFontWeight.Bolder;
                case "lighter":
                    return PurpleFontWeight.Lighter;
                case "normal":
                    return PurpleFontWeight.Normal;
            }
            throw new Exception("Cannot unmarshal type PurpleFontWeight");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleFontWeight)untypedValue;
            switch (value)
            {
                case PurpleFontWeight.Bold:
                    serializer.Serialize(writer, "bold");
                    return;
                case PurpleFontWeight.Bolder:
                    serializer.Serialize(writer, "bolder");
                    return;
                case PurpleFontWeight.Lighter:
                    serializer.Serialize(writer, "lighter");
                    return;
                case PurpleFontWeight.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleFontWeight");
        }

        public static readonly PurpleFontWeightConverter Singleton = new PurpleFontWeightConverter();
    }

    internal class LabelOverlapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelOverlap) || t == typeof(LabelOverlap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new LabelOverlap { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "greedy":
                            return new LabelOverlap { Enum = LabelOverlapEnum.Greedy };
                        case "parity":
                            return new LabelOverlap { Enum = LabelOverlapEnum.Parity };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type LabelOverlap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelOverlap)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LabelOverlapEnum.Greedy:
                        serializer.Serialize(writer, "greedy");
                        return;
                    case LabelOverlapEnum.Parity:
                        serializer.Serialize(writer, "parity");
                        return;
                }
            }
            throw new Exception("Cannot marshal type LabelOverlap");
        }

        public static readonly LabelOverlapConverter Singleton = new LabelOverlapConverter();
    }

    internal class LabelOverlapEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelOverlapEnum) || t == typeof(LabelOverlapEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "greedy":
                    return LabelOverlapEnum.Greedy;
                case "parity":
                    return LabelOverlapEnum.Parity;
            }
            throw new Exception("Cannot unmarshal type LabelOverlapEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelOverlapEnum)untypedValue;
            switch (value)
            {
                case LabelOverlapEnum.Greedy:
                    serializer.Serialize(writer, "greedy");
                    return;
                case LabelOverlapEnum.Parity:
                    serializer.Serialize(writer, "parity");
                    return;
            }
            throw new Exception("Cannot marshal type LabelOverlapEnum");
        }

        public static readonly LabelOverlapEnumConverter Singleton = new LabelOverlapEnumConverter();
    }

    internal class LegendOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendOrient) || t == typeof(LegendOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return LegendOrient.Bottom;
                case "bottom-left":
                    return LegendOrient.BottomLeft;
                case "bottom-right":
                    return LegendOrient.BottomRight;
                case "left":
                    return LegendOrient.Left;
                case "none":
                    return LegendOrient.None;
                case "right":
                    return LegendOrient.Right;
                case "top":
                    return LegendOrient.Top;
                case "top-left":
                    return LegendOrient.TopLeft;
                case "top-right":
                    return LegendOrient.TopRight;
            }
            throw new Exception("Cannot unmarshal type LegendOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegendOrient)untypedValue;
            switch (value)
            {
                case LegendOrient.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case LegendOrient.BottomLeft:
                    serializer.Serialize(writer, "bottom-left");
                    return;
                case LegendOrient.BottomRight:
                    serializer.Serialize(writer, "bottom-right");
                    return;
                case LegendOrient.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case LegendOrient.None:
                    serializer.Serialize(writer, "none");
                    return;
                case LegendOrient.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case LegendOrient.Top:
                    serializer.Serialize(writer, "top");
                    return;
                case LegendOrient.TopLeft:
                    serializer.Serialize(writer, "top-left");
                    return;
                case LegendOrient.TopRight:
                    serializer.Serialize(writer, "top-right");
                    return;
            }
            throw new Exception("Cannot marshal type LegendOrient");
        }

        public static readonly LegendOrientConverter Singleton = new LegendOrientConverter();
    }

    internal class TickCountConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickCount) || t == typeof(TickCount?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TickCount { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new TickCount { Enum = TimeInterval.Day };
                        case "hour":
                            return new TickCount { Enum = TimeInterval.Hour };
                        case "millisecond":
                            return new TickCount { Enum = TimeInterval.Millisecond };
                        case "minute":
                            return new TickCount { Enum = TimeInterval.Minute };
                        case "month":
                            return new TickCount { Enum = TimeInterval.Month };
                        case "second":
                            return new TickCount { Enum = TimeInterval.Second };
                        case "week":
                            return new TickCount { Enum = TimeInterval.Week };
                        case "year":
                            return new TickCount { Enum = TimeInterval.Year };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type TickCount");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TickCount)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TimeInterval.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case TimeInterval.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case TimeInterval.Millisecond:
                        serializer.Serialize(writer, "millisecond");
                        return;
                    case TimeInterval.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case TimeInterval.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case TimeInterval.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case TimeInterval.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case TimeInterval.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            throw new Exception("Cannot marshal type TickCount");
        }

        public static readonly TickCountConverter Singleton = new TickCountConverter();
    }

    internal class TimeIntervalConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimeInterval) || t == typeof(TimeInterval?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "day":
                    return TimeInterval.Day;
                case "hour":
                    return TimeInterval.Hour;
                case "millisecond":
                    return TimeInterval.Millisecond;
                case "minute":
                    return TimeInterval.Minute;
                case "month":
                    return TimeInterval.Month;
                case "second":
                    return TimeInterval.Second;
                case "week":
                    return TimeInterval.Week;
                case "year":
                    return TimeInterval.Year;
            }
            throw new Exception("Cannot unmarshal type TimeInterval");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TimeInterval)untypedValue;
            switch (value)
            {
                case TimeInterval.Day:
                    serializer.Serialize(writer, "day");
                    return;
                case TimeInterval.Hour:
                    serializer.Serialize(writer, "hour");
                    return;
                case TimeInterval.Millisecond:
                    serializer.Serialize(writer, "millisecond");
                    return;
                case TimeInterval.Minute:
                    serializer.Serialize(writer, "minute");
                    return;
                case TimeInterval.Month:
                    serializer.Serialize(writer, "month");
                    return;
                case TimeInterval.Second:
                    serializer.Serialize(writer, "second");
                    return;
                case TimeInterval.Week:
                    serializer.Serialize(writer, "week");
                    return;
                case TimeInterval.Year:
                    serializer.Serialize(writer, "year");
                    return;
            }
            throw new Exception("Cannot marshal type TimeInterval");
        }

        public static readonly TimeIntervalConverter Singleton = new TimeIntervalConverter();
    }

    internal class PurpleTextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleText) || t == typeof(PurpleText?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new PurpleText { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new PurpleText { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new PurpleText { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleText");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleText)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type PurpleText");
        }

        public static readonly PurpleTextConverter Singleton = new PurpleTextConverter();
    }

    internal class TitleAnchorEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleAnchorEnum) || t == typeof(TitleAnchorEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "end":
                    return TitleAnchorEnum.End;
                case "middle":
                    return TitleAnchorEnum.Middle;
                case "start":
                    return TitleAnchorEnum.Start;
            }
            throw new Exception("Cannot unmarshal type TitleAnchorEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TitleAnchorEnum)untypedValue;
            switch (value)
            {
                case TitleAnchorEnum.End:
                    serializer.Serialize(writer, "end");
                    return;
                case TitleAnchorEnum.Middle:
                    serializer.Serialize(writer, "middle");
                    return;
                case TitleAnchorEnum.Start:
                    serializer.Serialize(writer, "start");
                    return;
            }
            throw new Exception("Cannot marshal type TitleAnchorEnum");
        }

        public static readonly TitleAnchorEnumConverter Singleton = new TitleAnchorEnumConverter();
    }

    internal class OrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Orient) || t == typeof(Orient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return Orient.Bottom;
                case "left":
                    return Orient.Left;
                case "right":
                    return Orient.Right;
                case "top":
                    return Orient.Top;
            }
            throw new Exception("Cannot unmarshal type Orient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Orient)untypedValue;
            switch (value)
            {
                case Orient.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case Orient.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case Orient.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case Orient.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type Orient");
        }

        public static readonly OrientConverter Singleton = new OrientConverter();
    }

    internal class LegendTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendType) || t == typeof(LegendType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "gradient":
                    return LegendType.Gradient;
                case "symbol":
                    return LegendType.Symbol;
            }
            throw new Exception("Cannot unmarshal type LegendType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegendType)untypedValue;
            switch (value)
            {
                case LegendType.Gradient:
                    serializer.Serialize(writer, "gradient");
                    return;
                case LegendType.Symbol:
                    serializer.Serialize(writer, "symbol");
                    return;
            }
            throw new Exception("Cannot marshal type LegendType");
        }

        public static readonly LegendTypeConverter Singleton = new LegendTypeConverter();
    }

    internal class DomainUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainUnion) || t == typeof(DomainUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "unaggregated")
                    {
                        return new DomainUnion { Enum = Domain.Unaggregated };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DomainClass>(reader);
                    return new DomainUnion { DomainClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Equal>>(reader);
                    return new DomainUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DomainUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainUnion)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == Domain.Unaggregated)
                {
                    serializer.Serialize(writer, "unaggregated");
                    return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.DomainClass != null)
            {
                serializer.Serialize(writer, value.DomainClass);
                return;
            }
            throw new Exception("Cannot marshal type DomainUnion");
        }

        public static readonly DomainUnionConverter Singleton = new DomainUnionConverter();
    }

    internal class DomainConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Domain) || t == typeof(Domain?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "unaggregated")
            {
                return Domain.Unaggregated;
            }
            throw new Exception("Cannot unmarshal type Domain");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Domain)untypedValue;
            if (value == Domain.Unaggregated)
            {
                serializer.Serialize(writer, "unaggregated");
                return;
            }
            throw new Exception("Cannot marshal type Domain");
        }

        public static readonly DomainConverter Singleton = new DomainConverter();
    }

    internal class InterpolateUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InterpolateUnion) || t == typeof(InterpolateUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "cubehelix":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Cubehelix };
                        case "cubehelix-long":
                            return new InterpolateUnion { Enum = ScaleInterpolate.CubehelixLong };
                        case "hcl":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Hcl };
                        case "hcl-long":
                            return new InterpolateUnion { Enum = ScaleInterpolate.HclLong };
                        case "hsl":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Hsl };
                        case "hsl-long":
                            return new InterpolateUnion { Enum = ScaleInterpolate.HslLong };
                        case "lab":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Lab };
                        case "rgb":
                            return new InterpolateUnion { Enum = ScaleInterpolate.Rgb };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ScaleInterpolateParams>(reader);
                    return new InterpolateUnion { ScaleInterpolateParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type InterpolateUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InterpolateUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ScaleInterpolate.Cubehelix:
                        serializer.Serialize(writer, "cubehelix");
                        return;
                    case ScaleInterpolate.CubehelixLong:
                        serializer.Serialize(writer, "cubehelix-long");
                        return;
                    case ScaleInterpolate.Hcl:
                        serializer.Serialize(writer, "hcl");
                        return;
                    case ScaleInterpolate.HclLong:
                        serializer.Serialize(writer, "hcl-long");
                        return;
                    case ScaleInterpolate.Hsl:
                        serializer.Serialize(writer, "hsl");
                        return;
                    case ScaleInterpolate.HslLong:
                        serializer.Serialize(writer, "hsl-long");
                        return;
                    case ScaleInterpolate.Lab:
                        serializer.Serialize(writer, "lab");
                        return;
                    case ScaleInterpolate.Rgb:
                        serializer.Serialize(writer, "rgb");
                        return;
                }
            }
            if (value.ScaleInterpolateParams != null)
            {
                serializer.Serialize(writer, value.ScaleInterpolateParams);
                return;
            }
            throw new Exception("Cannot marshal type InterpolateUnion");
        }

        public static readonly InterpolateUnionConverter Singleton = new InterpolateUnionConverter();
    }

    internal class ScaleInterpolateParamsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleInterpolateParamsType) || t == typeof(ScaleInterpolateParamsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "cubehelix":
                    return ScaleInterpolateParamsType.Cubehelix;
                case "cubehelix-long":
                    return ScaleInterpolateParamsType.CubehelixLong;
                case "rgb":
                    return ScaleInterpolateParamsType.Rgb;
            }
            throw new Exception("Cannot unmarshal type ScaleInterpolateParamsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleInterpolateParamsType)untypedValue;
            switch (value)
            {
                case ScaleInterpolateParamsType.Cubehelix:
                    serializer.Serialize(writer, "cubehelix");
                    return;
                case ScaleInterpolateParamsType.CubehelixLong:
                    serializer.Serialize(writer, "cubehelix-long");
                    return;
                case ScaleInterpolateParamsType.Rgb:
                    serializer.Serialize(writer, "rgb");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleInterpolateParamsType");
        }

        public static readonly ScaleInterpolateParamsTypeConverter Singleton = new ScaleInterpolateParamsTypeConverter();
    }

    internal class ScaleInterpolateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleInterpolate) || t == typeof(ScaleInterpolate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "cubehelix":
                    return ScaleInterpolate.Cubehelix;
                case "cubehelix-long":
                    return ScaleInterpolate.CubehelixLong;
                case "hcl":
                    return ScaleInterpolate.Hcl;
                case "hcl-long":
                    return ScaleInterpolate.HclLong;
                case "hsl":
                    return ScaleInterpolate.Hsl;
                case "hsl-long":
                    return ScaleInterpolate.HslLong;
                case "lab":
                    return ScaleInterpolate.Lab;
                case "rgb":
                    return ScaleInterpolate.Rgb;
            }
            throw new Exception("Cannot unmarshal type ScaleInterpolate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleInterpolate)untypedValue;
            switch (value)
            {
                case ScaleInterpolate.Cubehelix:
                    serializer.Serialize(writer, "cubehelix");
                    return;
                case ScaleInterpolate.CubehelixLong:
                    serializer.Serialize(writer, "cubehelix-long");
                    return;
                case ScaleInterpolate.Hcl:
                    serializer.Serialize(writer, "hcl");
                    return;
                case ScaleInterpolate.HclLong:
                    serializer.Serialize(writer, "hcl-long");
                    return;
                case ScaleInterpolate.Hsl:
                    serializer.Serialize(writer, "hsl");
                    return;
                case ScaleInterpolate.HslLong:
                    serializer.Serialize(writer, "hsl-long");
                    return;
                case ScaleInterpolate.Lab:
                    serializer.Serialize(writer, "lab");
                    return;
                case ScaleInterpolate.Rgb:
                    serializer.Serialize(writer, "rgb");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleInterpolate");
        }

        public static readonly ScaleInterpolateConverter Singleton = new ScaleInterpolateConverter();
    }

    internal class NiceUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NiceUnion) || t == typeof(NiceUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new NiceUnion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new NiceUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new NiceUnion { Enum = NiceTime.Day };
                        case "hour":
                            return new NiceUnion { Enum = NiceTime.Hour };
                        case "minute":
                            return new NiceUnion { Enum = NiceTime.Minute };
                        case "month":
                            return new NiceUnion { Enum = NiceTime.Month };
                        case "second":
                            return new NiceUnion { Enum = NiceTime.Second };
                        case "week":
                            return new NiceUnion { Enum = NiceTime.Week };
                        case "year":
                            return new NiceUnion { Enum = NiceTime.Year };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<NiceClass>(reader);
                    return new NiceUnion { NiceClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type NiceUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (NiceUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case NiceTime.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case NiceTime.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case NiceTime.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case NiceTime.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case NiceTime.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case NiceTime.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case NiceTime.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            if (value.NiceClass != null)
            {
                serializer.Serialize(writer, value.NiceClass);
                return;
            }
            throw new Exception("Cannot marshal type NiceUnion");
        }

        public static readonly NiceUnionConverter Singleton = new NiceUnionConverter();
    }

    internal class NiceTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NiceTime) || t == typeof(NiceTime?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "day":
                    return NiceTime.Day;
                case "hour":
                    return NiceTime.Hour;
                case "minute":
                    return NiceTime.Minute;
                case "month":
                    return NiceTime.Month;
                case "second":
                    return NiceTime.Second;
                case "week":
                    return NiceTime.Week;
                case "year":
                    return NiceTime.Year;
            }
            throw new Exception("Cannot unmarshal type NiceTime");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NiceTime)untypedValue;
            switch (value)
            {
                case NiceTime.Day:
                    serializer.Serialize(writer, "day");
                    return;
                case NiceTime.Hour:
                    serializer.Serialize(writer, "hour");
                    return;
                case NiceTime.Minute:
                    serializer.Serialize(writer, "minute");
                    return;
                case NiceTime.Month:
                    serializer.Serialize(writer, "month");
                    return;
                case NiceTime.Second:
                    serializer.Serialize(writer, "second");
                    return;
                case NiceTime.Week:
                    serializer.Serialize(writer, "week");
                    return;
                case NiceTime.Year:
                    serializer.Serialize(writer, "year");
                    return;
            }
            throw new Exception("Cannot marshal type NiceTime");
        }

        public static readonly NiceTimeConverter Singleton = new NiceTimeConverter();
    }

    internal class ScaleRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleRange) || t == typeof(ScaleRange?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new ScaleRange { Enum = RangeEnum.Category };
                        case "diverging":
                            return new ScaleRange { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new ScaleRange { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new ScaleRange { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new ScaleRange { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new ScaleRange { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new ScaleRange { Enum = RangeEnum.Symbol };
                        case "width":
                            return new ScaleRange { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRange>>(reader);
                    return new ScaleRange { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ScaleRange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ScaleRange)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            throw new Exception("Cannot marshal type ScaleRange");
        }

        public static readonly ScaleRangeConverter Singleton = new ScaleRangeConverter();
    }

    internal class RangeRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeRange) || t == typeof(RangeRange?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new RangeRange { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new RangeRange { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type RangeRange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeRange)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type RangeRange");
        }

        public static readonly RangeRangeConverter Singleton = new RangeRangeConverter();
    }

    internal class RangeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeEnum) || t == typeof(RangeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "category":
                    return RangeEnum.Category;
                case "diverging":
                    return RangeEnum.Diverging;
                case "heatmap":
                    return RangeEnum.Heatmap;
                case "height":
                    return RangeEnum.Height;
                case "ordinal":
                    return RangeEnum.Ordinal;
                case "ramp":
                    return RangeEnum.Ramp;
                case "symbol":
                    return RangeEnum.Symbol;
                case "width":
                    return RangeEnum.Width;
            }
            throw new Exception("Cannot unmarshal type RangeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RangeEnum)untypedValue;
            switch (value)
            {
                case RangeEnum.Category:
                    serializer.Serialize(writer, "category");
                    return;
                case RangeEnum.Diverging:
                    serializer.Serialize(writer, "diverging");
                    return;
                case RangeEnum.Heatmap:
                    serializer.Serialize(writer, "heatmap");
                    return;
                case RangeEnum.Height:
                    serializer.Serialize(writer, "height");
                    return;
                case RangeEnum.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case RangeEnum.Ramp:
                    serializer.Serialize(writer, "ramp");
                    return;
                case RangeEnum.Symbol:
                    serializer.Serialize(writer, "symbol");
                    return;
                case RangeEnum.Width:
                    serializer.Serialize(writer, "width");
                    return;
            }
            throw new Exception("Cannot marshal type RangeEnum");
        }

        public static readonly RangeEnumConverter Singleton = new RangeEnumConverter();
    }

    internal class SchemeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Scheme) || t == typeof(Scheme?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Scheme { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SchemeParams>(reader);
                    return new Scheme { SchemeParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type Scheme");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Scheme)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.SchemeParams != null)
            {
                serializer.Serialize(writer, value.SchemeParams);
                return;
            }
            throw new Exception("Cannot marshal type Scheme");
        }

        public static readonly SchemeConverter Singleton = new SchemeConverter();
    }

    internal class ScaleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleType) || t == typeof(ScaleType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "band":
                    return ScaleType.Band;
                case "bin-ordinal":
                    return ScaleType.BinOrdinal;
                case "linear":
                    return ScaleType.Linear;
                case "log":
                    return ScaleType.Log;
                case "ordinal":
                    return ScaleType.Ordinal;
                case "point":
                    return ScaleType.Point;
                case "pow":
                    return ScaleType.Pow;
                case "quantile":
                    return ScaleType.Quantile;
                case "quantize":
                    return ScaleType.Quantize;
                case "sqrt":
                    return ScaleType.Sqrt;
                case "symlog":
                    return ScaleType.Symlog;
                case "threshold":
                    return ScaleType.Threshold;
                case "time":
                    return ScaleType.Time;
                case "utc":
                    return ScaleType.Utc;
            }
            throw new Exception("Cannot unmarshal type ScaleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleType)untypedValue;
            switch (value)
            {
                case ScaleType.Band:
                    serializer.Serialize(writer, "band");
                    return;
                case ScaleType.BinOrdinal:
                    serializer.Serialize(writer, "bin-ordinal");
                    return;
                case ScaleType.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case ScaleType.Log:
                    serializer.Serialize(writer, "log");
                    return;
                case ScaleType.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case ScaleType.Point:
                    serializer.Serialize(writer, "point");
                    return;
                case ScaleType.Pow:
                    serializer.Serialize(writer, "pow");
                    return;
                case ScaleType.Quantile:
                    serializer.Serialize(writer, "quantile");
                    return;
                case ScaleType.Quantize:
                    serializer.Serialize(writer, "quantize");
                    return;
                case ScaleType.Sqrt:
                    serializer.Serialize(writer, "sqrt");
                    return;
                case ScaleType.Symlog:
                    serializer.Serialize(writer, "symlog");
                    return;
                case ScaleType.Threshold:
                    serializer.Serialize(writer, "threshold");
                    return;
                case ScaleType.Time:
                    serializer.Serialize(writer, "time");
                    return;
                case ScaleType.Utc:
                    serializer.Serialize(writer, "utc");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleType");
        }

        public static readonly ScaleTypeConverter Singleton = new ScaleTypeConverter();
    }

    internal class SortUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortUnion) || t == typeof(SortUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new SortUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "-color":
                            return new SortUnion { Enum = Sort.SortColor };
                        case "-fill":
                            return new SortUnion { Enum = Sort.SortFill };
                        case "-fillOpacity":
                            return new SortUnion { Enum = Sort.SortFillOpacity };
                        case "-opacity":
                            return new SortUnion { Enum = Sort.SortOpacity };
                        case "-shape":
                            return new SortUnion { Enum = Sort.SortShape };
                        case "-size":
                            return new SortUnion { Enum = Sort.SortSize };
                        case "-stroke":
                            return new SortUnion { Enum = Sort.SortStroke };
                        case "-strokeOpacity":
                            return new SortUnion { Enum = Sort.SortStrokeOpacity };
                        case "-strokeWidth":
                            return new SortUnion { Enum = Sort.SortStrokeWidth };
                        case "-text":
                            return new SortUnion { Enum = Sort.SortText };
                        case "-x":
                            return new SortUnion { Enum = Sort.SortX };
                        case "-y":
                            return new SortUnion { Enum = Sort.SortY };
                        case "ascending":
                            return new SortUnion { Enum = Sort.Ascending };
                        case "color":
                            return new SortUnion { Enum = Sort.Color };
                        case "descending":
                            return new SortUnion { Enum = Sort.Descending };
                        case "fill":
                            return new SortUnion { Enum = Sort.Fill };
                        case "fillOpacity":
                            return new SortUnion { Enum = Sort.FillOpacity };
                        case "opacity":
                            return new SortUnion { Enum = Sort.Opacity };
                        case "shape":
                            return new SortUnion { Enum = Sort.Shape };
                        case "size":
                            return new SortUnion { Enum = Sort.Size };
                        case "stroke":
                            return new SortUnion { Enum = Sort.Stroke };
                        case "strokeOpacity":
                            return new SortUnion { Enum = Sort.StrokeOpacity };
                        case "strokeWidth":
                            return new SortUnion { Enum = Sort.StrokeWidth };
                        case "text":
                            return new SortUnion { Enum = Sort.Text };
                        case "x":
                            return new SortUnion { Enum = Sort.X };
                        case "y":
                            return new SortUnion { Enum = Sort.Y };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EncodingSortField>(reader);
                    return new SortUnion { EncodingSortField = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Equal>>(reader);
                    return new SortUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SortUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SortUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Sort.SortColor:
                        serializer.Serialize(writer, "-color");
                        return;
                    case Sort.SortFill:
                        serializer.Serialize(writer, "-fill");
                        return;
                    case Sort.SortFillOpacity:
                        serializer.Serialize(writer, "-fillOpacity");
                        return;
                    case Sort.SortOpacity:
                        serializer.Serialize(writer, "-opacity");
                        return;
                    case Sort.SortShape:
                        serializer.Serialize(writer, "-shape");
                        return;
                    case Sort.SortSize:
                        serializer.Serialize(writer, "-size");
                        return;
                    case Sort.SortStroke:
                        serializer.Serialize(writer, "-stroke");
                        return;
                    case Sort.SortStrokeOpacity:
                        serializer.Serialize(writer, "-strokeOpacity");
                        return;
                    case Sort.SortStrokeWidth:
                        serializer.Serialize(writer, "-strokeWidth");
                        return;
                    case Sort.SortText:
                        serializer.Serialize(writer, "-text");
                        return;
                    case Sort.SortX:
                        serializer.Serialize(writer, "-x");
                        return;
                    case Sort.SortY:
                        serializer.Serialize(writer, "-y");
                        return;
                    case Sort.Ascending:
                        serializer.Serialize(writer, "ascending");
                        return;
                    case Sort.Color:
                        serializer.Serialize(writer, "color");
                        return;
                    case Sort.Descending:
                        serializer.Serialize(writer, "descending");
                        return;
                    case Sort.Fill:
                        serializer.Serialize(writer, "fill");
                        return;
                    case Sort.FillOpacity:
                        serializer.Serialize(writer, "fillOpacity");
                        return;
                    case Sort.Opacity:
                        serializer.Serialize(writer, "opacity");
                        return;
                    case Sort.Shape:
                        serializer.Serialize(writer, "shape");
                        return;
                    case Sort.Size:
                        serializer.Serialize(writer, "size");
                        return;
                    case Sort.Stroke:
                        serializer.Serialize(writer, "stroke");
                        return;
                    case Sort.StrokeOpacity:
                        serializer.Serialize(writer, "strokeOpacity");
                        return;
                    case Sort.StrokeWidth:
                        serializer.Serialize(writer, "strokeWidth");
                        return;
                    case Sort.Text:
                        serializer.Serialize(writer, "text");
                        return;
                    case Sort.X:
                        serializer.Serialize(writer, "x");
                        return;
                    case Sort.Y:
                        serializer.Serialize(writer, "y");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.EncodingSortField != null)
            {
                serializer.Serialize(writer, value.EncodingSortField);
                return;
            }
            throw new Exception("Cannot marshal type SortUnion");
        }

        public static readonly SortUnionConverter Singleton = new SortUnionConverter();
    }

    internal class SortByChannelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortByChannel) || t == typeof(SortByChannel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "color":
                    return SortByChannel.Color;
                case "fill":
                    return SortByChannel.Fill;
                case "fillOpacity":
                    return SortByChannel.FillOpacity;
                case "opacity":
                    return SortByChannel.Opacity;
                case "shape":
                    return SortByChannel.Shape;
                case "size":
                    return SortByChannel.Size;
                case "stroke":
                    return SortByChannel.Stroke;
                case "strokeOpacity":
                    return SortByChannel.StrokeOpacity;
                case "strokeWidth":
                    return SortByChannel.StrokeWidth;
                case "text":
                    return SortByChannel.Text;
                case "x":
                    return SortByChannel.X;
                case "y":
                    return SortByChannel.Y;
            }
            throw new Exception("Cannot unmarshal type SortByChannel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SortByChannel)untypedValue;
            switch (value)
            {
                case SortByChannel.Color:
                    serializer.Serialize(writer, "color");
                    return;
                case SortByChannel.Fill:
                    serializer.Serialize(writer, "fill");
                    return;
                case SortByChannel.FillOpacity:
                    serializer.Serialize(writer, "fillOpacity");
                    return;
                case SortByChannel.Opacity:
                    serializer.Serialize(writer, "opacity");
                    return;
                case SortByChannel.Shape:
                    serializer.Serialize(writer, "shape");
                    return;
                case SortByChannel.Size:
                    serializer.Serialize(writer, "size");
                    return;
                case SortByChannel.Stroke:
                    serializer.Serialize(writer, "stroke");
                    return;
                case SortByChannel.StrokeOpacity:
                    serializer.Serialize(writer, "strokeOpacity");
                    return;
                case SortByChannel.StrokeWidth:
                    serializer.Serialize(writer, "strokeWidth");
                    return;
                case SortByChannel.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case SortByChannel.X:
                    serializer.Serialize(writer, "x");
                    return;
                case SortByChannel.Y:
                    serializer.Serialize(writer, "y");
                    return;
            }
            throw new Exception("Cannot marshal type SortByChannel");
        }

        public static readonly SortByChannelConverter Singleton = new SortByChannelConverter();
    }

    internal class SortOrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortOrder) || t == typeof(SortOrder?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ascending":
                    return SortOrder.Ascending;
                case "descending":
                    return SortOrder.Descending;
            }
            throw new Exception("Cannot unmarshal type SortOrder");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SortOrder)untypedValue;
            switch (value)
            {
                case SortOrder.Ascending:
                    serializer.Serialize(writer, "ascending");
                    return;
                case SortOrder.Descending:
                    serializer.Serialize(writer, "descending");
                    return;
            }
            throw new Exception("Cannot marshal type SortOrder");
        }

        public static readonly SortOrderConverter Singleton = new SortOrderConverter();
    }

    internal class SortConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Sort) || t == typeof(Sort?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "-color":
                    return Sort.SortColor;
                case "-fill":
                    return Sort.SortFill;
                case "-fillOpacity":
                    return Sort.SortFillOpacity;
                case "-opacity":
                    return Sort.SortOpacity;
                case "-shape":
                    return Sort.SortShape;
                case "-size":
                    return Sort.SortSize;
                case "-stroke":
                    return Sort.SortStroke;
                case "-strokeOpacity":
                    return Sort.SortStrokeOpacity;
                case "-strokeWidth":
                    return Sort.SortStrokeWidth;
                case "-text":
                    return Sort.SortText;
                case "-x":
                    return Sort.SortX;
                case "-y":
                    return Sort.SortY;
                case "ascending":
                    return Sort.Ascending;
                case "color":
                    return Sort.Color;
                case "descending":
                    return Sort.Descending;
                case "fill":
                    return Sort.Fill;
                case "fillOpacity":
                    return Sort.FillOpacity;
                case "opacity":
                    return Sort.Opacity;
                case "shape":
                    return Sort.Shape;
                case "size":
                    return Sort.Size;
                case "stroke":
                    return Sort.Stroke;
                case "strokeOpacity":
                    return Sort.StrokeOpacity;
                case "strokeWidth":
                    return Sort.StrokeWidth;
                case "text":
                    return Sort.Text;
                case "x":
                    return Sort.X;
                case "y":
                    return Sort.Y;
            }
            throw new Exception("Cannot unmarshal type Sort");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Sort)untypedValue;
            switch (value)
            {
                case Sort.SortColor:
                    serializer.Serialize(writer, "-color");
                    return;
                case Sort.SortFill:
                    serializer.Serialize(writer, "-fill");
                    return;
                case Sort.SortFillOpacity:
                    serializer.Serialize(writer, "-fillOpacity");
                    return;
                case Sort.SortOpacity:
                    serializer.Serialize(writer, "-opacity");
                    return;
                case Sort.SortShape:
                    serializer.Serialize(writer, "-shape");
                    return;
                case Sort.SortSize:
                    serializer.Serialize(writer, "-size");
                    return;
                case Sort.SortStroke:
                    serializer.Serialize(writer, "-stroke");
                    return;
                case Sort.SortStrokeOpacity:
                    serializer.Serialize(writer, "-strokeOpacity");
                    return;
                case Sort.SortStrokeWidth:
                    serializer.Serialize(writer, "-strokeWidth");
                    return;
                case Sort.SortText:
                    serializer.Serialize(writer, "-text");
                    return;
                case Sort.SortX:
                    serializer.Serialize(writer, "-x");
                    return;
                case Sort.SortY:
                    serializer.Serialize(writer, "-y");
                    return;
                case Sort.Ascending:
                    serializer.Serialize(writer, "ascending");
                    return;
                case Sort.Color:
                    serializer.Serialize(writer, "color");
                    return;
                case Sort.Descending:
                    serializer.Serialize(writer, "descending");
                    return;
                case Sort.Fill:
                    serializer.Serialize(writer, "fill");
                    return;
                case Sort.FillOpacity:
                    serializer.Serialize(writer, "fillOpacity");
                    return;
                case Sort.Opacity:
                    serializer.Serialize(writer, "opacity");
                    return;
                case Sort.Shape:
                    serializer.Serialize(writer, "shape");
                    return;
                case Sort.Size:
                    serializer.Serialize(writer, "size");
                    return;
                case Sort.Stroke:
                    serializer.Serialize(writer, "stroke");
                    return;
                case Sort.StrokeOpacity:
                    serializer.Serialize(writer, "strokeOpacity");
                    return;
                case Sort.StrokeWidth:
                    serializer.Serialize(writer, "strokeWidth");
                    return;
                case Sort.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case Sort.X:
                    serializer.Serialize(writer, "x");
                    return;
                case Sort.Y:
                    serializer.Serialize(writer, "y");
                    return;
            }
            throw new Exception("Cannot marshal type Sort");
        }

        public static readonly SortConverter Singleton = new SortConverter();
    }

    internal class StandardTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StandardType) || t == typeof(StandardType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "nominal":
                    return StandardType.Nominal;
                case "ordinal":
                    return StandardType.Ordinal;
                case "quantitative":
                    return StandardType.Quantitative;
                case "temporal":
                    return StandardType.Temporal;
            }
            throw new Exception("Cannot unmarshal type StandardType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StandardType)untypedValue;
            switch (value)
            {
                case StandardType.Nominal:
                    serializer.Serialize(writer, "nominal");
                    return;
                case StandardType.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case StandardType.Quantitative:
                    serializer.Serialize(writer, "quantitative");
                    return;
                case StandardType.Temporal:
                    serializer.Serialize(writer, "temporal");
                    return;
            }
            throw new Exception("Cannot marshal type StandardType");
        }

        public static readonly StandardTypeConverter Singleton = new StandardTypeConverter();
    }

    internal class SortArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortArray) || t == typeof(SortArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new SortArray { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "ascending":
                            return new SortArray { Enum = SortOrder.Ascending };
                        case "descending":
                            return new SortArray { Enum = SortOrder.Descending };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SortEncodingSortField>(reader);
                    return new SortArray { SortEncodingSortField = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Equal>>(reader);
                    return new SortArray { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SortArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SortArray)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case SortOrder.Ascending:
                        serializer.Serialize(writer, "ascending");
                        return;
                    case SortOrder.Descending:
                        serializer.Serialize(writer, "descending");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.SortEncodingSortField != null)
            {
                serializer.Serialize(writer, value.SortEncodingSortField);
                return;
            }
            throw new Exception("Cannot marshal type SortArray");
        }

        public static readonly SortArrayConverter Singleton = new SortArrayConverter();
    }

    internal class DetailConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Detail) || t == typeof(Detail?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TypedFieldDef>(reader);
                    return new Detail { TypedFieldDef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TypedFieldDef>>(reader);
                    return new Detail { TypedFieldDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Detail");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Detail)untypedValue;
            if (value.TypedFieldDefArray != null)
            {
                serializer.Serialize(writer, value.TypedFieldDefArray);
                return;
            }
            if (value.TypedFieldDef != null)
            {
                serializer.Serialize(writer, value.TypedFieldDef);
                return;
            }
            throw new Exception("Cannot marshal type Detail");
        }

        public static readonly DetailConverter Singleton = new DetailConverter();
    }

    internal class FluffyBinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyBin) || t == typeof(FluffyBin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FluffyBin { };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new FluffyBin { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "binned")
                    {
                        return new FluffyBin { Enum = BinEnum.Binned };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinParams>(reader);
                    return new FluffyBin { BinParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type FluffyBin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FluffyBin)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == BinEnum.Binned)
                {
                    serializer.Serialize(writer, "binned");
                    return;
                }
            }
            if (value.BinParams != null)
            {
                serializer.Serialize(writer, value.BinParams);
                return;
            }
            throw new Exception("Cannot marshal type FluffyBin");
        }

        public static readonly FluffyBinConverter Singleton = new FluffyBinConverter();
    }

    internal class BinEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BinEnum) || t == typeof(BinEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "binned")
            {
                return BinEnum.Binned;
            }
            throw new Exception("Cannot unmarshal type BinEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BinEnum)untypedValue;
            if (value == BinEnum.Binned)
            {
                serializer.Serialize(writer, "binned");
                return;
            }
            throw new Exception("Cannot marshal type BinEnum");
        }

        public static readonly BinEnumConverter Singleton = new BinEnumConverter();
    }

    internal class SpacingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Spacing) || t == typeof(Spacing?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Spacing { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RowColNumber>(reader);
                    return new Spacing { RowColNumber = objectValue };
            }
            throw new Exception("Cannot unmarshal type Spacing");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Spacing)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.RowColNumber != null)
            {
                serializer.Serialize(writer, value.RowColNumber);
                return;
            }
            throw new Exception("Cannot marshal type Spacing");
        }

        public static readonly SpacingConverter Singleton = new SpacingConverter();
    }

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

    internal class HrefConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HrefCondition) || t == typeof(HrefCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefStringClass>(reader);
                    return new HrefCondition { ConditionalPredicateValueDefStringClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionElement>>(reader);
                    return new HrefCondition { ConditionElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type HrefCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HrefCondition)untypedValue;
            if (value.ConditionElementArray != null)
            {
                serializer.Serialize(writer, value.ConditionElementArray);
                return;
            }
            if (value.ConditionalPredicateValueDefStringClass != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefStringClass);
                return;
            }
            throw new Exception("Cannot marshal type HrefCondition");
        }

        public static readonly HrefConditionConverter Singleton = new HrefConditionConverter();
    }

    internal class LatitudeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LatitudeType) || t == typeof(LatitudeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "quantitative")
            {
                return LatitudeType.Quantitative;
            }
            throw new Exception("Cannot unmarshal type LatitudeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LatitudeType)untypedValue;
            if (value == LatitudeType.Quantitative)
            {
                serializer.Serialize(writer, "quantitative");
                return;
            }
            throw new Exception("Cannot marshal type LatitudeType");
        }

        public static readonly LatitudeTypeConverter Singleton = new LatitudeTypeConverter();
    }

    internal class OrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Order) || t == typeof(Order?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OrderFieldDefClass>(reader);
                    return new Order { OrderFieldDefClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<OrderFieldDef>>(reader);
                    return new Order { OrderFieldDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Order");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Order)untypedValue;
            if (value.OrderFieldDefArray != null)
            {
                serializer.Serialize(writer, value.OrderFieldDefArray);
                return;
            }
            if (value.OrderFieldDefClass != null)
            {
                serializer.Serialize(writer, value.OrderFieldDefClass);
                return;
            }
            throw new Exception("Cannot marshal type Order");
        }

        public static readonly OrderConverter Singleton = new OrderConverter();
    }

    internal class ShapeConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShapeCondition) || t == typeof(ShapeCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateMarkPropFieldDefTypeForShapeClass>(reader);
                    return new ShapeCondition { ConditionalPredicateMarkPropFieldDefTypeForShapeClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalStringValueDef>>(reader);
                    return new ShapeCondition { ConditionalStringValueDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ShapeCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ShapeCondition)untypedValue;
            if (value.ConditionalStringValueDefArray != null)
            {
                serializer.Serialize(writer, value.ConditionalStringValueDefArray);
                return;
            }
            if (value.ConditionalPredicateMarkPropFieldDefTypeForShapeClass != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateMarkPropFieldDefTypeForShapeClass);
                return;
            }
            throw new Exception("Cannot marshal type ShapeCondition");
        }

        public static readonly ShapeConditionConverter Singleton = new ShapeConditionConverter();
    }

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

    internal class TextConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextCondition) || t == typeof(TextCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefTextClass>(reader);
                    return new TextCondition { ConditionalPredicateValueDefTextClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalValueDefText>>(reader);
                    return new TextCondition { ConditionalValueDefTextArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TextCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TextCondition)untypedValue;
            if (value.ConditionalValueDefTextArray != null)
            {
                serializer.Serialize(writer, value.ConditionalValueDefTextArray);
                return;
            }
            if (value.ConditionalPredicateValueDefTextClass != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefTextClass);
                return;
            }
            throw new Exception("Cannot marshal type TextCondition");
        }

        public static readonly TextConditionConverter Singleton = new TextConditionConverter();
    }

    internal class TextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Text) || t == typeof(Text?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Text { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new Text { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Text");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Text)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type Text");
        }

        public static readonly TextConverter Singleton = new TextConverter();
    }

    internal class TooltipConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tooltip) || t == typeof(Tooltip?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Tooltip { };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FieldDefWithConditionStringFieldDefString>(reader);
                    return new Tooltip { FieldDefWithConditionStringFieldDefString = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<StringFieldDef>>(reader);
                    return new Tooltip { StringFieldDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Tooltip");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Tooltip)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.StringFieldDefArray != null)
            {
                serializer.Serialize(writer, value.StringFieldDefArray);
                return;
            }
            if (value.FieldDefWithConditionStringFieldDefString != null)
            {
                serializer.Serialize(writer, value.FieldDefWithConditionStringFieldDefString);
                return;
            }
            throw new Exception("Cannot marshal type Tooltip");
        }

        public static readonly TooltipConverter Singleton = new TooltipConverter();
    }

    internal class ColorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Color) || t == typeof(Color?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Color { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Color { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyColorNull>(reader);
                    return new Color { ConditionalAxisPropertyColorNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type Color");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Color)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ConditionalAxisPropertyColorNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyColorNull);
                return;
            }
            throw new Exception("Cannot marshal type Color");
        }

        public static readonly ColorConverter Singleton = new ColorConverter();
    }

    internal class ConditionalAxisPropertyColorNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyColorNullCondition) || t == typeof(ConditionalAxisPropertyColorNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefColorNull>(reader);
                    return new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefColorNull>>(reader);
                    return new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyColorNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyColorNullCondition)untypedValue;
            if (value.ConditionalPredicateValueDefColorNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefColorNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefColorNull != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefColorNull);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyColorNullCondition");
        }

        public static readonly ConditionalAxisPropertyColorNullConditionConverter Singleton = new ConditionalAxisPropertyColorNullConditionConverter();
    }

    internal class DashConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dash) || t == typeof(Dash?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNull>(reader);
                    return new Dash { ConditionalAxisPropertyNumberNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<double>>(reader);
                    return new Dash { DoubleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Dash");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Dash)untypedValue;
            if (value.DoubleArray != null)
            {
                serializer.Serialize(writer, value.DoubleArray);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNull);
                return;
            }
            throw new Exception("Cannot marshal type Dash");
        }

        public static readonly DashConverter Singleton = new DashConverter();
    }

    internal class ConditionalAxisPropertyNumberNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyNumberNullCondition) || t == typeof(ConditionalAxisPropertyNumberNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefNumberNull>(reader);
                    return new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefNumberNull>>(reader);
                    return new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyNumberNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyNumberNullCondition)untypedValue;
            if (value.ConditionalPredicateValueDefNumberNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefNumberNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefNumberNull != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefNumberNull);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyNumberNullCondition");
        }

        public static readonly ConditionalAxisPropertyNumberNullConditionConverter Singleton = new ConditionalAxisPropertyNumberNullConditionConverter();
    }

    internal class GridDashOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridDashOffset) || t == typeof(GridDashOffset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new GridDashOffset { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new GridDashOffset { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridDashOffset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridDashOffset)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type GridDashOffset");
        }

        public static readonly GridDashOffsetConverter Singleton = new GridDashOffsetConverter();
    }

    internal class ConditionalAxisPropertyNumberNullConditionUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyNumberNullConditionUnion) || t == typeof(ConditionalAxisPropertyNumberNullConditionUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefNumberNullElement>(reader);
                    return new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElement = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefNumberNullElement>>(reader);
                    return new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyNumberNullConditionUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyNumberNullConditionUnion)untypedValue;
            if (value.ConditionalPredicateValueDefNumberNullElementArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefNumberNullElementArray);
                return;
            }
            if (value.ConditionalPredicateValueDefNumberNullElement != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefNumberNullElement);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyNumberNullConditionUnion");
        }

        public static readonly ConditionalAxisPropertyNumberNullConditionUnionConverter Singleton = new ConditionalAxisPropertyNumberNullConditionUnionConverter();
    }

    internal class GridOpacityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridOpacity) || t == typeof(GridOpacity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new GridOpacity { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new GridOpacity { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridOpacity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridOpacity)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type GridOpacity");
        }

        public static readonly GridOpacityConverter Singleton = new GridOpacityConverter();
    }

    internal class GridWidthConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridWidth) || t == typeof(GridWidth?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new GridWidth { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new GridWidth { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridWidth");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridWidth)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type GridWidth");
        }

        public static readonly GridWidthConverter Singleton = new GridWidthConverter();
    }

    internal class LabelAlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelAlign) || t == typeof(LabelAlign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new LabelAlign { Enum = Align.Center };
                        case "left":
                            return new LabelAlign { Enum = Align.Left };
                        case "right":
                            return new LabelAlign { Enum = Align.Right };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyNumberNullClass>(reader);
                    return new LabelAlign { ConditionalAxisPropertyNumberNullClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelAlign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelAlign)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Align.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case Align.Left:
                        serializer.Serialize(writer, "left");
                        return;
                    case Align.Right:
                        serializer.Serialize(writer, "right");
                        return;
                }
            }
            if (value.ConditionalAxisPropertyNumberNullClass != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyNumberNullClass);
                return;
            }
            throw new Exception("Cannot marshal type LabelAlign");
        }

        public static readonly LabelAlignConverter Singleton = new LabelAlignConverter();
    }

    internal class TextBaselineConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextBaseline) || t == typeof(TextBaseline?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "alphabetic":
                            return new TextBaseline { Enum = Baseline.Alphabetic };
                        case "bottom":
                            return new TextBaseline { Enum = Baseline.Bottom };
                        case "middle":
                            return new TextBaseline { Enum = Baseline.Middle };
                        case "top":
                            return new TextBaseline { Enum = Baseline.Top };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyTextBaselineNull>(reader);
                    return new TextBaseline { ConditionalAxisPropertyTextBaselineNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type TextBaseline");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TextBaseline)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Baseline.Alphabetic:
                        serializer.Serialize(writer, "alphabetic");
                        return;
                    case Baseline.Bottom:
                        serializer.Serialize(writer, "bottom");
                        return;
                    case Baseline.Middle:
                        serializer.Serialize(writer, "middle");
                        return;
                    case Baseline.Top:
                        serializer.Serialize(writer, "top");
                        return;
                }
            }
            if (value.ConditionalAxisPropertyTextBaselineNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyTextBaselineNull);
                return;
            }
            throw new Exception("Cannot marshal type TextBaseline");
        }

        public static readonly TextBaselineConverter Singleton = new TextBaselineConverter();
    }

    internal class ConditionalAxisPropertyTextBaselineNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyTextBaselineNullCondition) || t == typeof(ConditionalAxisPropertyTextBaselineNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefTextBaselineNull>(reader);
                    return new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefTextBaselineNull>>(reader);
                    return new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyTextBaselineNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyTextBaselineNullCondition)untypedValue;
            if (value.ConditionalPredicateValueDefTextBaselineNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefTextBaselineNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefTextBaselineNull != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefTextBaselineNull);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyTextBaselineNullCondition");
        }

        public static readonly ConditionalAxisPropertyTextBaselineNullConditionConverter Singleton = new ConditionalAxisPropertyTextBaselineNullConditionConverter();
    }

    internal class LabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Label) || t == typeof(Label?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Label { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Label { Bool = boolValue };
            }
            throw new Exception("Cannot unmarshal type Label");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Label)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            throw new Exception("Cannot marshal type Label");
        }

        public static readonly LabelConverter Singleton = new LabelConverter();
    }

    internal class LabelFontConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFont) || t == typeof(LabelFont?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LabelFont { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyStringNull>(reader);
                    return new LabelFont { ConditionalAxisPropertyStringNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelFont");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFont)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ConditionalAxisPropertyStringNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyStringNull);
                return;
            }
            throw new Exception("Cannot marshal type LabelFont");
        }

        public static readonly LabelFontConverter Singleton = new LabelFontConverter();
    }

    internal class ConditionalAxisPropertyStringNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyStringNullCondition) || t == typeof(ConditionalAxisPropertyStringNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateStringValueDef>(reader);
                    return new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateStringValueDef>>(reader);
                    return new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDefArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyStringNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyStringNullCondition)untypedValue;
            if (value.ConditionalPredicateStringValueDefArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateStringValueDefArray);
                return;
            }
            if (value.ConditionalPredicateStringValueDef != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateStringValueDef);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyStringNullCondition");
        }

        public static readonly ConditionalAxisPropertyStringNullConditionConverter Singleton = new ConditionalAxisPropertyStringNullConditionConverter();
    }

    internal class LabelFontStyleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFontStyle) || t == typeof(LabelFontStyle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LabelFontStyle { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyFontStyleNull>(reader);
                    return new LabelFontStyle { ConditionalAxisPropertyFontStyleNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelFontStyle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFontStyle)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ConditionalAxisPropertyFontStyleNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyFontStyleNull);
                return;
            }
            throw new Exception("Cannot marshal type LabelFontStyle");
        }

        public static readonly LabelFontStyleConverter Singleton = new LabelFontStyleConverter();
    }

    internal class ConditionalAxisPropertyFontStyleNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyFontStyleNullCondition) || t == typeof(ConditionalAxisPropertyFontStyleNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefFontStyleNull>(reader);
                    return new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefFontStyleNull>>(reader);
                    return new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyFontStyleNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyFontStyleNullCondition)untypedValue;
            if (value.ConditionalPredicateValueDefFontStyleNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefFontStyleNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefFontStyleNull != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefFontStyleNull);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyFontStyleNullCondition");
        }

        public static readonly ConditionalAxisPropertyFontStyleNullConditionConverter Singleton = new ConditionalAxisPropertyFontStyleNullConditionConverter();
    }

    internal class LabelFontWeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFontWeightUnion) || t == typeof(LabelFontWeightUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LabelFontWeightUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bold":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Bold };
                        case "bolder":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Bolder };
                        case "lighter":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Lighter };
                        case "normal":
                            return new LabelFontWeightUnion { Enum = PurpleFontWeight.Normal };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalAxisPropertyFontWeightNull>(reader);
                    return new LabelFontWeightUnion { ConditionalAxisPropertyFontWeightNull = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelFontWeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFontWeightUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleFontWeight.Bold:
                        serializer.Serialize(writer, "bold");
                        return;
                    case PurpleFontWeight.Bolder:
                        serializer.Serialize(writer, "bolder");
                        return;
                    case PurpleFontWeight.Lighter:
                        serializer.Serialize(writer, "lighter");
                        return;
                    case PurpleFontWeight.Normal:
                        serializer.Serialize(writer, "normal");
                        return;
                }
            }
            if (value.ConditionalAxisPropertyFontWeightNull != null)
            {
                serializer.Serialize(writer, value.ConditionalAxisPropertyFontWeightNull);
                return;
            }
            throw new Exception("Cannot marshal type LabelFontWeightUnion");
        }

        public static readonly LabelFontWeightUnionConverter Singleton = new LabelFontWeightUnionConverter();
    }

    internal class ConditionalAxisPropertyFontWeightNullConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalAxisPropertyFontWeightNullCondition) || t == typeof(ConditionalAxisPropertyFontWeightNullCondition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ConditionalPredicateValueDefFontWeightNull>(reader);
                    return new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNull = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ConditionalPredicateValueDefFontWeightNull>>(reader);
                    return new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNullArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionalAxisPropertyFontWeightNullCondition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalAxisPropertyFontWeightNullCondition)untypedValue;
            if (value.ConditionalPredicateValueDefFontWeightNullArray != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefFontWeightNullArray);
                return;
            }
            if (value.ConditionalPredicateValueDefFontWeightNull != null)
            {
                serializer.Serialize(writer, value.ConditionalPredicateValueDefFontWeightNull);
                return;
            }
            throw new Exception("Cannot marshal type ConditionalAxisPropertyFontWeightNullCondition");
        }

        public static readonly ConditionalAxisPropertyFontWeightNullConditionConverter Singleton = new ConditionalAxisPropertyFontWeightNullConditionConverter();
    }

    internal class ConditionalPredicateValueDefFontWeightNullValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionalPredicateValueDefFontWeightNullValue) || t == typeof(ConditionalPredicateValueDefFontWeightNullValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ConditionalPredicateValueDefFontWeightNullValue { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ConditionalPredicateValueDefFontWeightNullValue { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bold":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Bold };
                        case "bolder":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Bolder };
                        case "lighter":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Lighter };
                        case "normal":
                            return new ConditionalPredicateValueDefFontWeightNullValue { Enum = PurpleFontWeight.Normal };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type ConditionalPredicateValueDefFontWeightNullValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ConditionalPredicateValueDefFontWeightNullValue)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleFontWeight.Bold:
                        serializer.Serialize(writer, "bold");
                        return;
                    case PurpleFontWeight.Bolder:
                        serializer.Serialize(writer, "bolder");
                        return;
                    case PurpleFontWeight.Lighter:
                        serializer.Serialize(writer, "lighter");
                        return;
                    case PurpleFontWeight.Normal:
                        serializer.Serialize(writer, "normal");
                        return;
                }
            }
            throw new Exception("Cannot marshal type ConditionalPredicateValueDefFontWeightNullValue");
        }

        public static readonly ConditionalPredicateValueDefFontWeightNullValueConverter Singleton = new ConditionalPredicateValueDefFontWeightNullValueConverter();
    }

    internal class TickBandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickBand) || t == typeof(TickBand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return TickBand.Center;
                case "extent":
                    return TickBand.Extent;
            }
            throw new Exception("Cannot unmarshal type TickBand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TickBand)untypedValue;
            switch (value)
            {
                case TickBand.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case TickBand.Extent:
                    serializer.Serialize(writer, "extent");
                    return;
            }
            throw new Exception("Cannot marshal type TickBand");
        }

        public static readonly TickBandConverter Singleton = new TickBandConverter();
    }

    internal class KeyvalsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Keyvals) || t == typeof(Keyvals?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ImputeSequence>(reader);
                    return new Keyvals { ImputeSequence = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new Keyvals { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Keyvals");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Keyvals)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.ImputeSequence != null)
            {
                serializer.Serialize(writer, value.ImputeSequence);
                return;
            }
            throw new Exception("Cannot marshal type Keyvals");
        }

        public static readonly KeyvalsConverter Singleton = new KeyvalsConverter();
    }

    internal class ImputeParamsMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImputeParamsMethod) || t == typeof(ImputeParamsMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "max":
                    return ImputeParamsMethod.Max;
                case "mean":
                    return ImputeParamsMethod.Mean;
                case "median":
                    return ImputeParamsMethod.Median;
                case "min":
                    return ImputeParamsMethod.Min;
                case "value":
                    return ImputeParamsMethod.Value;
            }
            throw new Exception("Cannot unmarshal type ImputeParamsMethod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImputeParamsMethod)untypedValue;
            switch (value)
            {
                case ImputeParamsMethod.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case ImputeParamsMethod.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case ImputeParamsMethod.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case ImputeParamsMethod.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case ImputeParamsMethod.Value:
                    serializer.Serialize(writer, "value");
                    return;
            }
            throw new Exception("Cannot marshal type ImputeParamsMethod");
        }

        public static readonly ImputeParamsMethodConverter Singleton = new ImputeParamsMethodConverter();
    }

    internal class StackConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Stack) || t == typeof(Stack?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Stack { };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Stack { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new Stack { Enum = StackOffset.Center };
                        case "normalize":
                            return new Stack { Enum = StackOffset.Normalize };
                        case "zero":
                            return new Stack { Enum = StackOffset.Zero };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type Stack");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Stack)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case StackOffset.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case StackOffset.Normalize:
                        serializer.Serialize(writer, "normalize");
                        return;
                    case StackOffset.Zero:
                        serializer.Serialize(writer, "zero");
                        return;
                }
            }
            throw new Exception("Cannot marshal type Stack");
        }

        public static readonly StackConverter Singleton = new StackConverter();
    }

    internal class StackOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StackOffset) || t == typeof(StackOffset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return StackOffset.Center;
                case "normalize":
                    return StackOffset.Normalize;
                case "zero":
                    return StackOffset.Zero;
            }
            throw new Exception("Cannot unmarshal type StackOffset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StackOffset)untypedValue;
            switch (value)
            {
                case StackOffset.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case StackOffset.Normalize:
                    serializer.Serialize(writer, "normalize");
                    return;
                case StackOffset.Zero:
                    serializer.Serialize(writer, "zero");
                    return;
            }
            throw new Exception("Cannot marshal type StackOffset");
        }

        public static readonly StackOffsetConverter Singleton = new StackOffsetConverter();
    }

    internal class XUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(XUnion) || t == typeof(XUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new XUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "width")
                    {
                        return new XUnion { Enum = ValueWidthEnum.Width };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type XUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (XUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == ValueWidthEnum.Width)
                {
                    serializer.Serialize(writer, "width");
                    return;
                }
            }
            throw new Exception("Cannot marshal type XUnion");
        }

        public static readonly XUnionConverter Singleton = new XUnionConverter();
    }

    internal class PurpleValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueWidthEnum) || t == typeof(ValueWidthEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "width")
            {
                return ValueWidthEnum.Width;
            }
            throw new Exception("Cannot unmarshal type ValueWidthEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ValueWidthEnum)untypedValue;
            if (value == ValueWidthEnum.Width)
            {
                serializer.Serialize(writer, "width");
                return;
            }
            throw new Exception("Cannot marshal type ValueWidthEnum");
        }

        public static readonly PurpleValueConverter Singleton = new PurpleValueConverter();
    }

    internal class YUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(YUnion) || t == typeof(YUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new YUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "height")
                    {
                        return new YUnion { Enum = ValueHeightEnum.Height };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type YUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (YUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == ValueHeightEnum.Height)
                {
                    serializer.Serialize(writer, "height");
                    return;
                }
            }
            throw new Exception("Cannot marshal type YUnion");
        }

        public static readonly YUnionConverter Singleton = new YUnionConverter();
    }

    internal class FluffyValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueHeightEnum) || t == typeof(ValueHeightEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "height")
            {
                return ValueHeightEnum.Height;
            }
            throw new Exception("Cannot unmarshal type ValueHeightEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ValueHeightEnum)untypedValue;
            if (value == ValueHeightEnum.Height)
            {
                serializer.Serialize(writer, "height");
                return;
            }
            throw new Exception("Cannot marshal type ValueHeightEnum");
        }

        public static readonly FluffyValueConverter Singleton = new FluffyValueConverter();
    }

    internal class HeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HeightUnion) || t == typeof(HeightUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new HeightUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "container")
                    {
                        return new HeightUnion { Enum = HeightEnum.Container };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Step>(reader);
                    return new HeightUnion { Step = objectValue };
            }
            throw new Exception("Cannot unmarshal type HeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HeightUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == HeightEnum.Container)
                {
                    serializer.Serialize(writer, "container");
                    return;
                }
            }
            if (value.Step != null)
            {
                serializer.Serialize(writer, value.Step);
                return;
            }
            throw new Exception("Cannot marshal type HeightUnion");
        }

        public static readonly HeightUnionConverter Singleton = new HeightUnionConverter();
    }

    internal class HeightEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HeightEnum) || t == typeof(HeightEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "container")
            {
                return HeightEnum.Container;
            }
            throw new Exception("Cannot unmarshal type HeightEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HeightEnum)untypedValue;
            if (value == HeightEnum.Container)
            {
                serializer.Serialize(writer, "container");
                return;
            }
            throw new Exception("Cannot marshal type HeightEnum");
        }

        public static readonly HeightEnumConverter Singleton = new HeightEnumConverter();
    }

    internal class AnyMarkConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AnyMark) || t == typeof(AnyMark?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "area":
                            return new AnyMark { Enum = BoxPlot.Area };
                        case "bar":
                            return new AnyMark { Enum = BoxPlot.Bar };
                        case "boxplot":
                            return new AnyMark { Enum = BoxPlot.Boxplot };
                        case "circle":
                            return new AnyMark { Enum = BoxPlot.Circle };
                        case "errorband":
                            return new AnyMark { Enum = BoxPlot.Errorband };
                        case "errorbar":
                            return new AnyMark { Enum = BoxPlot.Errorbar };
                        case "geoshape":
                            return new AnyMark { Enum = BoxPlot.Geoshape };
                        case "image":
                            return new AnyMark { Enum = BoxPlot.Image };
                        case "line":
                            return new AnyMark { Enum = BoxPlot.Line };
                        case "point":
                            return new AnyMark { Enum = BoxPlot.Point };
                        case "rect":
                            return new AnyMark { Enum = BoxPlot.Rect };
                        case "rule":
                            return new AnyMark { Enum = BoxPlot.Rule };
                        case "square":
                            return new AnyMark { Enum = BoxPlot.Square };
                        case "text":
                            return new AnyMark { Enum = BoxPlot.Text };
                        case "tick":
                            return new AnyMark { Enum = BoxPlot.Tick };
                        case "trail":
                            return new AnyMark { Enum = BoxPlot.Trail };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoxPlotDefClass>(reader);
                    return new AnyMark { BoxPlotDefClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type AnyMark");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AnyMark)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case BoxPlot.Area:
                        serializer.Serialize(writer, "area");
                        return;
                    case BoxPlot.Bar:
                        serializer.Serialize(writer, "bar");
                        return;
                    case BoxPlot.Boxplot:
                        serializer.Serialize(writer, "boxplot");
                        return;
                    case BoxPlot.Circle:
                        serializer.Serialize(writer, "circle");
                        return;
                    case BoxPlot.Errorband:
                        serializer.Serialize(writer, "errorband");
                        return;
                    case BoxPlot.Errorbar:
                        serializer.Serialize(writer, "errorbar");
                        return;
                    case BoxPlot.Geoshape:
                        serializer.Serialize(writer, "geoshape");
                        return;
                    case BoxPlot.Image:
                        serializer.Serialize(writer, "image");
                        return;
                    case BoxPlot.Line:
                        serializer.Serialize(writer, "line");
                        return;
                    case BoxPlot.Point:
                        serializer.Serialize(writer, "point");
                        return;
                    case BoxPlot.Rect:
                        serializer.Serialize(writer, "rect");
                        return;
                    case BoxPlot.Rule:
                        serializer.Serialize(writer, "rule");
                        return;
                    case BoxPlot.Square:
                        serializer.Serialize(writer, "square");
                        return;
                    case BoxPlot.Text:
                        serializer.Serialize(writer, "text");
                        return;
                    case BoxPlot.Tick:
                        serializer.Serialize(writer, "tick");
                        return;
                    case BoxPlot.Trail:
                        serializer.Serialize(writer, "trail");
                        return;
                }
            }
            if (value.BoxPlotDefClass != null)
            {
                serializer.Serialize(writer, value.BoxPlotDefClass);
                return;
            }
            throw new Exception("Cannot marshal type AnyMark");
        }

        public static readonly AnyMarkConverter Singleton = new AnyMarkConverter();
    }

    internal class BoxConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Box) || t == typeof(Box?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Box { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<MarkConfig>(reader);
                    return new Box { MarkConfig = objectValue };
            }
            throw new Exception("Cannot unmarshal type Box");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Box)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.MarkConfig != null)
            {
                serializer.Serialize(writer, value.MarkConfig);
                return;
            }
            throw new Exception("Cannot marshal type Box");
        }

        public static readonly BoxConverter Singleton = new BoxConverter();
    }

    internal class ColorUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColorUnion) || t == typeof(ColorUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ColorUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ColorLinearGradient>(reader);
                    return new ColorUnion { ColorLinearGradient = objectValue };
            }
            throw new Exception("Cannot unmarshal type ColorUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColorUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ColorLinearGradient != null)
            {
                serializer.Serialize(writer, value.ColorLinearGradient);
                return;
            }
            throw new Exception("Cannot marshal type ColorUnion");
        }

        public static readonly ColorUnionConverter Singleton = new ColorUnionConverter();
    }

    internal class CursorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Cursor) || t == typeof(Cursor?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "alias":
                    return Cursor.Alias;
                case "all-scroll":
                    return Cursor.AllScroll;
                case "auto":
                    return Cursor.Auto;
                case "cell":
                    return Cursor.Cell;
                case "col-resize":
                    return Cursor.ColResize;
                case "context-menu":
                    return Cursor.ContextMenu;
                case "copy":
                    return Cursor.Copy;
                case "crosshair":
                    return Cursor.Crosshair;
                case "default":
                    return Cursor.Default;
                case "e-resize":
                    return Cursor.EResize;
                case "ew-resize":
                    return Cursor.EwResize;
                case "grab":
                    return Cursor.Grab;
                case "grabbing":
                    return Cursor.Grabbing;
                case "help":
                    return Cursor.Help;
                case "move":
                    return Cursor.Move;
                case "n-resize":
                    return Cursor.NResize;
                case "ne-resize":
                    return Cursor.NeResize;
                case "nesw-resize":
                    return Cursor.NeswResize;
                case "no-drop":
                    return Cursor.NoDrop;
                case "none":
                    return Cursor.None;
                case "not-allowed":
                    return Cursor.NotAllowed;
                case "ns-resize":
                    return Cursor.NsResize;
                case "nw-resize":
                    return Cursor.NwResize;
                case "nwse-resize":
                    return Cursor.NwseResize;
                case "pointer":
                    return Cursor.Pointer;
                case "progress":
                    return Cursor.Progress;
                case "row-resize":
                    return Cursor.RowResize;
                case "s-resize":
                    return Cursor.SResize;
                case "se-resize":
                    return Cursor.SeResize;
                case "sw-resize":
                    return Cursor.SwResize;
                case "text":
                    return Cursor.Text;
                case "vertical-text":
                    return Cursor.VerticalText;
                case "w-resize":
                    return Cursor.WResize;
                case "wait":
                    return Cursor.Wait;
                case "zoom-in":
                    return Cursor.ZoomIn;
                case "zoom-out":
                    return Cursor.ZoomOut;
            }
            throw new Exception("Cannot unmarshal type Cursor");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Cursor)untypedValue;
            switch (value)
            {
                case Cursor.Alias:
                    serializer.Serialize(writer, "alias");
                    return;
                case Cursor.AllScroll:
                    serializer.Serialize(writer, "all-scroll");
                    return;
                case Cursor.Auto:
                    serializer.Serialize(writer, "auto");
                    return;
                case Cursor.Cell:
                    serializer.Serialize(writer, "cell");
                    return;
                case Cursor.ColResize:
                    serializer.Serialize(writer, "col-resize");
                    return;
                case Cursor.ContextMenu:
                    serializer.Serialize(writer, "context-menu");
                    return;
                case Cursor.Copy:
                    serializer.Serialize(writer, "copy");
                    return;
                case Cursor.Crosshair:
                    serializer.Serialize(writer, "crosshair");
                    return;
                case Cursor.Default:
                    serializer.Serialize(writer, "default");
                    return;
                case Cursor.EResize:
                    serializer.Serialize(writer, "e-resize");
                    return;
                case Cursor.EwResize:
                    serializer.Serialize(writer, "ew-resize");
                    return;
                case Cursor.Grab:
                    serializer.Serialize(writer, "grab");
                    return;
                case Cursor.Grabbing:
                    serializer.Serialize(writer, "grabbing");
                    return;
                case Cursor.Help:
                    serializer.Serialize(writer, "help");
                    return;
                case Cursor.Move:
                    serializer.Serialize(writer, "move");
                    return;
                case Cursor.NResize:
                    serializer.Serialize(writer, "n-resize");
                    return;
                case Cursor.NeResize:
                    serializer.Serialize(writer, "ne-resize");
                    return;
                case Cursor.NeswResize:
                    serializer.Serialize(writer, "nesw-resize");
                    return;
                case Cursor.NoDrop:
                    serializer.Serialize(writer, "no-drop");
                    return;
                case Cursor.None:
                    serializer.Serialize(writer, "none");
                    return;
                case Cursor.NotAllowed:
                    serializer.Serialize(writer, "not-allowed");
                    return;
                case Cursor.NsResize:
                    serializer.Serialize(writer, "ns-resize");
                    return;
                case Cursor.NwResize:
                    serializer.Serialize(writer, "nw-resize");
                    return;
                case Cursor.NwseResize:
                    serializer.Serialize(writer, "nwse-resize");
                    return;
                case Cursor.Pointer:
                    serializer.Serialize(writer, "pointer");
                    return;
                case Cursor.Progress:
                    serializer.Serialize(writer, "progress");
                    return;
                case Cursor.RowResize:
                    serializer.Serialize(writer, "row-resize");
                    return;
                case Cursor.SResize:
                    serializer.Serialize(writer, "s-resize");
                    return;
                case Cursor.SeResize:
                    serializer.Serialize(writer, "se-resize");
                    return;
                case Cursor.SwResize:
                    serializer.Serialize(writer, "sw-resize");
                    return;
                case Cursor.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case Cursor.VerticalText:
                    serializer.Serialize(writer, "vertical-text");
                    return;
                case Cursor.WResize:
                    serializer.Serialize(writer, "w-resize");
                    return;
                case Cursor.Wait:
                    serializer.Serialize(writer, "wait");
                    return;
                case Cursor.ZoomIn:
                    serializer.Serialize(writer, "zoom-in");
                    return;
                case Cursor.ZoomOut:
                    serializer.Serialize(writer, "zoom-out");
                    return;
            }
            throw new Exception("Cannot marshal type Cursor");
        }

        public static readonly CursorConverter Singleton = new CursorConverter();
    }

    internal class DirConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dir) || t == typeof(Dir?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ltr":
                    return Dir.Ltr;
                case "rtl":
                    return Dir.Rtl;
            }
            throw new Exception("Cannot unmarshal type Dir");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Dir)untypedValue;
            switch (value)
            {
                case Dir.Ltr:
                    serializer.Serialize(writer, "ltr");
                    return;
                case Dir.Rtl:
                    serializer.Serialize(writer, "rtl");
                    return;
            }
            throw new Exception("Cannot marshal type Dir");
        }

        public static readonly DirConverter Singleton = new DirConverter();
    }

    internal class FillUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FillUnion) || t == typeof(FillUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FillUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new FillUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FillLinearGradient>(reader);
                    return new FillUnion { FillLinearGradient = objectValue };
            }
            throw new Exception("Cannot unmarshal type FillUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FillUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.FillLinearGradient != null)
            {
                serializer.Serialize(writer, value.FillLinearGradient);
                return;
            }
            throw new Exception("Cannot marshal type FillUnion");
        }

        public static readonly FillUnionConverter Singleton = new FillUnionConverter();
    }

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

    internal class InvalidConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Invalid) || t == typeof(Invalid?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "filter")
            {
                return Invalid.Filter;
            }
            throw new Exception("Cannot unmarshal type Invalid");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Invalid)untypedValue;
            if (value == Invalid.Filter)
            {
                serializer.Serialize(writer, "filter");
                return;
            }
            throw new Exception("Cannot marshal type Invalid");
        }

        public static readonly InvalidConverter Singleton = new InvalidConverter();
    }

    internal class StrokeCapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeCap) || t == typeof(StrokeCap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "butt":
                    return StrokeCap.Butt;
                case "round":
                    return StrokeCap.Round;
                case "square":
                    return StrokeCap.Square;
            }
            throw new Exception("Cannot unmarshal type StrokeCap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StrokeCap)untypedValue;
            switch (value)
            {
                case StrokeCap.Butt:
                    serializer.Serialize(writer, "butt");
                    return;
                case StrokeCap.Round:
                    serializer.Serialize(writer, "round");
                    return;
                case StrokeCap.Square:
                    serializer.Serialize(writer, "square");
                    return;
            }
            throw new Exception("Cannot marshal type StrokeCap");
        }

        public static readonly StrokeCapConverter Singleton = new StrokeCapConverter();
    }

    internal class StrokeJoinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeJoin) || t == typeof(StrokeJoin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bevel":
                    return StrokeJoin.Bevel;
                case "miter":
                    return StrokeJoin.Miter;
                case "round":
                    return StrokeJoin.Round;
            }
            throw new Exception("Cannot unmarshal type StrokeJoin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StrokeJoin)untypedValue;
            switch (value)
            {
                case StrokeJoin.Bevel:
                    serializer.Serialize(writer, "bevel");
                    return;
                case StrokeJoin.Miter:
                    serializer.Serialize(writer, "miter");
                    return;
                case StrokeJoin.Round:
                    serializer.Serialize(writer, "round");
                    return;
            }
            throw new Exception("Cannot marshal type StrokeJoin");
        }

        public static readonly StrokeJoinConverter Singleton = new StrokeJoinConverter();
    }

    internal class ValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Value) || t == typeof(Value?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Value { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Value { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Value { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Value { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TooltipContent>(reader);
                    return new Value { TooltipContent = objectValue };
            }
            throw new Exception("Cannot unmarshal type Value");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Value)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.TooltipContent != null)
            {
                serializer.Serialize(writer, value.TooltipContent);
                return;
            }
            throw new Exception("Cannot marshal type Value");
        }

        public static readonly ValueConverter Singleton = new ValueConverter();
    }

    internal class ContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Content) || t == typeof(Content?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "data":
                    return Content.Data;
                case "encoding":
                    return Content.Encoding;
            }
            throw new Exception("Cannot unmarshal type Content");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Content)untypedValue;
            switch (value)
            {
                case Content.Data:
                    serializer.Serialize(writer, "data");
                    return;
                case Content.Encoding:
                    serializer.Serialize(writer, "encoding");
                    return;
            }
            throw new Exception("Cannot marshal type Content");
        }

        public static readonly ContentConverter Singleton = new ContentConverter();
    }

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

    internal class ExtentExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExtentExtent) || t == typeof(ExtentExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ci":
                    return ExtentExtent.Ci;
                case "iqr":
                    return ExtentExtent.Iqr;
                case "min-max":
                    return ExtentExtent.MinMax;
                case "stderr":
                    return ExtentExtent.Stderr;
                case "stdev":
                    return ExtentExtent.Stdev;
            }
            throw new Exception("Cannot unmarshal type ExtentExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExtentExtent)untypedValue;
            switch (value)
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
            throw new Exception("Cannot marshal type ExtentExtent");
        }

        public static readonly ExtentExtentConverter Singleton = new ExtentExtentConverter();
    }

    internal class LineConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Line) || t == typeof(Line?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Line { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OverlayMarkDef>(reader);
                    return new Line { OverlayMarkDef = objectValue };
            }
            throw new Exception("Cannot unmarshal type Line");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Line)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.OverlayMarkDef != null)
            {
                serializer.Serialize(writer, value.OverlayMarkDef);
                return;
            }
            throw new Exception("Cannot marshal type Line");
        }

        public static readonly LineConverter Singleton = new LineConverter();
    }

    internal class PointUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PointUnion) || t == typeof(PointUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new PointUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "transparent")
                    {
                        return new PointUnion { Enum = PointEnum.Transparent };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OverlayMarkDef>(reader);
                    return new PointUnion { OverlayMarkDef = objectValue };
            }
            throw new Exception("Cannot unmarshal type PointUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PointUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == PointEnum.Transparent)
                {
                    serializer.Serialize(writer, "transparent");
                    return;
                }
            }
            if (value.OverlayMarkDef != null)
            {
                serializer.Serialize(writer, value.OverlayMarkDef);
                return;
            }
            throw new Exception("Cannot marshal type PointUnion");
        }

        public static readonly PointUnionConverter Singleton = new PointUnionConverter();
    }

    internal class PointEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PointEnum) || t == typeof(PointEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "transparent")
            {
                return PointEnum.Transparent;
            }
            throw new Exception("Cannot unmarshal type PointEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PointEnum)untypedValue;
            if (value == PointEnum.Transparent)
            {
                serializer.Serialize(writer, "transparent");
                return;
            }
            throw new Exception("Cannot marshal type PointEnum");
        }

        public static readonly PointEnumConverter Singleton = new PointEnumConverter();
    }

    internal class BoxPlotConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoxPlot) || t == typeof(BoxPlot?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "area":
                    return BoxPlot.Area;
                case "bar":
                    return BoxPlot.Bar;
                case "boxplot":
                    return BoxPlot.Boxplot;
                case "circle":
                    return BoxPlot.Circle;
                case "errorband":
                    return BoxPlot.Errorband;
                case "errorbar":
                    return BoxPlot.Errorbar;
                case "geoshape":
                    return BoxPlot.Geoshape;
                case "image":
                    return BoxPlot.Image;
                case "line":
                    return BoxPlot.Line;
                case "point":
                    return BoxPlot.Point;
                case "rect":
                    return BoxPlot.Rect;
                case "rule":
                    return BoxPlot.Rule;
                case "square":
                    return BoxPlot.Square;
                case "text":
                    return BoxPlot.Text;
                case "tick":
                    return BoxPlot.Tick;
                case "trail":
                    return BoxPlot.Trail;
            }
            throw new Exception("Cannot unmarshal type BoxPlot");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BoxPlot)untypedValue;
            switch (value)
            {
                case BoxPlot.Area:
                    serializer.Serialize(writer, "area");
                    return;
                case BoxPlot.Bar:
                    serializer.Serialize(writer, "bar");
                    return;
                case BoxPlot.Boxplot:
                    serializer.Serialize(writer, "boxplot");
                    return;
                case BoxPlot.Circle:
                    serializer.Serialize(writer, "circle");
                    return;
                case BoxPlot.Errorband:
                    serializer.Serialize(writer, "errorband");
                    return;
                case BoxPlot.Errorbar:
                    serializer.Serialize(writer, "errorbar");
                    return;
                case BoxPlot.Geoshape:
                    serializer.Serialize(writer, "geoshape");
                    return;
                case BoxPlot.Image:
                    serializer.Serialize(writer, "image");
                    return;
                case BoxPlot.Line:
                    serializer.Serialize(writer, "line");
                    return;
                case BoxPlot.Point:
                    serializer.Serialize(writer, "point");
                    return;
                case BoxPlot.Rect:
                    serializer.Serialize(writer, "rect");
                    return;
                case BoxPlot.Rule:
                    serializer.Serialize(writer, "rule");
                    return;
                case BoxPlot.Square:
                    serializer.Serialize(writer, "square");
                    return;
                case BoxPlot.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case BoxPlot.Tick:
                    serializer.Serialize(writer, "tick");
                    return;
                case BoxPlot.Trail:
                    serializer.Serialize(writer, "trail");
                    return;
            }
            throw new Exception("Cannot marshal type BoxPlot");
        }

        public static readonly BoxPlotConverter Singleton = new BoxPlotConverter();
    }

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

    internal class ResolveModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ResolveMode) || t == typeof(ResolveMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "independent":
                    return ResolveMode.Independent;
                case "shared":
                    return ResolveMode.Shared;
            }
            throw new Exception("Cannot unmarshal type ResolveMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ResolveMode)untypedValue;
            switch (value)
            {
                case ResolveMode.Independent:
                    serializer.Serialize(writer, "independent");
                    return;
                case ResolveMode.Shared:
                    serializer.Serialize(writer, "shared");
                    return;
            }
            throw new Exception("Cannot marshal type ResolveMode");
        }

        public static readonly ResolveModeConverter Singleton = new ResolveModeConverter();
    }

    internal class BindUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BindUnion) || t == typeof(BindUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "legend":
                            return new BindUnion { Enum = PurpleLegendBinding.Legend };
                        case "scales":
                            return new BindUnion { Enum = PurpleLegendBinding.Scales };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, PurpleStream>>(reader);
                    return new BindUnion { AnythingMap = objectValue };
            }
            throw new Exception("Cannot unmarshal type BindUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BindUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case PurpleLegendBinding.Legend:
                        serializer.Serialize(writer, "legend");
                        return;
                    case PurpleLegendBinding.Scales:
                        serializer.Serialize(writer, "scales");
                        return;
                }
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type BindUnion");
        }

        public static readonly BindUnionConverter Singleton = new BindUnionConverter();
    }

    internal class PurpleStreamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleStream) || t == typeof(PurpleStream?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new PurpleStream { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new PurpleStream { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleBinding>(reader);
                    return new PurpleStream { PurpleBinding = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new PurpleStream { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleStream");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleStream)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleBinding != null)
            {
                serializer.Serialize(writer, value.PurpleBinding);
                return;
            }
            throw new Exception("Cannot marshal type PurpleStream");
        }

        public static readonly PurpleStreamConverter Singleton = new PurpleStreamConverter();
    }

    internal class MarkTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarkType) || t == typeof(MarkType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "arc":
                    return MarkType.Arc;
                case "area":
                    return MarkType.Area;
                case "group":
                    return MarkType.Group;
                case "image":
                    return MarkType.Image;
                case "line":
                    return MarkType.Line;
                case "path":
                    return MarkType.Path;
                case "rect":
                    return MarkType.Rect;
                case "rule":
                    return MarkType.Rule;
                case "shape":
                    return MarkType.Shape;
                case "symbol":
                    return MarkType.Symbol;
                case "text":
                    return MarkType.Text;
                case "trail":
                    return MarkType.Trail;
            }
            throw new Exception("Cannot unmarshal type MarkType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MarkType)untypedValue;
            switch (value)
            {
                case MarkType.Arc:
                    serializer.Serialize(writer, "arc");
                    return;
                case MarkType.Area:
                    serializer.Serialize(writer, "area");
                    return;
                case MarkType.Group:
                    serializer.Serialize(writer, "group");
                    return;
                case MarkType.Image:
                    serializer.Serialize(writer, "image");
                    return;
                case MarkType.Line:
                    serializer.Serialize(writer, "line");
                    return;
                case MarkType.Path:
                    serializer.Serialize(writer, "path");
                    return;
                case MarkType.Rect:
                    serializer.Serialize(writer, "rect");
                    return;
                case MarkType.Rule:
                    serializer.Serialize(writer, "rule");
                    return;
                case MarkType.Shape:
                    serializer.Serialize(writer, "shape");
                    return;
                case MarkType.Symbol:
                    serializer.Serialize(writer, "symbol");
                    return;
                case MarkType.Text:
                    serializer.Serialize(writer, "text");
                    return;
                case MarkType.Trail:
                    serializer.Serialize(writer, "trail");
                    return;
            }
            throw new Exception("Cannot marshal type MarkType");
        }

        public static readonly MarkTypeConverter Singleton = new MarkTypeConverter();
    }

    internal class SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Source) || t == typeof(Source?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "scope":
                    return Source.Scope;
                case "view":
                    return Source.View;
                case "window":
                    return Source.Window;
            }
            throw new Exception("Cannot unmarshal type Source");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Source)untypedValue;
            switch (value)
            {
                case Source.Scope:
                    serializer.Serialize(writer, "scope");
                    return;
                case Source.View:
                    serializer.Serialize(writer, "view");
                    return;
                case Source.Window:
                    serializer.Serialize(writer, "window");
                    return;
            }
            throw new Exception("Cannot marshal type Source");
        }

        public static readonly SourceConverter Singleton = new SourceConverter();
    }

    internal class PurpleLegendBindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleLegendBinding) || t == typeof(PurpleLegendBinding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "legend":
                    return PurpleLegendBinding.Legend;
                case "scales":
                    return PurpleLegendBinding.Scales;
            }
            throw new Exception("Cannot unmarshal type PurpleLegendBinding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleLegendBinding)untypedValue;
            switch (value)
            {
                case PurpleLegendBinding.Legend:
                    serializer.Serialize(writer, "legend");
                    return;
                case PurpleLegendBinding.Scales:
                    serializer.Serialize(writer, "scales");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleLegendBinding");
        }

        public static readonly PurpleLegendBindingConverter Singleton = new PurpleLegendBindingConverter();
    }

    internal class ClearUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClearUnion) || t == typeof(ClearUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ClearUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ClearUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ClearDerivedStream>(reader);
                    return new ClearUnion { ClearDerivedStream = objectValue };
            }
            throw new Exception("Cannot unmarshal type ClearUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ClearUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ClearDerivedStream != null)
            {
                serializer.Serialize(writer, value.ClearDerivedStream);
                return;
            }
            throw new Exception("Cannot marshal type ClearUnion");
        }

        public static readonly ClearUnionConverter Singleton = new ClearUnionConverter();
    }

    internal class EmptyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Empty) || t == typeof(Empty?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return Empty.All;
                case "none":
                    return Empty.None;
            }
            throw new Exception("Cannot unmarshal type Empty");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Empty)untypedValue;
            switch (value)
            {
                case Empty.All:
                    serializer.Serialize(writer, "all");
                    return;
                case Empty.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type Empty");
        }

        public static readonly EmptyConverter Singleton = new EmptyConverter();
    }

    internal class InitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Init) || t == typeof(Init?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, InitValue>>(reader);
                    return new Init { AnythingMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Dictionary<string, SelectionInit>>>(reader);
                    return new Init { AnythingMapArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Init");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Init)untypedValue;
            if (value.AnythingMapArray != null)
            {
                serializer.Serialize(writer, value.AnythingMapArray);
                return;
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type Init");
        }

        public static readonly InitConverter Singleton = new InitConverter();
    }

    internal class SelectionInitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionInit) || t == typeof(SelectionInit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new SelectionInit { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new SelectionInit { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new SelectionInit { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new SelectionInit { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new SelectionInit { DateTime = objectValue };
            }
            throw new Exception("Cannot unmarshal type SelectionInit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SelectionInit)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type SelectionInit");
        }

        public static readonly SelectionInitConverter Singleton = new SelectionInitConverter();
    }

    internal class InitValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InitValue) || t == typeof(InitValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new InitValue { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new InitValue { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new InitValue { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new InitValue { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DateTime>(reader);
                    return new InitValue { DateTime = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Equal>>(reader);
                    return new InitValue { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type InitValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InitValue)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime);
                return;
            }
            throw new Exception("Cannot marshal type InitValue");
        }

        public static readonly InitValueConverter Singleton = new InitValueConverter();
    }

    internal class OnUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OnUnion) || t == typeof(OnUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new OnUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OnDerivedStream>(reader);
                    return new OnUnion { OnDerivedStream = objectValue };
            }
            throw new Exception("Cannot unmarshal type OnUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (OnUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.OnDerivedStream != null)
            {
                serializer.Serialize(writer, value.OnDerivedStream);
                return;
            }
            throw new Exception("Cannot marshal type OnUnion");
        }

        public static readonly OnUnionConverter Singleton = new OnUnionConverter();
    }

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

    internal class TranslateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Translate) || t == typeof(Translate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Translate { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Translate { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Translate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Translate)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Translate");
        }

        public static readonly TranslateConverter Singleton = new TranslateConverter();
    }

    internal class SelectionDefTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SelectionDefType) || t == typeof(SelectionDefType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "interval":
                    return SelectionDefType.Interval;
                case "multi":
                    return SelectionDefType.Multi;
                case "single":
                    return SelectionDefType.Single;
            }
            throw new Exception("Cannot unmarshal type SelectionDefType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SelectionDefType)untypedValue;
            switch (value)
            {
                case SelectionDefType.Interval:
                    serializer.Serialize(writer, "interval");
                    return;
                case SelectionDefType.Multi:
                    serializer.Serialize(writer, "multi");
                    return;
                case SelectionDefType.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type SelectionDefType");
        }

        public static readonly SelectionDefTypeConverter Singleton = new SelectionDefTypeConverter();
    }

    internal class LayerTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayerTitle) || t == typeof(LayerTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LayerTitle { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TitleParams>(reader);
                    return new LayerTitle { TitleParams = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new LayerTitle { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LayerTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayerTitle)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.TitleParams != null)
            {
                serializer.Serialize(writer, value.TitleParams);
                return;
            }
            throw new Exception("Cannot marshal type LayerTitle");
        }

        public static readonly LayerTitleConverter Singleton = new LayerTitleConverter();
    }

    internal class TitleOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleOrient) || t == typeof(TitleOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return TitleOrient.Bottom;
                case "left":
                    return TitleOrient.Left;
                case "none":
                    return TitleOrient.None;
                case "right":
                    return TitleOrient.Right;
                case "top":
                    return TitleOrient.Top;
            }
            throw new Exception("Cannot unmarshal type TitleOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TitleOrient)untypedValue;
            switch (value)
            {
                case TitleOrient.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case TitleOrient.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case TitleOrient.None:
                    serializer.Serialize(writer, "none");
                    return;
                case TitleOrient.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case TitleOrient.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type TitleOrient");
        }

        public static readonly TitleOrientConverter Singleton = new TitleOrientConverter();
    }

    internal class AggregateOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AggregateOp) || t == typeof(AggregateOp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "argmax":
                    return AggregateOp.Argmax;
                case "argmin":
                    return AggregateOp.Argmin;
                case "average":
                    return AggregateOp.Average;
                case "ci0":
                    return AggregateOp.Ci0;
                case "ci1":
                    return AggregateOp.Ci1;
                case "count":
                    return AggregateOp.Count;
                case "distinct":
                    return AggregateOp.Distinct;
                case "max":
                    return AggregateOp.Max;
                case "mean":
                    return AggregateOp.Mean;
                case "median":
                    return AggregateOp.Median;
                case "min":
                    return AggregateOp.Min;
                case "missing":
                    return AggregateOp.Missing;
                case "q1":
                    return AggregateOp.Q1;
                case "q3":
                    return AggregateOp.Q3;
                case "stderr":
                    return AggregateOp.Stderr;
                case "stdev":
                    return AggregateOp.Stdev;
                case "stdevp":
                    return AggregateOp.Stdevp;
                case "sum":
                    return AggregateOp.Sum;
                case "valid":
                    return AggregateOp.Valid;
                case "values":
                    return AggregateOp.Values;
                case "variance":
                    return AggregateOp.Variance;
                case "variancep":
                    return AggregateOp.Variancep;
            }
            throw new Exception("Cannot unmarshal type AggregateOp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AggregateOp)untypedValue;
            switch (value)
            {
                case AggregateOp.Argmax:
                    serializer.Serialize(writer, "argmax");
                    return;
                case AggregateOp.Argmin:
                    serializer.Serialize(writer, "argmin");
                    return;
                case AggregateOp.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case AggregateOp.Ci0:
                    serializer.Serialize(writer, "ci0");
                    return;
                case AggregateOp.Ci1:
                    serializer.Serialize(writer, "ci1");
                    return;
                case AggregateOp.Count:
                    serializer.Serialize(writer, "count");
                    return;
                case AggregateOp.Distinct:
                    serializer.Serialize(writer, "distinct");
                    return;
                case AggregateOp.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case AggregateOp.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case AggregateOp.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case AggregateOp.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case AggregateOp.Missing:
                    serializer.Serialize(writer, "missing");
                    return;
                case AggregateOp.Q1:
                    serializer.Serialize(writer, "q1");
                    return;
                case AggregateOp.Q3:
                    serializer.Serialize(writer, "q3");
                    return;
                case AggregateOp.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case AggregateOp.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
                case AggregateOp.Stdevp:
                    serializer.Serialize(writer, "stdevp");
                    return;
                case AggregateOp.Sum:
                    serializer.Serialize(writer, "sum");
                    return;
                case AggregateOp.Valid:
                    serializer.Serialize(writer, "valid");
                    return;
                case AggregateOp.Values:
                    serializer.Serialize(writer, "values");
                    return;
                case AggregateOp.Variance:
                    serializer.Serialize(writer, "variance");
                    return;
                case AggregateOp.Variancep:
                    serializer.Serialize(writer, "variancep");
                    return;
            }
            throw new Exception("Cannot marshal type AggregateOp");
        }

        public static readonly AggregateOpConverter Singleton = new AggregateOpConverter();
    }

    internal class TransformBinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformBin) || t == typeof(TransformBin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TransformBin { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinParams>(reader);
                    return new TransformBin { BinParams = objectValue };
            }
            throw new Exception("Cannot unmarshal type TransformBin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransformBin)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.BinParams != null)
            {
                serializer.Serialize(writer, value.BinParams);
                return;
            }
            throw new Exception("Cannot marshal type TransformBin");
        }

        public static readonly TransformBinConverter Singleton = new TransformBinConverter();
    }

    internal class TransformMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformMethod) || t == typeof(TransformMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "exp":
                    return TransformMethod.Exp;
                case "linear":
                    return TransformMethod.Linear;
                case "log":
                    return TransformMethod.Log;
                case "max":
                    return TransformMethod.Max;
                case "mean":
                    return TransformMethod.Mean;
                case "median":
                    return TransformMethod.Median;
                case "min":
                    return TransformMethod.Min;
                case "poly":
                    return TransformMethod.Poly;
                case "pow":
                    return TransformMethod.Pow;
                case "quad":
                    return TransformMethod.Quad;
                case "value":
                    return TransformMethod.Value;
            }
            throw new Exception("Cannot unmarshal type TransformMethod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransformMethod)untypedValue;
            switch (value)
            {
                case TransformMethod.Exp:
                    serializer.Serialize(writer, "exp");
                    return;
                case TransformMethod.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case TransformMethod.Log:
                    serializer.Serialize(writer, "log");
                    return;
                case TransformMethod.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case TransformMethod.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case TransformMethod.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case TransformMethod.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case TransformMethod.Poly:
                    serializer.Serialize(writer, "poly");
                    return;
                case TransformMethod.Pow:
                    serializer.Serialize(writer, "pow");
                    return;
                case TransformMethod.Quad:
                    serializer.Serialize(writer, "quad");
                    return;
                case TransformMethod.Value:
                    serializer.Serialize(writer, "value");
                    return;
            }
            throw new Exception("Cannot marshal type TransformMethod");
        }

        public static readonly TransformMethodConverter Singleton = new TransformMethodConverter();
    }

    internal class OpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Op) || t == typeof(Op?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "argmax":
                    return Op.Argmax;
                case "argmin":
                    return Op.Argmin;
                case "average":
                    return Op.Average;
                case "ci0":
                    return Op.Ci0;
                case "ci1":
                    return Op.Ci1;
                case "count":
                    return Op.Count;
                case "cume_dist":
                    return Op.CumeDist;
                case "dense_rank":
                    return Op.DenseRank;
                case "distinct":
                    return Op.Distinct;
                case "first_value":
                    return Op.FirstValue;
                case "lag":
                    return Op.Lag;
                case "last_value":
                    return Op.LastValue;
                case "lead":
                    return Op.Lead;
                case "max":
                    return Op.Max;
                case "mean":
                    return Op.Mean;
                case "median":
                    return Op.Median;
                case "min":
                    return Op.Min;
                case "missing":
                    return Op.Missing;
                case "nth_value":
                    return Op.NthValue;
                case "ntile":
                    return Op.Ntile;
                case "percent_rank":
                    return Op.PercentRank;
                case "q1":
                    return Op.Q1;
                case "q3":
                    return Op.Q3;
                case "rank":
                    return Op.Rank;
                case "row_number":
                    return Op.RowNumber;
                case "stderr":
                    return Op.Stderr;
                case "stdev":
                    return Op.Stdev;
                case "stdevp":
                    return Op.Stdevp;
                case "sum":
                    return Op.Sum;
                case "valid":
                    return Op.Valid;
                case "values":
                    return Op.Values;
                case "variance":
                    return Op.Variance;
                case "variancep":
                    return Op.Variancep;
            }
            throw new Exception("Cannot unmarshal type Op");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Op)untypedValue;
            switch (value)
            {
                case Op.Argmax:
                    serializer.Serialize(writer, "argmax");
                    return;
                case Op.Argmin:
                    serializer.Serialize(writer, "argmin");
                    return;
                case Op.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case Op.Ci0:
                    serializer.Serialize(writer, "ci0");
                    return;
                case Op.Ci1:
                    serializer.Serialize(writer, "ci1");
                    return;
                case Op.Count:
                    serializer.Serialize(writer, "count");
                    return;
                case Op.CumeDist:
                    serializer.Serialize(writer, "cume_dist");
                    return;
                case Op.DenseRank:
                    serializer.Serialize(writer, "dense_rank");
                    return;
                case Op.Distinct:
                    serializer.Serialize(writer, "distinct");
                    return;
                case Op.FirstValue:
                    serializer.Serialize(writer, "first_value");
                    return;
                case Op.Lag:
                    serializer.Serialize(writer, "lag");
                    return;
                case Op.LastValue:
                    serializer.Serialize(writer, "last_value");
                    return;
                case Op.Lead:
                    serializer.Serialize(writer, "lead");
                    return;
                case Op.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case Op.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case Op.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case Op.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case Op.Missing:
                    serializer.Serialize(writer, "missing");
                    return;
                case Op.NthValue:
                    serializer.Serialize(writer, "nth_value");
                    return;
                case Op.Ntile:
                    serializer.Serialize(writer, "ntile");
                    return;
                case Op.PercentRank:
                    serializer.Serialize(writer, "percent_rank");
                    return;
                case Op.Q1:
                    serializer.Serialize(writer, "q1");
                    return;
                case Op.Q3:
                    serializer.Serialize(writer, "q3");
                    return;
                case Op.Rank:
                    serializer.Serialize(writer, "rank");
                    return;
                case Op.RowNumber:
                    serializer.Serialize(writer, "row_number");
                    return;
                case Op.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case Op.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
                case Op.Stdevp:
                    serializer.Serialize(writer, "stdevp");
                    return;
                case Op.Sum:
                    serializer.Serialize(writer, "sum");
                    return;
                case Op.Valid:
                    serializer.Serialize(writer, "valid");
                    return;
                case Op.Values:
                    serializer.Serialize(writer, "values");
                    return;
                case Op.Variance:
                    serializer.Serialize(writer, "variance");
                    return;
                case Op.Variancep:
                    serializer.Serialize(writer, "variancep");
                    return;
            }
            throw new Exception("Cannot marshal type Op");
        }

        public static readonly OpConverter Singleton = new OpConverter();
    }

    internal class RepeatUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RepeatUnion) || t == typeof(RepeatUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RepeatMapping>(reader);
                    return new RepeatUnion { RepeatMapping = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new RepeatUnion { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type RepeatUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RepeatUnion)untypedValue;
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.RepeatMapping != null)
            {
                serializer.Serialize(writer, value.RepeatMapping);
                return;
            }
            throw new Exception("Cannot marshal type RepeatUnion");
        }

        public static readonly RepeatUnionConverter Singleton = new RepeatUnionConverter();
    }

    internal class BoxplotExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoxplotExtent) || t == typeof(BoxplotExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new BoxplotExtent { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "min-max")
                    {
                        return new BoxplotExtent { Enum = ExtentEnum.MinMax };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type BoxplotExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BoxplotExtent)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == ExtentEnum.MinMax)
                {
                    serializer.Serialize(writer, "min-max");
                    return;
                }
            }
            throw new Exception("Cannot marshal type BoxplotExtent");
        }

        public static readonly BoxplotExtentConverter Singleton = new BoxplotExtentConverter();
    }

    internal class ExtentEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExtentEnum) || t == typeof(ExtentEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "min-max")
            {
                return ExtentEnum.MinMax;
            }
            throw new Exception("Cannot unmarshal type ExtentEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExtentEnum)untypedValue;
            if (value == ExtentEnum.MinMax)
            {
                serializer.Serialize(writer, "min-max");
                return;
            }
            throw new Exception("Cannot marshal type ExtentEnum");
        }

        public static readonly ExtentEnumConverter Singleton = new ExtentEnumConverter();
    }

    internal class ErrorbandExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ErrorbandExtent) || t == typeof(ErrorbandExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ci":
                    return ErrorbandExtent.Ci;
                case "iqr":
                    return ErrorbandExtent.Iqr;
                case "stderr":
                    return ErrorbandExtent.Stderr;
                case "stdev":
                    return ErrorbandExtent.Stdev;
            }
            throw new Exception("Cannot unmarshal type ErrorbandExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ErrorbandExtent)untypedValue;
            switch (value)
            {
                case ErrorbandExtent.Ci:
                    serializer.Serialize(writer, "ci");
                    return;
                case ErrorbandExtent.Iqr:
                    serializer.Serialize(writer, "iqr");
                    return;
                case ErrorbandExtent.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case ErrorbandExtent.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
            }
            throw new Exception("Cannot marshal type ErrorbandExtent");
        }

        public static readonly ErrorbandExtentConverter Singleton = new ErrorbandExtentConverter();
    }

    internal class FieldTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FieldTitle) || t == typeof(FieldTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "functional":
                    return FieldTitle.Functional;
                case "plain":
                    return FieldTitle.Plain;
                case "verbal":
                    return FieldTitle.Verbal;
            }
            throw new Exception("Cannot unmarshal type FieldTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FieldTitle)untypedValue;
            switch (value)
            {
                case FieldTitle.Functional:
                    serializer.Serialize(writer, "functional");
                    return;
                case FieldTitle.Plain:
                    serializer.Serialize(writer, "plain");
                    return;
                case FieldTitle.Verbal:
                    serializer.Serialize(writer, "verbal");
                    return;
            }
            throw new Exception("Cannot marshal type FieldTitle");
        }

        public static readonly FieldTitleConverter Singleton = new FieldTitleConverter();
    }

    internal class AnchorUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AnchorUnion) || t == typeof(AnchorUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new AnchorUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "end":
                            return new AnchorUnion { Enum = TitleAnchorEnum.End };
                        case "middle":
                            return new AnchorUnion { Enum = TitleAnchorEnum.Middle };
                        case "start":
                            return new AnchorUnion { Enum = TitleAnchorEnum.Start };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new AnchorUnion { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type AnchorUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AnchorUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TitleAnchorEnum.End:
                        serializer.Serialize(writer, "end");
                        return;
                    case TitleAnchorEnum.Middle:
                        serializer.Serialize(writer, "middle");
                        return;
                    case TitleAnchorEnum.Start:
                        serializer.Serialize(writer, "start");
                        return;
                }
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type AnchorUnion");
        }

        public static readonly AnchorUnionConverter Singleton = new AnchorUnionConverter();
    }

    internal class LayoutBoundsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutBounds) || t == typeof(LayoutBounds?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "flush":
                            return new LayoutBounds { Enum = BoundsEnum.Flush };
                        case "full":
                            return new LayoutBounds { Enum = BoundsEnum.Full };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new LayoutBounds { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type LayoutBounds");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayoutBounds)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case BoundsEnum.Flush:
                        serializer.Serialize(writer, "flush");
                        return;
                    case BoundsEnum.Full:
                        serializer.Serialize(writer, "full");
                        return;
                }
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type LayoutBounds");
        }

        public static readonly LayoutBoundsConverter Singleton = new LayoutBoundsConverter();
    }

    internal class BottomCenterConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BottomCenter) || t == typeof(BottomCenter?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new BottomCenter { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new BottomCenter { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type BottomCenter");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BottomCenter)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type BottomCenter");
        }

        public static readonly BottomCenterConverter Singleton = new BottomCenterConverter();
    }

    internal class DirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Direction) || t == typeof(Direction?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "horizontal":
                            return new Direction { Enum = Orientation.Horizontal };
                        case "vertical":
                            return new Direction { Enum = Orientation.Vertical };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new Direction { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type Direction");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Direction)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case Orientation.Horizontal:
                        serializer.Serialize(writer, "horizontal");
                        return;
                    case Orientation.Vertical:
                        serializer.Serialize(writer, "vertical");
                        return;
                }
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type Direction");
        }

        public static readonly DirectionConverter Singleton = new DirectionConverter();
    }

    internal class RangeRawArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeRawArray) || t == typeof(RangeRawArray?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new RangeRawArray { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new RangeRawArray { PurpleSignalRef = objectValue };
            }
            throw new Exception("Cannot unmarshal type RangeRawArray");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeRawArray)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type RangeRawArray");
        }

        public static readonly RangeRawArrayConverter Singleton = new RangeRawArrayConverter();
    }

    internal class PaddingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Padding) || t == typeof(Padding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Padding { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PaddingClass>(reader);
                    return new Padding { PaddingClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type Padding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Padding)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.PaddingClass != null)
            {
                serializer.Serialize(writer, value.PaddingClass);
                return;
            }
            throw new Exception("Cannot marshal type Padding");
        }

        public static readonly PaddingConverter Singleton = new PaddingConverter();
    }

    internal class CategoryUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CategoryUnion) || t == typeof(CategoryUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new CategoryUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new CategoryUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new CategoryUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new CategoryUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new CategoryUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new CategoryUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new CategoryUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new CategoryUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<CategorySignalRef>(reader);
                    return new CategoryUnion { CategorySignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);
                    return new CategoryUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CategoryUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CategoryUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.CategorySignalRef != null)
            {
                serializer.Serialize(writer, value.CategorySignalRef);
                return;
            }
            throw new Exception("Cannot marshal type CategoryUnion");
        }

        public static readonly CategoryUnionConverter Singleton = new CategoryUnionConverter();
    }

    internal class RangeRawConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeRaw) || t == typeof(RangeRaw?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new RangeRaw { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new RangeRaw { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new RangeRaw { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new RangeRaw { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new RangeRaw { PurpleSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRawArray>>(reader);
                    return new RangeRaw { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type RangeRaw");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeRaw)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type RangeRaw");
        }

        public static readonly RangeRawConverter Singleton = new RangeRawConverter();
    }

    internal class SignalRefExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SignalRefExtent) || t == typeof(SignalRefExtent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new SignalRefExtent { PurpleSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRawArray>>(reader);
                    return new SignalRefExtent { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SignalRefExtent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SignalRefExtent)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type SignalRefExtent");
        }

        public static readonly SignalRefExtentConverter Singleton = new SignalRefExtentConverter();
    }

    internal class ColorSchemeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColorScheme) || t == typeof(ColorScheme?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ColorScheme { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleSignalRef>(reader);
                    return new ColorScheme { PurpleSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new ColorScheme { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ColorScheme");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColorScheme)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.PurpleSignalRef != null)
            {
                serializer.Serialize(writer, value.PurpleSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type ColorScheme");
        }

        public static readonly ColorSchemeConverter Singleton = new ColorSchemeConverter();
    }

    internal class DivergingUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DivergingUnion) || t == typeof(DivergingUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new DivergingUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new DivergingUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new DivergingUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new DivergingUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new DivergingUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new DivergingUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new DivergingUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new DivergingUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DivergingSignalRef>(reader);
                    return new DivergingUnion { DivergingSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);
                    return new DivergingUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DivergingUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DivergingUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.DivergingSignalRef != null)
            {
                serializer.Serialize(writer, value.DivergingSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type DivergingUnion");
        }

        public static readonly DivergingUnionConverter Singleton = new DivergingUnionConverter();
    }

    internal class HeatmapUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HeatmapUnion) || t == typeof(HeatmapUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new HeatmapUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new HeatmapUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new HeatmapUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new HeatmapUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new HeatmapUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new HeatmapUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new HeatmapUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new HeatmapUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<HeatmapSignalRef>(reader);
                    return new HeatmapUnion { HeatmapSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);
                    return new HeatmapUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type HeatmapUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HeatmapUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.HeatmapSignalRef != null)
            {
                serializer.Serialize(writer, value.HeatmapSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type HeatmapUnion");
        }

        public static readonly HeatmapUnionConverter Singleton = new HeatmapUnionConverter();
    }

    internal class OrdinalUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OrdinalUnion) || t == typeof(OrdinalUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new OrdinalUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new OrdinalUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new OrdinalUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new OrdinalUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new OrdinalUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new OrdinalUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new OrdinalUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new OrdinalUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<OrdinalSignalRef>(reader);
                    return new OrdinalUnion { OrdinalSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);
                    return new OrdinalUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type OrdinalUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (OrdinalUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.OrdinalSignalRef != null)
            {
                serializer.Serialize(writer, value.OrdinalSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type OrdinalUnion");
        }

        public static readonly OrdinalUnionConverter Singleton = new OrdinalUnionConverter();
    }

    internal class RampUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RampUnion) || t == typeof(RampUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new RampUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new RampUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new RampUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new RampUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new RampUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new RampUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new RampUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new RampUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RampSignalRef>(reader);
                    return new RampUnion { RampSignalRef = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<RangeRaw>>(reader);
                    return new RampUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type RampUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RampUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.RampSignalRef != null)
            {
                serializer.Serialize(writer, value.RampSignalRef);
                return;
            }
            throw new Exception("Cannot marshal type RampUnion");
        }

        public static readonly RampUnionConverter Singleton = new RampUnionConverter();
    }

    internal class BindConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Bind) || t == typeof(Bind?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "scales")
            {
                return Bind.Scales;
            }
            throw new Exception("Cannot unmarshal type Bind");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Bind)untypedValue;
            if (value == Bind.Scales)
            {
                serializer.Serialize(writer, "scales");
                return;
            }
            throw new Exception("Cannot marshal type Bind");
        }

        public static readonly BindConverter Singleton = new BindConverter();
    }

    internal class LegendBindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendBinding) || t == typeof(LegendBinding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "legend")
                    {
                        return new LegendBinding { Enum = LegendBindingEnum.Legend };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LegendStreamBinding>(reader);
                    return new LegendBinding { LegendStreamBinding = objectValue };
            }
            throw new Exception("Cannot unmarshal type LegendBinding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LegendBinding)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == LegendBindingEnum.Legend)
                {
                    serializer.Serialize(writer, "legend");
                    return;
                }
            }
            if (value.LegendStreamBinding != null)
            {
                serializer.Serialize(writer, value.LegendStreamBinding);
                return;
            }
            throw new Exception("Cannot marshal type LegendBinding");
        }

        public static readonly LegendBindingConverter Singleton = new LegendBindingConverter();
    }

    internal class LegendBindingEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendBindingEnum) || t == typeof(LegendBindingEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "legend")
            {
                return LegendBindingEnum.Legend;
            }
            throw new Exception("Cannot unmarshal type LegendBindingEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegendBindingEnum)untypedValue;
            if (value == LegendBindingEnum.Legend)
            {
                serializer.Serialize(writer, "legend");
                return;
            }
            throw new Exception("Cannot marshal type LegendBindingEnum");
        }

        public static readonly LegendBindingEnumConverter Singleton = new LegendBindingEnumConverter();
    }

    internal class BindingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Binding) || t == typeof(Binding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "legend")
                    {
                        return new Binding { Enum = LegendBindingEnum.Legend };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, FluffyStream>>(reader);
                    return new Binding { AnythingMap = objectValue };
            }
            throw new Exception("Cannot unmarshal type Binding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Binding)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == LegendBindingEnum.Legend)
                {
                    serializer.Serialize(writer, "legend");
                    return;
                }
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type Binding");
        }

        public static readonly BindingConverter Singleton = new BindingConverter();
    }

    internal class FluffyStreamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyStream) || t == typeof(FluffyStream?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FluffyStream { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new FluffyStream { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyBinding>(reader);
                    return new FluffyStream { FluffyBinding = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new FluffyStream { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FluffyStream");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FluffyStream)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.FluffyBinding != null)
            {
                serializer.Serialize(writer, value.FluffyBinding);
                return;
            }
            throw new Exception("Cannot marshal type FluffyStream");
        }

        public static readonly FluffyStreamConverter Singleton = new FluffyStreamConverter();
    }

    internal class DiscreteHeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DiscreteHeightUnion) || t == typeof(DiscreteHeightUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new DiscreteHeightUnion { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DiscreteHeightClass>(reader);
                    return new DiscreteHeightUnion { DiscreteHeightClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type DiscreteHeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DiscreteHeightUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.DiscreteHeightClass != null)
            {
                serializer.Serialize(writer, value.DiscreteHeightClass);
                return;
            }
            throw new Exception("Cannot marshal type DiscreteHeightUnion");
        }

        public static readonly DiscreteHeightUnionConverter Singleton = new DiscreteHeightUnionConverter();
    }

    internal class DiscreteWidthUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DiscreteWidthUnion) || t == typeof(DiscreteWidthUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new DiscreteWidthUnion { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DiscreteWidthClass>(reader);
                    return new DiscreteWidthUnion { DiscreteWidthClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type DiscreteWidthUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DiscreteWidthUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.DiscreteWidthClass != null)
            {
                serializer.Serialize(writer, value.DiscreteWidthClass);
                return;
            }
            throw new Exception("Cannot marshal type DiscreteWidthUnion");
        }

        public static readonly DiscreteWidthUnionConverter Singleton = new DiscreteWidthUnionConverter();
    }

}
