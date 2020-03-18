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
    public class Chart
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

                Specification.Data = new DataSource
                {
                    Name = $"dataset_{Id.ToString().Replace("-", "")}"
                };
                
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
            Formatter<Chart>.Register((chart,
                                       writer) =>
                                      {
                                          writer.Write(chart.ToString());
                                      },
                                      HtmlFormatter.MimeType);
        }

        //private Chart()
        //{
        //    Id            = Guid.NewGuid();
        //    Specification = new Specification();
        //}

        public Chart(Specification vegaLiteSpecification)
        {
            Id            = Guid.NewGuid();
            Specification = vegaLiteSpecification;

            if(string.IsNullOrEmpty(Specification.Data?.Name) && string.IsNullOrEmpty(Specification.Spec?.DataSource?.Name))
            {
                Specification.Data = new DataSource
                {
                    Name = $"dataset_{Id.ToString().Replace("-", "")}"
                };
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

        public Chart(Specification vegaLiteSpecification,
                     string        datasetName)
            : this(vegaLiteSpecification)
        {
            Specification.Data.Name = datasetName;
        }

        public Chart(string        title,
                     Specification vegaLiteSpecification)
            : this(vegaLiteSpecification)
        {
            Title = title;
        }

        public Chart(string        title,
                     Specification vegaLiteSpecification,
                     string        datasetName)
            : this(vegaLiteSpecification,
                   datasetName)
        {
            Title = title;
        }

        public Chart(string        title,
                     Specification vegaLiteSpecification,
                     int           width,
                     int           height)
            : this(vegaLiteSpecification)
        {
            Title  = title;
            Width  = width;
            Height = height;
        }

        public Chart(string        title,
                     Specification vegaLiteSpecification,
                     string        datasetName,
                     int           width,
                     int           height)
            : this(vegaLiteSpecification,
                   datasetName)
        {
            Title  = title;
            Width  = width;
            Height = height;
        }

        public Chart(Specification vegaLiteSpecification,
                     int           width,
                     int           height)
            : this(vegaLiteSpecification)
        {
            Title  = vegaLiteSpecification.Description;
            Width  = width;
            Height = height;
        }

        public Chart(Specification vegaLiteSpecification,
                     string        datasetName,
                     int           width,
                     int           height)
            : this(vegaLiteSpecification,
                   datasetName)
        {
            Title  = vegaLiteSpecification.Description;
            Width  = width;
            Height = height;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return GetHtml();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtmlContent()
        {
            return ElementContentTemplate(Id,
                                          Title,
                                          Specification.ToJson());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtml()
        {
            return new HtmlString(HtmlTemplateSingleId(this,
                                                       GetHtmlContent())).ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShowInBrowser()
        {
            string tempPath = Path.GetTempPath();
            string path     = $"{Id.ToString()}.html";

            string text = Path.Combine(tempPath,
                                       path);

            File.WriteAllText(text,
                              ToString());

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
