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
            get { return Specification.Data.Values; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Specification.Data.Values = value; }
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return GetHtml();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtmlContent(string scripts = "")
        {
            return LoadContentTemplate(Id,
                                       Title,
                                       Specification.ToJson(),
                                       scripts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtml()
        {
            return new HtmlString(GetHtmlContent(ScriptNodes)).ToString();
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