using System;

namespace VegaLite
{
    internal static class HtmlChart
    {
        public static string VegaUrl      = "https://cdn.jsdelivr.net/npm/vega@5.9.0";
        public static string VegaLiteUrl  = "https://cdn.jsdelivr.net/npm/vega-lite@4.0.2";
        public static string VegaEmbedUrl = "https://cdn.jsdelivr.net/npm/vega-embed@6.2.1";

        public static readonly Func<int, string> ind = (amount) => string.Empty.PadLeft(amount * 4,
                                                                                        '\u0020');

        //public static readonly string LoadScriptFunction = $"{ind(2)}var loadScript = function(url, uid) {{\n"                       +
        //                                                   $"{ind(2)}{ind(1)}var script = document.getElementById(uid);\n"           +
        //                                                   $"{ind(2)}{ind(1)}if(script == null) {{\n"                                +
        //                                                   $"{ind(2)}{ind(1)}{ind(1)}script = document.createElement(\"script\");\n" +
        //                                                   //$"{ind(2)}{ind(1)}{ind(1)}script.setAttribute(\"id\", uid);\n"                               +
        //                                                   $"{ind(2)}{ind(1)}{ind(1)}script.setAttribute(\"type\", \"text/javascript\");\n"             +
        //                                                   $"{ind(2)}{ind(1)}{ind(1)}script.setAttribute(\"src\", url);\n"                              +
        //                                                   $"{ind(2)}{ind(1)}{ind(1)}document.getElementsByTagName(\"head\")[0].appendChild(script);\n" +
        //                                                   $"{ind(2)}{ind(1)}}}\n"                                                                      +
        //                                                   $"{ind(2)}{ind(1)}return script;\n"                                                          +
        //                                                   $"{ind(2)}}};\n";

        // public static readonly string SetPageEncoding = $"{ind(1)}<script type=\"text/javascript\">\n"                        +
        //                                                 $"{ind(2)}(function() {{\n"                                           +
        //                                                 $"{ind(3)}script = document.createElement(\"meta\");\n"               +
        //                                                 $"{ind(3)}script.setAttribute(\"charset\", \"utf-8\");\n"             +
        //                                                 $"{ind(3)}var header = document.getElementsByTagName(\"head\")[0];\n" +
        //                                                 $"{ind(3)}header.insertBefore(script, header.firstChild);\n"          +
        //                                                 $"{ind(2)}}})();\n"                                                   +
        //                                                 LoadScriptFunction                                                    +
        //                                                 $"{ind(1)}</script>\n";

        //public static readonly string SetPageEncoding = $"{ind(1)}<script type=\"text/javascript\">\n"                        +
        //                                                LoadScriptFunction                                                    +
        //                                                $"{ind(2)}(function() {{\n"                                                             +
        //                                                $"{ind(3)}var vegaScript = loadScript(\"{VegaUrl}\", \"VegaScript\");\n"                +
        //                                                $"{ind(3)}var vegaliteScript = loadScript(\"{VegaLiteUrl}\", \"VegaLiteScript\");\n"    +
        //                                                $"{ind(3)}var vegaembedScript = loadScript(\"{VegaEmbedUrl}\", \"VegaEmbedScript\");\n" +
        //                                                $"{ind(2)}}})();\n"+
        //                                                $"{ind(1)}</script>\n";

        //public static readonly Func<Guid, string> LoadScriptTemplate = (id) => LoadScriptFunction +
        //                                                                       $"{ind(2)}\n"      +
        //                                                                       //$"{ind(2)}(function() {{\n"                                                             +
        //                                                                       $"{ind(3)}var vegaScript = loadScript(\"{VegaUrl}\", \"VegaScript\");\n"                +
        //                                                                       $"{ind(3)}var vegaliteScript = loadScript(\"{VegaLiteUrl}\", \"VegaLiteScript\");\n"    +
        //                                                                       $"{ind(3)}var vegaembedScript = loadScript(\"{VegaEmbedUrl}\", \"VegaEmbedScript\");\n" +
        //                                                                       $"{ind(3)}\n"                                                                           +
        //                                                                       $"{ind(3)}vegaembedScript.onload = function(){{\n"                                      +
        //                                                                       $"{ind(3)}{ind(1)}renderVegaLite();\n"                                                  +
        //                                                                       $"{ind(3)}}};\n";

        public static readonly string ScriptNodes = $"{ind(1)}<script src=\"{VegaUrl}\"></script>\n"     +
                                                    $"{ind(1)}<script src=\"{VegaLiteUrl}\"></script>\n" +
                                                    $"{ind(1)}<script src=\"{VegaEmbedUrl}\"></script>\n";

        public static readonly Func<Guid, string, string, string, string> LoadContentTemplate = (id,
                                                                                                 title,
                                                                                                 spec,
                                                                                                 scripts) =>
                                                                                                {
                                                                                                    string html = $"{ind(3)}<div id=\"{id}\">\n"                                  +
                                                                                                                  scripts                                                 +
                                                                                                                  $"{ind(4)}<h1>{title}</h1>\n"                           +
                                                                                                                  $"{ind(4)}<div id=\"vis-{id}\"></div>\n"                +
                                                                                                                  $"{ind(4)}<script type=\"text/javascript\">\n"          +
                                                                                                                  $"{ind(4)}{ind(1)}var renderVegaLite = function() {{\n" +
                                                                                                                  //$"{ind(1)}{ind(1)}var renderVegaLite{id.ToString().Replace("-", "")} = function() {{\n" +
                                                                                                                  $"{ind(4)}{ind(1)}{ind(1)}var vlSpec = {spec};\n"            +
                                                                                                                  $"{ind(4)}{ind(1)}{ind(1)}vegaEmbed('#vis-{id}', vlSpec);\n" +
                                                                                                                  $"{ind(4)}{ind(1)}}};"                                       +
                                                                                                                  "\n"                                                         +
                                                                                                                  $"{ind(4)}{ind(1)}renderVegaLite();\n"                       +
                                                                                                                  "\n"                                                         +
                                                                                                                  $"{ind(4)}</script>\n"                                       +
                                                                                                                  $"{ind(3)}</div>\n";

                                                                                                    return html;
                                                                                                };

        public static readonly Func<Guid, string, string, string> HtmlContentTemplate = (id,
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
    }
}