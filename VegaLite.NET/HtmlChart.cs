// ReSharper disable InconsistentNaming

using System;
using System.Runtime.InteropServices;

namespace VegaLite
{
    internal static class HtmlChart
    {
        public delegate string RequireJavaScriptDelegate(string        base_indent,
                                                         params Guid[] ids);

        public static string VegaUrl      = "https://cdn.jsdelivr.net/npm/vega?noext";
        public static string VegaLiteUrl  = "https://cdn.jsdelivr.net/npm/vega-lite?noext";
        public static string VegaEmbedUrl = "https://cdn.jsdelivr.net/npm/vega-embed?noext";

        internal static readonly Func<int, string> indent = amount => string.Empty.PadLeft(amount * 4,
                                                                                           '\u0020');

        internal static readonly string ____                     = indent(1);
        internal static readonly string ________                 = indent(2);
        internal static readonly string ____________             = indent(3);
        internal static readonly string ________________         = indent(4);
        internal static readonly string ____________________     = indent(5);
        internal static readonly string ________________________ = indent(6);

        internal static readonly string OB = "{";
        internal static readonly string CB = "}";

        public static readonly string LE = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "\r\n" : "\n";

        public static readonly RequireJavaScriptDelegate RequireJavaScriptFunction = (base_indent,
                                                                                      ids) =>
                                                                                     {
                                                                                         string script =
                                                                                             $"{base_indent}<script type=\"text/javascript\">{LE}"                                                                        +
                                                                                             $"{base_indent}{____}var requireVega = function() {OB}{LE}"                                                                  +
                                                                                             $"{base_indent}{________}var requireVegaScriptsConfig = requirejs.config({OB}context:\"vega\",{LE}"                          +
                                                                                             $"{base_indent}{________}                                                  paths:{OB}\"vega\":\"{VegaUrl}\",{LE}"            +
                                                                                             $"{base_indent}{________}                                                         \"vega-lite\":\"{VegaLiteUrl}\",{LE}"      +
                                                                                             $"{base_indent}{________}                                                         \"vega-embed\":\"{VegaEmbedUrl}\"{CB}{LE}" +
                                                                                             $"{base_indent}{________}                                                {CB});{LE}"                                         +
                                                                                             $"{base_indent}{________}requireVegaScriptsConfig([\"vega-embed\"], function(vegaEmbed) {OB}{LE}";

                                                                                         foreach(Guid id in ids)
                                                                                         {
                                                                                             script +=
                                                                                                 $"{base_indent}{____________}renderVegaLite{id.ToString().Replace("-", "")}(vegaEmbed);{LE}";
                                                                                         }

                                                                                         script +=
                                                                                             $"{base_indent}{________}{CB});{LE}"                                                                                                     +
                                                                                             $"{base_indent}{____}{CB};{LE}"                                                                                                          +
                                                                                             $"{base_indent}{____}{LE}"                                                                                                               +
                                                                                             $"{base_indent}{____}if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {OB} {LE}"        +
                                                                                             $"{base_indent}{________}var script = document.createElement(\"script\"); {LE}"                                                          +
                                                                                             $"{base_indent}{________}script.setAttribute(\"type\", \"text/javascript\");{LE}"                                                        +
                                                                                             $"{base_indent}{________}script.setAttribute(\"src\", \"https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js\"); {LE}" +
                                                                                             $"{base_indent}{________}script.onload = function(){OB}{LE}"                                                                             +
                                                                                             $"{base_indent}{____________}requireVega();{LE}"                                                                                         +
                                                                                             $"{base_indent}{________}{CB};{LE}"                                                                                                      +
                                                                                             $"{base_indent}{________}document.getElementsByTagName(\"head\")[0].appendChild(script); {LE}"                                           +
                                                                                             $"{base_indent}{____}{CB}else{OB}{LE}"                                                                                                   +
                                                                                             $"{base_indent}{________}requireVega();{LE}"                                                                                             +
                                                                                             $"{base_indent}{____}{CB}"                                                                                                               +
                                                                                             $"{base_indent}</script>";

                                                                                         return script;
                                                                                     };

