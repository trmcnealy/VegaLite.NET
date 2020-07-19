using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

using Apache.Arrow;
using Apache.Arrow.Ipc;
using Apache.Arrow.Types;

using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive.Formatting;

using VegaLite.Schema;

using static VegaLite.HtmlChart;

using Array = Apache.Arrow.Array;
using Field = Apache.Arrow.Field;
using Column = Apache.Arrow.Column;
using Table = Apache.Arrow.Table;

namespace VegaLite
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ArrowPropertyAttribute : Attribute
    {
        public ArrowTypeId ArrowTypeId { get; }

        public string Name { get; }

        public bool IsNullable { get; }

        public ArrowPropertyAttribute(ArrowTypeId arrowTypeId,
                                      string      name,
                                      bool        isNullable = false)
        {
            ArrowTypeId = arrowTypeId;
            Name        = name;
            IsNullable  = isNullable;
        }

        public ArrowType ArrowType()
        {
            switch(ArrowTypeId)
            {
                case ArrowTypeId.Boolean:   return BooleanType.Default;
                case ArrowTypeId.UInt8:     return UInt8Type.Default;
                case ArrowTypeId.Int8:      return Int8Type.Default;
                case ArrowTypeId.UInt16:    return UInt16Type.Default;
                case ArrowTypeId.Int16:     return Int16Type.Default;
                case ArrowTypeId.UInt32:    return UInt32Type.Default;
                case ArrowTypeId.Int32:     return Int32Type.Default;
                case ArrowTypeId.UInt64:    return UInt64Type.Default;
                case ArrowTypeId.Int64:     return Int64Type.Default;
                case ArrowTypeId.Float:     return FloatType.Default;
                case ArrowTypeId.Double:    return DoubleType.Default;
                case ArrowTypeId.String:    return StringType.Default;
                case ArrowTypeId.Binary:    return BinaryType.Default;
                case ArrowTypeId.Timestamp: return TimestampType.Default;
                case ArrowTypeId.Date64:    return Date64Type.Default;
                case ArrowTypeId.Date32:    return Date32Type.Default;
                case ArrowTypeId.Time32:    return Time32Type.Default;
                case ArrowTypeId.Time64:    return Time64Type.Default;
                //case ArrowTypeId.List:
                //case ArrowTypeId.Struct:
                //case ArrowTypeId.Union:
                //case ArrowTypeId.Decimal:
                //case ArrowTypeId.Dictionary:
                //case ArrowTypeId.FixedSizedBinary:
                //case ArrowTypeId.HalfFloat:
                //case ArrowTypeId.Interval:
                //case ArrowTypeId.Map:
                default: throw new NotSupportedException($"An ArrowArray cannot be built for type {ArrowTypeId}.");
            }
        }
    }

    internal static class ArrowUtilities
    {
        public static readonly Dictionary<Type, ArrowTypeId> ArrowTypeMap = new Dictionary<Type, ArrowTypeId>();

        public static readonly Dictionary<ArrowTypeId, Type> ClrTypeMap = new Dictionary<ArrowTypeId, Type>();

        static ArrowUtilities()
        {
            ArrowTypeMap[typeof(void)]    = ArrowTypeId.Null;
            ArrowTypeMap[typeof(bool)]    = ArrowTypeId.Boolean;
            ArrowTypeMap[typeof(sbyte)]   = ArrowTypeId.Int8;
            ArrowTypeMap[typeof(byte)]    = ArrowTypeId.UInt8;
            ArrowTypeMap[typeof(short)]   = ArrowTypeId.Int16;
            ArrowTypeMap[typeof(ushort)]  = ArrowTypeId.UInt16;
            ArrowTypeMap[typeof(int)]     = ArrowTypeId.Int32;
            ArrowTypeMap[typeof(uint)]    = ArrowTypeId.UInt32;
            ArrowTypeMap[typeof(long)]    = ArrowTypeId.Int64;
            ArrowTypeMap[typeof(ulong)]   = ArrowTypeId.UInt64;
            ArrowTypeMap[typeof(float)]   = ArrowTypeId.Float;
            ArrowTypeMap[typeof(double)]  = ArrowTypeId.Double;
            ArrowTypeMap[typeof(decimal)] = ArrowTypeId.Decimal;
            ArrowTypeMap[typeof(string)]  = ArrowTypeId.String;

            ClrTypeMap[ArrowTypeId.Null]    = typeof(void);
            ClrTypeMap[ArrowTypeId.Boolean] = typeof(bool);
            ClrTypeMap[ArrowTypeId.Int8]    = typeof(sbyte);
            ClrTypeMap[ArrowTypeId.UInt8]   = typeof(byte);
            ClrTypeMap[ArrowTypeId.Int16]   = typeof(short);
            ClrTypeMap[ArrowTypeId.UInt16]  = typeof(ushort);
            ClrTypeMap[ArrowTypeId.Int32]   = typeof(int);
            ClrTypeMap[ArrowTypeId.UInt32]  = typeof(uint);
            ClrTypeMap[ArrowTypeId.Int64]   = typeof(long);
            ClrTypeMap[ArrowTypeId.UInt64]  = typeof(ulong);
            ClrTypeMap[ArrowTypeId.Float]   = typeof(float);
            ClrTypeMap[ArrowTypeId.Double]  = typeof(double);
            ClrTypeMap[ArrowTypeId.Decimal] = typeof(decimal);
            ClrTypeMap[ArrowTypeId.String]  = typeof(string);
        }

        public static Type GetClrType(ArrowTypeId arrowTypeId)
        {
            if(ClrTypeMap.TryGetValue(arrowTypeId,
                                      out Type type))
            {
                return type;
            }

            return arrowTypeId.GetType();
        }

        public static ArrowType GetArrowType(Type type)
        {
            if(ArrowTypeMap.TryGetValue(type,
                                        out ArrowTypeId arrowType))
            {
                switch(arrowType)
                {
                    case ArrowTypeId.Boolean:
                    {
                        return BooleanType.Default;
                    }
                    case ArrowTypeId.UInt8:
                    {
                        return UInt8Type.Default;
                    }
                    case ArrowTypeId.Int8:
                    {
                        return Int8Type.Default;
                    }
                    case ArrowTypeId.UInt16:
                    {
                        return UInt16Type.Default;
                    }
                    case ArrowTypeId.Int16:
                    {
                        return Int16Type.Default;
                    }
                    case ArrowTypeId.UInt32:
                    {
                        return UInt32Type.Default;
                    }
                    case ArrowTypeId.Int32:
                    {
                        return Int32Type.Default;
                    }
                    case ArrowTypeId.UInt64:
                    {
                        return UInt64Type.Default;
                    }
                    case ArrowTypeId.Int64:
                    {
                        return Int64Type.Default;
                    }
                    case ArrowTypeId.Float:
                    {
                        return FloatType.Default;
                    }
                    case ArrowTypeId.Double:
                    {
                        return DoubleType.Default;
                    }
                    //case ArrowTypeId.Decimal: { return DecimalType()); }
                    case ArrowTypeId.String:
                    {
                        return StringType.Default;
                    }
                    //case ArrowTypeId.Null:
                    //case ArrowTypeId.HalfFloat:
                    //case ArrowTypeId.Binary:
                    //case ArrowTypeId.FixedSizedBinary:
                    //case ArrowTypeId.Date32:
                    //case ArrowTypeId.Date64:
                    //case ArrowTypeId.Timestamp:
                    //case ArrowTypeId.Time32:
                    //case ArrowTypeId.Time64:
                    //case ArrowTypeId.Interval:
                    //case ArrowTypeId.List:
                    //case ArrowTypeId.Struct:
                    //case ArrowTypeId.Union:
                    //case ArrowTypeId.Dictionary:
                    //case ArrowTypeId.Map:
                    //default: { break; }
                }
            }

            if(type.IsValueType)
            {
                //return new StructType(property.PropertyType.GetFields()));
            }

            if(type.IsEnum)
            {
                if(ArrowTypeMap.TryGetValue(Enum.GetUnderlyingType(type),
                                            out ArrowTypeId arrowUnderlyingType))
                {
                    switch(arrowUnderlyingType)
                    {
                        case ArrowTypeId.UInt8:
                        {
                            return UInt8Type.Default;
                        }
                        case ArrowTypeId.Int8:
                        {
                            return Int8Type.Default;
                        }
                        case ArrowTypeId.UInt16:
                        {
                            return UInt16Type.Default;
                        }
                        case ArrowTypeId.Int16:
                        {
                            return Int16Type.Default;
                        }
                        case ArrowTypeId.UInt32:
                        {
                            return UInt32Type.Default;
                        }
                        case ArrowTypeId.Int32:
                        {
                            return Int32Type.Default;
                        }
                        case ArrowTypeId.UInt64:
                        {
                            return UInt64Type.Default;
                        }
                        case ArrowTypeId.Int64:
                        {
                            return Int64Type.Default;
                        }
                    }
                }
            }

            return null;
        }

        public static Array GetArrowArray(Type      type,
                                          ArrayData data)
        {
            if(ArrowTypeMap.TryGetValue(type,
                                        out ArrowTypeId arrowType))
            {
                switch(arrowType)
                {
                    case ArrowTypeId.Boolean:
                    {
                        return new BooleanArray(data);
                    }
                    case ArrowTypeId.UInt8:
                    {
                        return new UInt8Array(data);
                    }
                    case ArrowTypeId.Int8:
                    {
                        return new Int8Array(data);
                    }
                    case ArrowTypeId.UInt16:
                    {
                        return new UInt16Array(data);
                    }
                    case ArrowTypeId.Int16:
                    {
                        return new Int16Array(data);
                    }
                    case ArrowTypeId.UInt32:
                    {
                        return new UInt32Array(data);
                    }
                    case ArrowTypeId.Int32:
                    {
                        return new Int32Array(data);
                    }
                    case ArrowTypeId.UInt64:
                    {
                        return new UInt64Array(data);
                    }
                    case ArrowTypeId.Int64:
                    {
                        return new Int64Array(data);
                    }
                    case ArrowTypeId.Float:
                    {
                        return new FloatArray(data);
                    }
                    case ArrowTypeId.Double:
                    {
                        return new DoubleArray(data);
                    }
                    //case ArrowTypeId.Decimal: { return new DecimalType()); }
                    case ArrowTypeId.String:
                    {
                        return new StringArray(data);
                    }
                }
            }

            return null;
        }

        public static Array GetArrowArray(Field     field,
                                          ArrayData data)
        {
            switch(field.DataType.TypeId)
            {
                case ArrowTypeId.Boolean:
                {
                    return new BooleanArray(data);
                }
                case ArrowTypeId.UInt8:
                {
                    return new UInt8Array(data);
                }
                case ArrowTypeId.Int8:
                {
                    return new Int8Array(data);
                }
                case ArrowTypeId.UInt16:
                {
                    return new UInt16Array(data);
                }
                case ArrowTypeId.Int16:
                {
                    return new Int16Array(data);
                }
                case ArrowTypeId.UInt32:
                {
                    return new UInt32Array(data);
                }
                case ArrowTypeId.Int32:
                {
                    return new Int32Array(data);
                }
                case ArrowTypeId.UInt64:
                {
                    return new UInt64Array(data);
                }
                case ArrowTypeId.Int64:
                {
                    return new Int64Array(data);
                }
                case ArrowTypeId.Float:
                {
                    return new FloatArray(data);
                }
                case ArrowTypeId.Double:
                {
                    return new DoubleArray(data);
                }
                case ArrowTypeId.String:
                {
                    return new StringArray(data);
                }
            }

            return null;
        }

        public static Array MakeArrayBuffer(IArrowType  dataType,
                                            ICollection data)
        {
            switch(dataType.TypeId)
            {
                case ArrowTypeId.Boolean:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<bool>);
                case ArrowTypeId.UInt8:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<byte>);
                case ArrowTypeId.Int8:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<sbyte>);
                case ArrowTypeId.UInt16:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<ushort>);
                case ArrowTypeId.Int16:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<short>);
                case ArrowTypeId.UInt32:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<uint>);
                case ArrowTypeId.Int32:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<int>);
                case ArrowTypeId.UInt64:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<ulong>);
                case ArrowTypeId.Int64:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<long>);
                case ArrowTypeId.Float:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<float>);
                case ArrowTypeId.Double:
                    return MakeArrayBuffer(dataType,
                                           data.Count,
                                           data as IEnumerable<double>);
                //case ArrowTypeId.String:
                //case ArrowTypeId.Binary:
                //case ArrowTypeId.Timestamp:
                //case ArrowTypeId.Date64:
                //case ArrowTypeId.Date32:
                //case ArrowTypeId.Time32:
                //case ArrowTypeId.Time64:
                //case ArrowTypeId.List:
                //case ArrowTypeId.Struct:
                //case ArrowTypeId.Union:
                //case ArrowTypeId.Decimal:
                //case ArrowTypeId.Dictionary:
                //case ArrowTypeId.FixedSizedBinary:
                //case ArrowTypeId.HalfFloat:
                //case ArrowTypeId.Interval:
                //case ArrowTypeId.Map:
                default: throw new NotSupportedException($"An ArrowArray cannot be built for type {dataType.TypeId}.");
            }
        }

        public static Array MakeArrayBuffer<T>(IArrowType     dataType,
                                               int            length,
                                               IEnumerable<T> data)
            where T : struct
        {
            ArrowBuffer.Builder<T> builder = new ArrowBuffer.Builder<T>();

            builder.AppendRange(data);

            ArrowBuffer buffer = builder.Build();

            ArrayData arrayData = new ArrayData(dataType,
                                                length,
                                                0,
                                                0,
                                                new[]
                                                {
                                                    buffer
                                                });

            Array array = ArrowArrayFactory.BuildArray(arrayData) as Array;

            return array;
        }

        public static void ConvertCsv2Arrow()
        {
            //ArrowFileReader input = ArrowFileReader.FromFile("C:/Users/tehgo/Desktop/PSO.csv");

            //List<Field> fields = new List<Field>(properties.Length);

            //Apache.Arrow.Schema.Builder schemaBuilder = new Apache.Arrow.Schema.Builder();

            //foreach(PropertyInfo property in properties)
            //{
            //    ArrowPropertyAttribute arrowPropertyAttribute = property.GetCustomAttribute<ArrowPropertyAttribute>();

            //    Field field = new Field.Builder().Name(arrowPropertyAttribute.Name).DataType(arrowPropertyAttribute.ArrowType()).Build();

            //    schemaBuilder.Field(field);

            //    fields.Add(field);
            //}

            //schemaBuilder.Build()

            //ArrowFileWriter output = new ArrowFileWriter(new FileStream("C:/Users/tehgo/Desktop/PSO.arrow", FileMode.CreateNew, FileAccess.Write), Schema schema);

            //arrow::Status      st;
            //arrow::MemoryPool* pool = arrow::default_memory_pool();

            //std::shared_ptr<arrow::io::InputStream> input;
            //st = arrow::io::ReadableFile::Open("C:/Users/tehgo/Desktop/PSO.csv").Value(&input);

            //if(!st.ok())
            //{
            //    std::cout << st.message() << std::endl;
            //}

            //arrow::csv::ReadOptions read_options = arrow::csv::ReadOptions::Defaults();
            //// read_options.column_names = {"Iteration",
            ////                             "SwarmIndex",
            ////                             "Particle",
            ////                             "km",
            ////                             "Particle0Velocity",
            ////                             "kF",
            ////                             "Particle1Velocity",
            ////                             "kf",
            ////                             "Particle2Velocity",
            ////                             "ye",
            ////                             "Particle3Velocity",
            ////                             "LF",
            ////                             "Particle4Velocity",
            ////                             "Lf",
            ////                             "Particle5Velocity",
            ////                             "sk",
            ////                             "Particle6Velocity"};

            //arrow::csv::ParseOptions parse_options = arrow::csv::ParseOptions::Defaults();

            //arrow::csv::ConvertOptions convert_options        = arrow::csv::ConvertOptions::Defaults();
            //convert_options.column_types["Iteration"]         = arrow::int32();
            //convert_options.column_types["SwarmIndex"]        = arrow::int32();
            //convert_options.column_types["Particle"]          = arrow::int32();
            //convert_options.column_types["Particle0Position"] = arrow::float64();
            //convert_options.column_types["Particle0Velocity"] = arrow::float64();
            //convert_options.column_types["Particle1Position"] = arrow::float64();
            //convert_options.column_types["Particle1Velocity"] = arrow::float64();
            //convert_options.column_types["Particle2Position"] = arrow::float64();
            //convert_options.column_types["Particle2Velocity"] = arrow::float64();
            //convert_options.column_types["Particle3Position"] = arrow::float64();
            //convert_options.column_types["Particle3Velocity"] = arrow::float64();
            //convert_options.column_types["Particle4Position"] = arrow::float64();
            //convert_options.column_types["Particle4Velocity"] = arrow::float64();
            //convert_options.column_types["Particle5Position"] = arrow::float64();
            //convert_options.column_types["Particle5Velocity"] = arrow::float64();
            //convert_options.column_types["Particle6Position"] = arrow::float64();
            //convert_options.column_types["Particle6Velocity"] = arrow::float64();

            //convert_options.include_columns = {
            //    "Iteration", "SwarmIndex", "Particle", "Particle0Position", "Particle1Position", "Particle2Position", "Particle3Position", "Particle4Position", "Particle5Position"};

            //std::shared_ptr<arrow::csv::TableReader> reader;
            //st = arrow::csv::TableReader::Make(pool, input, read_options, parse_options, convert_options).Value(&reader);

            //if(!st.ok())
            //{
            //    std::cout << st.message() << std::endl;
            //}

            //std::shared_ptr<arrow::Table> table;

            //st = reader->Read().Value(&table);

            //if(!st.ok())
            //{
            //    std::cout << st.message() << std::endl;
            //}

            //std::shared_ptr<arrow::io::OutputStream> output;
            //st = arrow::io::FileOutputStream::Open("C:/Users/tehgo/Desktop/PSO.arrow").Value(&output);
            //st = arrow::io::CompressedOutputStream::Make(new arrow::util::GZipCodec(), output).Value(&output);

            //if(!st.ok())
            //{
            //    std::cout << st.message() << std::endl;
            //}

            //std::shared_ptr<arrow::ipc::RecordBatchWriter> writer;
            //st = arrow::ipc::NewFileWriter(output.get(), table->schema()).Value(&writer);

            //if(!st.ok())
            //{
            //    std::cout << st.message() << std::endl;
            //}

            //writer->WriteTable(*table);
        }
    }

    internal sealed class ArrowChart<TDataLayout> : Chart<TDataLayout>
        where TDataLayout : IEnumerable
    {
        //public static Apache.Arrow.Schema Schema
        //{
        //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //    get;
        //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //    set;
        //}

        //static ArrowChart()
        //{
        //    Apache.Arrow.Schema.Builder _schemaBuilder = new Apache.Arrow.Schema.Builder();

        //    foreach(PropertyInfo property in typeof(TDataLayout).GetProperties())
        //    {
        //        Field.Builder builder = new Field.Builder();

        //        ArrowType arrowType = ArrowUtilities.GetArrowType(property.PropertyType);

        //        if(arrowType != null)
        //        {
        //            builder.Name(property.Name).DataType(arrowType);
        //        }
        //        else
        //        {
        //            Type isNullableType = Nullable.GetUnderlyingType(property.PropertyType);

        //            if(isNullableType != null)
        //            {
        //                ArrowType nullableArrowType = ArrowUtilities.GetArrowType(isNullableType);

        //                if(nullableArrowType != null)
        //                {
        //                    builder.Name(property.Name).Nullable(true).DataType(nullableArrowType);
        //                }
        //                else
        //                {
        //                    builder.Name(property.Name).DataType(new BinaryType());
        //                }
        //            }
        //        }

        //        _schemaBuilder.Field(builder.Build());
        //    }

        //    Schema = _schemaBuilder.Build();
        //}

        #region Constructors

        public ArrowChart(Guid? id)
            : base(id)
        {
        }

        public ArrowChart(Specification vegaLiteSpecification,
                          Guid?         id = null)
            : base(vegaLiteSpecification,
                   id)
        {
        }

        public ArrowChart(Specification vegaLiteSpecification,
                          string        datasetName,
                          Guid?         id = null)
            : base(vegaLiteSpecification,
                   datasetName,
                   id)
        {
        }

        public ArrowChart(string        title,
                          Specification vegaLiteSpecification,
                          Guid?         id = null)
            : base(title,
                   vegaLiteSpecification,
                   id)
        {
        }

        public ArrowChart(string        title,
                          Specification vegaLiteSpecification,
                          string        datasetName,
                          Guid?         id = null)
            : base(title,
                   vegaLiteSpecification,
                   datasetName,
                   id)
        {
        }

        public ArrowChart(string        title,
                          Specification vegaLiteSpecification,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : base(title,
                   vegaLiteSpecification,
                   width,
                   height,
                   id)
        {
        }

        public ArrowChart(string        title,
                          Specification vegaLiteSpecification,
                          string        datasetName,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : base(title,
                   vegaLiteSpecification,
                   datasetName,
                   width,
                   height,
                   id)
        {
        }

        public ArrowChart(Specification vegaLiteSpecification,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : base(vegaLiteSpecification,
                   width,
                   height,
                   id)
        {
        }

        public ArrowChart(Specification vegaLiteSpecification,
                          string        datasetName,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : base(vegaLiteSpecification,
                   datasetName,
                   width,
                   height,
                   id)
        {
        }

        public ArrowChart(Func<Guid, Specification> specFunc)
            : base(specFunc)
        {
        }

        public ArrowChart(Func<Guid, Specification> specFunc,
                          string                    datasetName)
            : base(specFunc,
                   datasetName)
        {
        }

        public ArrowChart(string                    title,
                          Func<Guid, Specification> specFunc)
            : base(title,
                   specFunc)
        {
        }

        public ArrowChart(string                    title,
                          Func<Guid, Specification> specFunc,
                          string                    datasetName)
            : base(title,
                   specFunc,
                   datasetName)
        {
        }

        public ArrowChart(string                    title,
                          Func<Guid, Specification> specFunc,
                          int                       width,
                          int                       height)
            : base(title,
                   specFunc,
                   width,
                   height)
        {
        }

        public ArrowChart(string                    title,
                          Func<Guid, Specification> specFunc,
                          string                    datasetName,
                          int                       width,
                          int                       height)
            : base(title,
                   specFunc,
                   datasetName,
                   width,
                   height)
        {
        }

        public ArrowChart(Func<Guid, Specification> specFunc,
                          int                       width,
                          int                       height)
            : base(specFunc,
                   width,
                   height)
        {
        }

        public ArrowChart(Func<Guid, Specification> specFunc,
                          string                    datasetName,
                          int                       width,
                          int                       height)
            : base(specFunc,
                   datasetName,
                   width,
                   height)
        {
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public new string GetHtmlContent(int rows    = 1,
                                         int columns = -1)
        {
            if(columns == -1)
            {
                return ArrowDataElementContentTemplate(Id,
                                                       Title,
                                                       rows,
                                                       typeof(TDataLayout).GetProperties().Length,
                                                       this);
            }

            return ArrowDataElementContentTemplate(Id,
                                                   Title,
                                                   rows,
                                                   columns,
                                                   this);
        }

        private static bool registered = false;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public new string GetHtml(int rows = 1)
        {
            if(!registered)
            {
                Formatter<ArrowChart<TDataLayout>>.Register((chart,
                                                             writer) =>
                                                            {
                                                                writer.Write(chart.GetHtmlContent(rows));
                                                            },
                                                            HtmlFormatter.MimeType);
            }

            return new HtmlString(HtmlTemplate(GetHtmlContent(rows))).ToString();
        }

        public static Table BuildTable(List<TDataLayout> data)
        {
            PropertyInfo[] properties = typeof(TDataLayout).GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.GetCustomAttribute<ArrowPropertyAttribute>() != null).ToArray();

            //int length = data.Count;

            List<Field> fields = new List<Field>(properties.Length);

            Apache.Arrow.Schema.Builder schemaBuilder = new Apache.Arrow.Schema.Builder();

            foreach(PropertyInfo property in properties)
            {
                ArrowPropertyAttribute arrowPropertyAttribute = property.GetCustomAttribute<ArrowPropertyAttribute>();

                Field field = new Field.Builder().Name(arrowPropertyAttribute.Name).DataType(arrowPropertyAttribute.ArrowType()).Build();

                schemaBuilder.Field(field);

                fields.Add(field);
            }

            List<List<object>> transformData = new List<List<object>>(properties.Length);

            for(int i = 0; i < properties.Length; ++i)
            {
                transformData.Add(new List<object>(data.Count));
            }

            for(int i = 0; i < data.Count; ++i)
            {
                int j = 0;

                foreach(object property in data[i])
                {
                    transformData[j++][i] = property;
                }
            }

            List<Column> columns = new List<Column>(properties.Length);

            for(int i = 0; i < properties.Length; ++i)
            {
                Array array = ArrowUtilities.MakeArrayBuffer(fields[i].DataType,
                                                             transformData[i]);

                Column column = new Column(fields[i],
                                           new Array[]
                                           {
                                               array
                                           });

                columns.Add(column);
            }

            //NativeMemoryAllocator memoryAllocator = new NativeMemoryAllocator(32);

            Table table = new Table(schemaBuilder.Build(),
                                    columns);

            return table;
        }
    }
}
