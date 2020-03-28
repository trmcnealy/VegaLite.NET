using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive.Formatting;

using static VegaLite.HtmlChart;

namespace VegaLite
{
    public class Chart<TDataLayout>
    {
        public Guid Id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public string Title
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public Specification Specification
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public string DataSetName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Specification.Width?.Double; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Specification.Width = value; }
        }

        public double? Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Specification.Height?.Double; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Specification.Height = value; }
        }

        public InlineDataset? Data
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Specification.Data?.Values; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Specification.Data.Values = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static Chart()
        {
        }

        //private Chart()
        //{
        //    Id            = Guid.NewGuid();
        //    Specification = new Specification();
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Chart(Guid? id)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Specification vegaLiteSpecification,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Specification vegaLiteSpecification,
                     string        datasetName,
                     Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Specification.Data.Name = datasetName;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string        title,
                     Specification vegaLiteSpecification,
                     Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Title = title;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string        title,
                     Specification vegaLiteSpecification,
                     string        datasetName,
                     Guid?         id = null)
            : this(vegaLiteSpecification,
                   datasetName,
                   id)
        {
            Title = title;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string        title,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string        title,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Specification vegaLiteSpecification,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Specification vegaLiteSpecification,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Specification SetupSpec(Func<Guid, Specification> specFunc,
                                               out Guid                  id)
        {
            id = Guid.NewGuid();

            return specFunc(id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Func<Guid, Specification> specFunc)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Func<Guid, Specification> specFunc,
                     string                    datasetName)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string                    title,
                     Func<Guid, Specification> specFunc)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string                    title,
                     Func<Guid, Specification> specFunc,
                     string                    datasetName)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string                    title,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(string                    title,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Func<Guid, Specification> specFunc,
                     int                       width,
                     int                       height)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   width,
                   height,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Chart(Func<Guid, Specification> specFunc,
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return GetHtml();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtmlContent(int rows    = 1,
                                     int columns = -1)
        {
            if(columns == -1)
            {
                return DataElementContentTemplate(Id,
                                                  Title,
                                                  rows,
                                                  typeof(TDataLayout).GetProperties().Length,
                                                  this);
            }

            return DataElementContentTemplate(Id,
                                              Title,
                                              rows,
                                              columns,
                                              this);
        }

        private static bool registered = false;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtml(int rows = 1)
        {
            if(!registered)
            {
                Formatter<Chart<TDataLayout>>.Register((chart,
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