        public static readonly string LoadScriptFunction = $"{________}var loadScript = function(url, uid) {{{LE}"               +
                                                           $"{____________}var script = document.getElementById(uid);{LE}"       +
                                                           $"{____________}if(script == null) {{{LE}"                            +
                                                           $"{________________}script = document.createElement(\"script\");{LE}" +
                                                           //$"{________}{________}script.setAttribute(\"id\", uid);{LE}"                               +
                                                           $"{________________}script.setAttribute(\"type\", \"text/javascript\");{LE}"             +
                                                           $"{________________}script.setAttribute(\"src\", url);{LE}"                              +
                                                           $"{________________}document.getElementsByTagName(\"head\")[0].appendChild(script);{LE}" +
                                                           $"{____________}{CB}{LE}"                                                                +
                                                           $"{____________}return script;{LE}"                                                      +
                                                           $"{________}{CB};{LE}";

        public static readonly Func<Guid, string, string, string> LoadContentTemplate = (id,
                                                                                         title,
                                                                                         spec) =>
                                                                                        {
                                                                                            string html = $"{____________}<div id=\"{id}\">{LE}" +
                                                                                                          RequireJavaScriptFunction(________________,
                                                                                                                                    id)                              +
                                                                                                          $"{________________}<h1>{title}</h1>{LE}"                  +
                                                                                                          $"{________________}<div id=\"vis-{id}\"></div>{LE}"       +
                                                                                                          $"{________________}<script type=\"text/javascript\">{LE}" +
                                                                                                          //$"{____________________}var renderVegaLite = function(vegaEmbed) {{{LE}" +
                                                                                                          $"{____________________}var renderVegaLite{id.ToString().Replace("-", "")} = function(vegaEmbed) {{{LE}" +
                                                                                                          //$"{________}var renderVegaLite{id.ToString().Replace("-", "")} = function() {{{LE}" +
                                                                                                          $"{________________________}var vlSpec = {spec};{LE}"            +
                                                                                                          $"{________________________}vegaEmbed('#vis-{id}', vlSpec);{LE}" +
                                                                                                          $"{____________________}{CB};"                                   +
                                                                                                          $"{LE}"                                                          +
                                                                                                          $"{________________}</script>{LE}"                               +
                                                                                                          $"{____________}</div>{LE}";

                                                                                            return html;
                                                                                        };

        public static readonly Func<Guid, string, string, string> ElementContentTemplate = (id,
                                                                                            title,
                                                                                            spec) =>
                                                                                           {
                                                                                               string html = $"{____________}<div id=\"{id}\">{LE}"                     +
                                                                                                             $"{________________}<h1>{title}</h1>{LE}"                  +
                                                                                                             $"{________________}<div id=\"vis-{id}\"></div>{LE}"       +
                                                                                                             $"{________________}<script type=\"text/javascript\">{LE}" +
                                                                                                             //$"{____________________}var renderVegaLite = function(vegaEmbed) {{{LE}" +
                                                                                                             $"{____________________}var renderVegaLite{id.ToString().Replace("-", "")} = function(vegaEmbed) {{{LE}" +
                                                                                                             //$"{________}var renderVegaLite{id.ToString().Replace("-", "")} = function() {{{LE}" +
                                                                                                             $"{________________________}var vlSpec = {spec};{LE}"            +
                                                                                                             $"{________________________}vegaEmbed('#vis-{id}', vlSpec);{LE}" +
                                                                                                             $"{____________________}{CB};"                                   +
                                                                                                             $"{LE}"                                                          +
                                                                                                             $"{________________}</script>{LE}"                               +
                                                                                                             $"{____________}</div>{LE}";

                                                                                               return html;
                                                                                           };

        public static readonly Func<Guid, string, string> HtmlTemplateSingleId = (id,content) =>
                                                                                 {
                                                                                     string html = $"<!DOCTYPE html>{LE}"                      +
                                                                                                   $"<html>{LE}"                               +
                                                                                                   $"{____}<head>{LE}"                         +
                                                                                                   $"{________}<meta charset=\"utf-8\" />{LE}" +
                                                                                                   $"{____}</head>{LE}"                        +
                                                                                                   $"{____}<body>{LE}"                         +
                                                                                                   RequireJavaScriptFunction(________________,
                                                                                                                             id) +
                                                                                                   $"{content}{LE}"                            +
                                                                                                   $"{____}</body>{LE}"                        +
                                                                                                   $"</html>{LE}";

                                                                                     return html;
                                                                                 };

