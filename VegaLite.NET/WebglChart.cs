using System;
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
    //TODO
    // Zoom
    // https://vega.github.io/editor/#/examples/vega/zoomable-scatter-plot
    public class WebglChart
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
        static WebglChart()
        {
            Formatter<WebglChart>.Register((chart,
                                            writer) =>
                                           {
                                               writer.Write(chart.ToString());
                                           },
                                           HtmlFormatter.MimeType);
        }

        //private WebglChart()
        //{
        //    Id            = Guid.NewGuid();
        //    Specification = new Specification();
        //}

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WebglChart(Specification vegaLiteSpecification,
                          string        datasetName,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Specification.Data.Name = datasetName;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WebglChart(string        title,
                          Specification vegaLiteSpecification,
                          Guid?         id = null)
            : this(vegaLiteSpecification,
                   id)
        {
            Title = title;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Specification SetupSpec(Func<Guid, Specification> specFunc,
                                               out Guid                  id)
        {
            id = Guid.NewGuid();

            return specFunc(id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WebglChart(Func<Guid, Specification> specFunc)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WebglChart(Func<Guid, Specification> specFunc,
                          string                    datasetName)
            : this(SetupSpec(specFunc,
                             out Guid id),
                   datasetName,
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WebglChart(string                    title,
                          Func<Guid, Specification> specFunc)
            : this(title,
                   SetupSpec(specFunc,
                             out Guid id),
                   id)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return GetHtml();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtmlContent()
        {
            return WebglElementContentTemplate(Id,
                                               Title,
                                               this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtml()
        {
            return new HtmlString(HtmlTemplate(GetHtmlContent())).ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShowInBrowser()
        {
            string tempPath = Path.GetTempPath();
            string path     = $"{Id.ToString()}.html";

            string text = Path.Combine(tempPath,
                                       path);

            File.WriteAllText(text,
                              GetHtml());

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = text, UseShellExecute = true
                };

                Process p = Process.Start(startInfo);

                if(p != null)
                {
                    p.EnableRaisingEvents = true;
                    p.WaitForInputIdle();
                }

                return;
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open",
                              text);

                return;
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open",
                              text);

                return;
            }

            throw new InvalidOperationException("Not supported OS platform");
        }
    }
}
