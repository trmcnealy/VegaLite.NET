﻿using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive.Formatting;

using VegaLite.Schema;

using static VegaLite.HtmlChart;

namespace VegaLite
{
    public class WebglChart<TDataLayout>
        where TDataLayout : IEnumerable
    {
        public Guid Id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get;
        }

        public string Title
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get;
        }

        public Specification Specification
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get;
        }

        public string DataSetName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                if(!string.IsNullOrEmpty(Specification.Data?.Name))
                {
                    return Specification.Data.Name;
                }

                if(!string.IsNullOrEmpty(Specification.Spec?.DataSource?.Name))
                {
                    return Specification.Spec.DataSource.Name;
                }

                if(Specification.Data == null)
                {
                    Specification.Data = new DataSource();
                }

                Specification.Data.Name = $"dataset_{Id.ToString().Replace("-", "")}";

                return Specification.Data.Name;
            }
        }

        public double? Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Specification.Width?.Double; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Specification.Width = value; }
        }

        public double? Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Specification.Height?.Double; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Specification.Height = value; }
        }

        public InlineDataset? Data
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Specification.Data?.Values; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Specification.Data.Values = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static WebglChart()
        {
        }

        //private WebglChart()
        //{
        //    Id            = Guid.NewGuid();
        //    Specification = new Specification();
        //}

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        protected WebglChart(Guid? id)
        {
            if(id == null)
            {
                Id = Guid.NewGuid();
            }
            else if(Id == Guid.Empty)
            {
                Id = id.Value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Specification vegaLiteSpecification,
                          Guid?         id = null)
            : this(id)
        {
            Specification = vegaLiteSpecification;

            if(string.IsNullOrEmpty(Specification.Data?.Name) && string.IsNullOrEmpty(Specification.Spec?.DataSource?.Name))
            {
                if(Specification.Data == null)
                {
                    Specification.Data = new DataSource();
                }

                Specification.Data.Name = $"dataset_{Id.ToString().Replace("-", "")}";
            }

            if(Specification.Config == null)
            {
                Specification.Config = new Config()
                {
                    Legend = new LegendConfig()
                    {
                        Orient = LegendOrient.Top
                    }
                };
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Specification vegaLiteSpecification,
                          string        datasetName,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Specification.Data.Name = datasetName;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string        title,
                          Specification vegaLiteSpecification,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Title = title;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string        title,
                          Specification vegaLiteSpecification,
                          string        datasetName,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   datasetName,
                   id)
        {
            Title = title;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string        title,
                          Specification vegaLiteSpecification,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Title  = title;
            Width  = width;
            Height = height;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string        title,
                          Specification vegaLiteSpecification,
                          string        datasetName,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   datasetName,
                   id)
        {
            Title  = title;
            Width  = width;
            Height = height;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Specification vegaLiteSpecification,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Title  = vegaLiteSpecification.Description;
            Width  = width;
            Height = height;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Specification vegaLiteSpecification,
                          string        datasetName,
                          int           width,
                          int           height,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   datasetName,
                   id)
        {
            Title  = vegaLiteSpecification.Description;
            Width  = width;
            Height = height;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static Specification SetupSpec(Func<Guid, Specification> specFunc,
                                               out Guid                  id)
        {
            id = Guid.NewGuid();

            return specFunc(id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Func<Guid, Specification> specFunc)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Func<Guid, Specification> specFunc,
                          string                    datasetName)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string                    title,
                          Func<Guid, Specification> specFunc)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string                    title,
                          Func<Guid, Specification> specFunc,
                          string                    datasetName)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string                    title,
                          Func<Guid, Specification> specFunc,
                          int                       width,
                          int                       height)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   width,
                   height,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(string                    title,
                          Func<Guid, Specification> specFunc,
                          string                    datasetName,
                          int                       width,
                          int                       height)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   width,
                   height,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Func<Guid, Specification> specFunc,
                          int                       width,
                          int                       height)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   width,
                   height,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public WebglChart(Func<Guid, Specification> specFunc,
                          string                    datasetName,
                          int                       width,
                          int                       height)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   width,
                   height,
                   id)
        {
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return GetHtml();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string GetHtmlContent(int rows    = 1,
                                     int columns = -1)
        {
            if(columns == -1)
            {
                return WebglDataElementContentTemplate(Id,
                                                       Title,
                                                       rows,
                                                       typeof(TDataLayout).GetProperties().Length,
                                                       this);
            }

            return WebglDataElementContentTemplate(Id,
                                                   Title,
                                                   rows,
                                                   columns,
                                                   this);
        }

        private static bool registered = false;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string GetHtml(int rows = 1)
        {
            if(!registered)
            {
                Formatter<WebglChart<TDataLayout>>.Register((chart,
                                                             writer) =>
                                                            {
                                                                writer.Write(chart.GetHtmlContent(rows));
                                                            },
                                                            HtmlFormatter.MimeType);
            }

            return new HtmlString(HtmlTemplate(GetHtmlContent(rows))).ToString();
        }
    }
}