        public static readonly Func<Guid, string, string, string> HtmlContentTemplate = (id,
                                                                                         title,
                                                                                         spec) =>
                                                                                        {
                                                                                            string html = $"<!DOCTYPE html>{LE}"                                    +
                                                                                                          $"<html>{LE}"                                             +
                                                                                                          $"{____}<head>{LE}"                                       +
                                                                                                          $"{________}<title>Vega-Lite Chart</title>{LE}"           +
                                                                                                          $"{________}<meta charset=\"utf-8\" />{LE}"               +
                                                                                                          $"{________}<script src=\"{VegaUrl}\"></script>{LE}"      +
                                                                                                          $"{________}<script src=\"{VegaLiteUrl}\"></script>{LE}"  +
                                                                                                          $"{________}<script src=\"{VegaEmbedUrl}\"></script>{LE}" +
                                                                                                          $"{________}<style media=\"screen\">{LE}"                 +
                                                                                                          $"      .vega-actions a {{{LE}"                           +
                                                                                                          $"        margin-right: 5px;{LE}"                         +
                                                                                                          $"      }}{LE}"                                           +
                                                                                                          $"{________}</style>{LE}"                                 +
                                                                                                          $"{____}</head>{LE}"                                      +
                                                                                                          $"{____}<body>{LE}"                                       +
                                                                                                          $"{________}<h1>{title}</h1>{LE}"                         +
                                                                                                          $"{________}<div id=\"vis{id}\"></div>{LE}"               +
                                                                                                          $"{________}<script>{LE}"                                 +
                                                                                                          $"      var vlSpec = {spec};{LE}"                         +
                                                                                                          $"      vegaEmbed('#vis{id}', vlSpec);{LE}"               +
                                                                                                          $"{________}</script>{LE}"                                +
                                                                                                          $"{____}</body>{LE}"                                      +
                                                                                                          $"</html>{LE}";

                                                                                            return html;
                                                                                        };
    }
}

// public static readonly string SetPageEncoding = $"{____}<script type=\"text/javascript\">{LE}"                        +
//                                                 $"{________}(function() {{{LE}"                                           +
//                                                 $"{____________}script = document.createElement(\"meta\");{LE}"               +
//                                                 $"{____________}script.setAttribute(\"charset\", \"utf-8\");{LE}"             +
//                                                 $"{____________}var header = document.getElementsByTagName(\"head\")[0];{LE}" +
//                                                 $"{____________}header.insertBefore(script, header.firstChild);{LE}"          +
//                                                 $"{________}{CB})();{LE}"                                                   +
//                                                 LoadScriptFunction                                                    +
//                                                 $"{____}</script>{LE}";

//public static readonly string SetPageEncoding = $"{____}<script type=\"text/javascript\">{LE}"                        +
//                                                LoadScriptFunction                                                    +
//                                                $"{________}(function() {{{LE}"                                                             +
//                                                $"{____________}var vegaScript = loadScript(\"{VegaUrl}\", \"VegaScript\");{LE}"                +
//                                                $"{____________}var vegaliteScript = loadScript(\"{VegaLiteUrl}\", \"VegaLiteScript\");{LE}"    +
//                                                $"{____________}var vegaembedScript = loadScript(\"{VegaEmbedUrl}\", \"VegaEmbedScript\");{LE}" +
//                                                $"{________}{CB})();{LE}"+
//                                                $"{____}</script>{LE}";

//public static readonly Func<Guid, string> LoadScriptTemplate = (id) => LoadScriptFunction +
//                                                                       $"{________}{LE}"  +
//                                                                       //$"{________}(function() {{{LE}"                                                             +
//                                                                       $"{____________}var vegaScript = loadScript(\"{VegaUrl}\", \"VegaScript\");{LE}"                +
//                                                                       $"{____________}var vegaliteScript = loadScript(\"{VegaLiteUrl}\", \"VegaLiteScript\");{LE}"    +
//                                                                       $"{____________}var vegaembedScript = loadScript(\"{VegaEmbedUrl}\", \"VegaEmbedScript\");{LE}" +
//                                                                       $"{____________}{LE}"                                                                           +
//                                                                       $"{____________}vegaembedScript.onload = function(){{{LE}"                                      +
//                                                                       $"{________________}renderVegaLite();{LE}"                                                      +
//                                                                       $"{____________}{CB};{LE}";

//public static readonly string ScriptNodes = $"{____}<script src=\"{VegaUrl}\"></script>{LE}"     +
//                                            $"{____}<script src=\"{VegaLiteUrl}\"></script>{LE}" +
//                                            $"{____}<script src=\"{VegaEmbedUrl}\"></script>{LE}";