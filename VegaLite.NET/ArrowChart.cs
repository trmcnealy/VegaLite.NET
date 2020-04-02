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
    public sealed class ArrowChart : Chart
    {
        static ArrowChart()
        {
            Formatter<ArrowChart>.Register((chart,
                                            writer) =>
                                           {
                                               writer.Write(chart.GetHtmlContent());
                                           },
                                           HtmlFormatter.MimeType);
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new string GetHtmlContent()
        {
            return ArrowElementContentTemplate(Id,
                                               Title,
                                               this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new string GetHtml()
        {
            return new HtmlString(HtmlTemplate(GetHtmlContent())).ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new void ShowInBrowser()
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
