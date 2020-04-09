// ReSharper disable InconsistentNaming

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using VegaLite.Schema;

namespace VegaLite
{
    internal static class HtmlChart
    {
        public static string VegaUrl      = "https://cdn.jsdelivr.net/npm/vega?noext";
        public static string VegaLiteUrl  = "https://cdn.jsdelivr.net/npm/vega-lite?noext";
        public static string VegaEmbedUrl = "https://cdn.jsdelivr.net/npm/vega-embed?noext";
        public static string VegaWebglUrl = "https://cdn.jsdelivr.net/npm/vega-loader-arrow?noext";
        public static string D3ColorUrl   = "https://d3js.org/d3-color.v1.min";

        public static string EChartsUrl = "https://cdn.jsdelivr.net/npm/echarts@4.7.0/dist/echarts.min.js";

        internal static readonly Func<int, string> indent = amount => string.Empty.PadLeft(amount * 4,
                                                                                           '\u0020');

        internal static readonly string ____                         = indent(1);
        internal static readonly string ________                     = indent(2);
        internal static readonly string ____________                 = indent(3);
        internal static readonly string ________________             = indent(4);
        internal static readonly string ____________________         = indent(5);
        internal static readonly string ________________________     = indent(6);
        internal static readonly string ____________________________ = indent(7);

        internal static readonly string OB = "{";
        internal static readonly string CB = "}";

        internal static readonly string OC = "/*";
        internal static readonly string CC = "*/";

        public static readonly string LE = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "\r\n" : "\n";

        //http://localhost:15514/variables/csharp/dataset_b767d0e57e604a76be3ba865eeb45f71

        private static readonly Func<string, string, string, string> HtmlTemplateFunc = (uid,
                                                                                         title,
                                                                                         content) =>
                                                                                        {
                                                                                            string html = $"{________}<div id=\"{uid}\">{LE}"                        +
                                                                                                          $"{____________}<h1>{title}</h1>{LE}"                      +
                                                                                                          $"{____________}<div id=\"vis-{uid}\" class=\"view\">{LE}" +
                                                                                                          $"{____________}<script language=\"javascript\">{LE}"      +
                                                                                                          content                                                    +
                                                                                                          $"{____________}</script>{LE}"                             +
                                                                                                          $"</div>{LE}"                                              +
                                                                                                          $"{________}</div>{LE}";

                                                                                            return html;
                                                                                        };

        public static string ElementContentTemplate(Guid   id,
                                                    string title,
                                                    Chart  chart)
        {
            string uid = id.ToString().Replace("-",
                                               "");

            string content = Scripts.RequireVegaLiteSvg;

            content = content.Replace("_ID_",
                                      uid);

            content = content.Replace("_VEGALITE_SPEC_",
                                      chart.Specification.ToJson());

            content = Scripts.RequireJS + Scripts.RequireVegaLite + content;

            return HtmlTemplateFunc(uid,
                                    title,
                                    content);
        }

        public static string WebglElementContentTemplate(Guid       id,
                                                         string     title,
                                                         WebglChart chart)
        {
            string uid = id.ToString().Replace("-",
                                               "");

            string content = Scripts.RequireVegaLiteWebgl;

            content = content.Replace("_ID_",
                                      uid);

            content = content.Replace("_VEGALITE_SPEC_",
                                      chart.Specification.ToJson());

            content = Scripts.RequireJS + Scripts.RequireVegaLite + content;

            return HtmlTemplateFunc(uid,
                                    title,
                                    content);
        }

        public static string DataElementContentTemplate<T>(Guid     id,
                                                           string   title,
                                                           int      rows,
                                                           int      columns,
                                                           Chart<T> chart)
            where T : IEnumerable
        {
            string uid = id.ToString().Replace("-",
                                               "");

            string content = Scripts.RequireVegaLiteDataBuffered;

            content = content.Replace("_ID_",
                                      uid);

            content = content.Replace("_DATASET_",
                                      chart.DataSetName);

            content = content.Replace("_ROWS_",
                                      $"{rows}");

            content = content.Replace("_COLUMNS_",
                                      $"{columns}");

            content = content.Replace("_VEGALITE_SPEC_",
                                      chart.Specification.ToJson());

            content = Scripts.RequireJS + Scripts.RequireVegaLite + content;

            return HtmlTemplateFunc(uid,
                                    title,
                                    content);
        }

        public static string WebglDataElementContentTemplate<T>(Guid          id,
                                                                string        title,
                                                                int           rows,
                                                                int           columns,
                                                                WebglChart<T> chart)
            where T : IEnumerable
        {
            string uid = id.ToString().Replace("-",
                                               "");

            string content = Scripts.RequireVegaLiteDataBuffered;

            content = content.Replace("_ID_",
                                      uid);

            content = content.Replace("_DATASET_",
                                      chart.DataSetName);

            content = content.Replace("_ROWS_",
                                      $"{rows}");

            content = content.Replace("_COLUMNS_",
                                      $"{columns}");

            content = content.Replace("_VEGALITE_SPEC_",
                                      chart.Specification.ToJson());

            content = Scripts.RequireJS + Scripts.RequireVegaLite + content;

            return HtmlTemplateFunc(uid,
                                    title,
                                    content);
        }

        public static string ArrowElementContentTemplate(Guid   id,
                                                         string title,
                                                         Chart  chart)
        {
            string uid = id.ToString().Replace("-",
                                               "");

            string content = Scripts.RequireVegaLiteWebgl;

            content = content.Replace("_ID_",
                                      uid);

            content = content.Replace("_DATASET_",
                                      chart.DataSetName);

            content = content.Replace("_VEGALITE_SPEC_",
                                      chart.Specification.ToJson());

            content = Scripts.RequireJS + Scripts.RequireVegaLite + content;

            return HtmlTemplateFunc(uid,
                                    title,
                                    content);
        }

        public static string ArrowDataElementContentTemplate<T>(Guid     id,
                                                                string   title,
                                                                int      rows,
                                                                int      columns,
                                                                Chart<T> chart)
            where T : IEnumerable
        {
            string uid = id.ToString().Replace("-",
                                               "");

            string content = Scripts.RequireVegaLiteDataBuffered;

            content = content.Replace("_ID_",
                                      uid);

            content = content.Replace("_DATASET_",
                                      chart.DataSetName);

            content = content.Replace("_ROWS_",
                                      $"{rows}");

            content = content.Replace("_COLUMNS_",
                                      $"{columns}");

            content = content.Replace("_VEGALITE_SPEC_",
                                      chart.Specification.ToJson());

            content = Scripts.RequireJS + Scripts.RequireVegaLite + content;

            return HtmlTemplateFunc(uid,
                                    title,
                                    content);
        }

        public static string HtmlTemplate(string content)
        {
            string html = $"<!DOCTYPE html>{LE}"                      +
                          $"<html>{LE}"                               +
                          $"{____}<head>{LE}"                         +
                          $"{________}<meta charset=\"utf-8\" />{LE}" +
                          $"{____}</head>{LE}"                        +
                          $"{____}<body>{LE}"                         +
                          $"{content}{LE}"                            +
                          $"{____}</body>{LE}"                        +
                          $"</html>{LE}";

            return html;
        }

        //view.change('table', vega.changeset()
        //                         .remove(view.data('table')[0])
        //                         .insert(generate(1)))
        //                         .runAsync();

        //view.data('table', generate(1))
    }
}
