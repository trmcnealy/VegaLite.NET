using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace VegaLite
{
    public class Chart
    {
        public static string VegaUrl      = "https://cdn.jsdelivr.net/npm/vega@5.9.0";
        public static string VegaLiteUrl  = "https://cdn.jsdelivr.net/npm/vega-lite@4.0.2";
        public static string VegaEmbedUrl = "https://cdn.jsdelivr.net/npm/vega-embed@6.2.1";

        public static Func<Guid, string, string, string> Content = (id,
                                                                    title,
                                                                    spec) =>
                                                                   {
                                                                       string html = "<!DOCTYPE html>\n"                               +
                                                                                     "<html>\n"                                        +
                                                                                     "  <head>\n"                                      +
                                                                                     "    <title>Vega-Lite Chart</title>\n"            +
                                                                                     "    <meta charset=\"utf-8\" />\n"                +
                                                                                     $"    <script src=\"{VegaUrl}\"></script>\n"      +
                                                                                     $"    <script src=\"{VegaLiteUrl}\"></script>\n"  +
                                                                                     $"    <script src=\"{VegaEmbedUrl}\"></script>\n" +
                                                                                     "    <style media=\"screen\">\n"                  +
                                                                                     "      .vega-actions a {\n"                       +
                                                                                     "        margin-right: 5px;\n"                    +
                                                                                     "      }\n"                                       +
                                                                                     "    </style>\n"                                  +
                                                                                     "  </head>\n"                                     +
                                                                                     "  <body>\n"                                      +
                                                                                     $"    <h1>{title}</h1>\n"                         +
                                                                                     $"    <div id=\"vis{id}\"></div>\n"               +
                                                                                     "    <script>\n"                                  +
                                                                                     $"      var vlSpec = {spec};\n"                   +
                                                                                     $"      vegaEmbed('#vis{id}', vlSpec);\n"         +
                                                                                     "    </script>\n"                                 +
                                                                                     "  </body>\n"                                     +
                                                                                     "</html>\n";

                                                                       return html;
                                                                   };

        public Guid Id { get; }

        public string Title { get; }

        public VegaLiteSpecification Specification { get; }

        public double? Width { get { return Specification.Width?.Double; } set { Specification.Width = value; } }

        public double? Height { get { return Specification.Height?.Double; } set { Specification.Height = value; } }

        public InlineDataset? Data { get { return Specification.Data.Values; } set { Specification.Data.Values = value; } }

        public Chart(string                title,
                     VegaLiteSpecification vegaLiteSpecification)
        {
            Id            = Guid.NewGuid();
            Title         = title;
            Specification = vegaLiteSpecification;
        }

        public Chart(string                title,
                     VegaLiteSpecification vegaLiteSpecification,
                     int                   width,
                     int                   height)
        {
            Id            = Guid.NewGuid();
            Title         = title;
            Specification = vegaLiteSpecification;
            Width         = width;
            Height        = height;
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

                Process.Start(startInfo);

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

        public override string ToString()
        {
            return Content(Id,
                           Title,
                           Specification.ToJson());
        }
    }
}