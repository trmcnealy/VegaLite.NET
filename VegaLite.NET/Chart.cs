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

namespace VegaLite
{
    public class Chart
    {
        public static string VegaUrl      = "https://cdn.jsdelivr.net/npm/vega@5.9.0";
        public static string VegaLiteUrl  = "https://cdn.jsdelivr.net/npm/vega-lite@4.0.2";
        public static string VegaEmbedUrl = "https://cdn.jsdelivr.net/npm/vega-embed@6.2.1";

        static Chart()
        {
            Formatter<Chart>.Register((chart,
                                       writer) =>
                                      {
                                          writer.Write(chart.ToString());
                                      },
                                      HtmlFormatter.MimeType);
        }

        //public static Func<Guid, string, string, string> Content = (id,
        //                                                            title,
        //                                                            spec) =>
        //                                                           {
        //                                                               string html = "<!DOCTYPE html>\n"                               +
        //                                                                             "<html>\n"                                        +
        //                                                                             "  <head>\n"                                      +
        //                                                                             "    <title>Vega-Lite Chart</title>\n"            +
        //                                                                             "    <meta charset=\"utf-8\" />\n"                +
        //                                                                             $"    <script src=\"{VegaUrl}\"></script>\n"      +
        //                                                                             $"    <script src=\"{VegaLiteUrl}\"></script>\n"  +
        //                                                                             $"    <script src=\"{VegaEmbedUrl}\"></script>\n" +
        //                                                                             "    <style media=\"screen\">\n"                  +
        //                                                                             "      .vega-actions a {\n"                       +
        //                                                                             "        margin-right: 5px;\n"                    +
        //                                                                             "      }\n"                                       +
        //                                                                             "    </style>\n"                                  +
        //                                                                             "  </head>\n"                                     +
        //                                                                             "  <body>\n"                                      +
        //                                                                             $"    <h1>{title}</h1>\n"                         +
        //                                                                             $"    <div id=\"vis{id}\"></div>\n"               +
        //                                                                             "    <script>\n"                                  +
        //                                                                             $"      var vlSpec = {spec};\n"                   +
        //                                                                             $"      vegaEmbed('#vis{id}', vlSpec);\n"         +
        //                                                                             "    </script>\n"                                 +
        //                                                                             "  </body>\n"                                     +
        //                                                                             "</html>\n";
        //                                                               return html;
        //                                                           };

        public static string LoadScript = "        var loadScript = function(url) {\n"                                                 +
                                          "            var script = document.createElement(\"script\");\n"                             +
                                          "            script.setAttribute(\"type\", \"text/javascript\");\n"                          +
                                          "            script.setAttribute(\"src\", url);\n"                                           +
                                          "            return script;\n"                                                               +
                                          "        };\n"                                                                               +
                                          "        \n"                                                                                 +
                                          $"        var vegaScript = loadScript(\"{VegaUrl}\");\n"                                     +
                                          "        vegaScript.onload = function(){\n"                                                  +
                                          $"            var vegaliteScript = loadScript(\"{VegaLiteUrl}\");\n"                         +
                                          "            vegaliteScript.onload = function(){\n"                                          +
                                          $"                var vegaembedScript = loadScript(\"{VegaEmbedUrl}\");\n"                   +
                                          "                vegaembedScript.onload = function(){\n"                                     +
                                          "                    renderVegaLite();\n"                                                    +
                                          "                };\n"                                                                       +
                                          "                document.getElementsByTagName(\"head\")[0].appendChild(vegaembedScript);\n" +
                                          "            };\n"                                                                           +
                                          "            document.getElementsByTagName(\"head\")[0].appendChild(vegaliteScript);\n"      +
                                          "        };\n"                                                                               +
                                          "        document.getElementsByTagName(\"head\")[0].appendChild(vegaScript);\n";

        public static Func<Guid, string, string, string> LoadContent = (id,
                                                                        title,
                                                                        spec) =>
                                                                       {
                                                                           string html = $"<div id=\"{id}\">\n"                           +
                                                                                         $"    <h1>{title}</h1>\n"                        +
                                                                                         $"    <div id=\"vis-{id}\"></div>\n"             +
                                                                                         "    <script type=\"text/javascript\">\n"        +
                                                                                         "        var renderVegaLite = function() {"      +
                                                                                         $"            var vlSpec = {spec};\n"            +
                                                                                         $"            vegaEmbed('#vis-{id}', vlSpec);\n" +
                                                                                         "        };"                                     +
                                                                                         "\n"                                             +
                                                                                         LoadScript                                       +
                                                                                         "\n"                                             +
                                                                                         "    </script>\n"                                +
                                                                                         "</div>\n";

                                                                           return html;
                                                                       };

        public Guid Id { get; }

        public string Title { get; }

        public Specification Specification { get; }

        public double? Width { get { return Specification.Width?.Double; } set { Specification.Width = value; } }

        public double? Height { get { return Specification.Height?.Double; } set { Specification.Height = value; } }

        public InlineDataset? Data { get { return Specification.Data.Values; } set { Specification.Data.Values = value; } }

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

        public override string ToString()
        {
            return GetHtml();
        }

        public string GetHtml()
        {
            return $"{new HtmlString(LoadContent(Id, Title, Specification.ToJson()))}";
        }
    }
}