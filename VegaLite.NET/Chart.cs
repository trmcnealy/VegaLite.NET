using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive.Formatting;

using static VegaLite.HtmlChart;

namespace VegaLite
{
    public class Chart
    {
        //static Chart()
        //{
        //    Formatter<Chart>.Register((chart,
        //                               writer) =>
        //                              {
        //                                  writer.Write(chart.ToString());
        //                              },
        //                              HtmlFormatter.MimeType);
        //}

        public Guid Id { get; }

        public string Title { get; }

        public Specification Specification { get; }

        public double? Width { get { return Specification.Width?.Double; } set { Specification.Width = value; } }

        public double? Height { get { return Specification.Height?.Double; } set { Specification.Height = value; } }

        public InlineDataset? Data { get { return Specification.DataSource.Values; } set { Specification.DataSource.Values = value; } }

        public Chart(string        title,
                     Specification vegaLiteSpecification)
        {
            Id            = Guid.NewGuid();
            Title         = title;
            Specification = vegaLiteSpecification;
        }

        public Chart(string        title,
                     Specification vegaLiteSpecification,
                     int           width,
                     int           height)
        {
            Id            = Guid.NewGuid();
            Title         = title;
            Specification = vegaLiteSpecification;
            Width         = width;
            Height        = height;
        }

        public Chart(Specification vegaLiteSpecification,
                     int           width,
                     int           height)
        {
            Id            = Guid.NewGuid();
            Title         = vegaLiteSpecification.Description;
            Specification = vegaLiteSpecification;
            Width         = width;
            Height        = height;
        }

        public override string ToString()
        {
            return GetHtml();
        }

        public string GetHtmlContent(string scripts = "")
        {
            return LoadContentTemplate(Id,
                                       Title,
                                       Specification.ToJson(), scripts);
        }

        public string GetHtml()
        {
            return $"{new HtmlString(GetHtmlContent(ScriptNodes))}";
        }

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