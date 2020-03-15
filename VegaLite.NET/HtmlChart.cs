// ReSharper disable InconsistentNaming

using System;
using System.Runtime.InteropServices;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VegaLite
{
    internal static class HtmlChart
    {
        public delegate string RequireJavaScriptDelegate(string         base_indent,
                                                         params Chart[] charts);

        public static string VegaUrl      = "https://cdn.jsdelivr.net/npm/vega?noext";
        public static string VegaLiteUrl  = "https://cdn.jsdelivr.net/npm/vega-lite?noext";
        public static string VegaEmbedUrl = "https://cdn.jsdelivr.net/npm/vega-embed?noext";
        public static string VegaWebglUrl = "https://unpkg.com/vega-webgl-renderer/build/vega-webgl-renderer";
        public static string D3ColorUrl   = "https://d3js.org/d3-color.v1.min";

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

        public static readonly string LE = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "\r\n" : "\n";

        public static readonly RequireJavaScriptDelegate RequireJavaScriptFunction = (base_indent,
                                                                                      charts) =>
                                                                                     {
                                                                                         string script =
                                                                                             $"{base_indent}<script language=\"javascript\">{LE}"                                                                      +
                                                                                             $"{base_indent}{____}var requireVega = function() {OB}{LE}"                                                               +
                                                                                             $"{base_indent}{________}var requireVegaScriptsConfig = requirejs.config({OB}context:\"vega\",{LE}"                       +
                                                                                             $"{base_indent}{________}                                                  paths:{OB}\"vega\":\"{VegaUrl}\",{LE}"         +
                                                                                             $"{base_indent}{________}                                                         \"vega-lite\":\"{VegaLiteUrl}\",{LE}"   +
                                                                                             $"{base_indent}{________}                                                         \"vega-embed\":\"{VegaEmbedUrl}\",{LE}" +
                                                                                             $"{base_indent}{________}                                                         \"vega-webgl\":\"{VegaWebglUrl}\",{LE}" +
                                                                                             $"{base_indent}{________}                                                         \"d3-color\":\"{D3ColorUrl}\"{CB},{LE}" +
                                                                                             $"{base_indent}{________}                                                  map: {OB}{LE}"                                 +
                                                                                             $"{base_indent}{________}                                                  '*': {OB} 'vega-scenegraph': 'vega' {CB}{LE}"  +
                                                                                             $"{base_indent}{________}                                                      {CB}{LE}"                                  +
                                                                                             $"{base_indent}{________}                                                  {CB});{LE}"                                    +
                                                                                             $"{base_indent}{________}requireVegaScriptsConfig([\"d3-color\", \"vega\", \"vega-lite\", \"vega-embed\", \"vega-webgl\"], function(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) {OB}{LE}";

                                                                                         foreach(Chart chart in charts)
                                                                                         {
                                                                                             script +=
                                                                                                 $"{base_indent}{____________}renderVegaLite{chart.Id.ToString().Replace("-", "")}(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl).then(function(result) {OB}{LE}" +
                                                                                                 $"{base_indent}{________________}interactive.csharp.getVariable(\"{chart.Specification.Data.Name}\").then(function(csharp_variable) {OB}{LE}"                    +
                                                                                                 $"{base_indent}{________________}    result.view.data(\"{chart.Specification.Data.Name}\", csharp_variable);{LE}"                                                +
                                                                                                 $"{base_indent}{________________}{CB});{LE}"                                                                                                                     +
                                                                                                 $"{base_indent}{____________}{CB});{LE}";
                                                                                         }

                                                                                         string createAndLoad =
                                                                                             $"{base_indent}{____________}if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {OB}{LE}"         +
                                                                                             $"{base_indent}{________________}var script = document.createElement(\"script\"); {LE}"                                                          +
                                                                                             $"{base_indent}{________________}script.setAttribute(\"type\", \"text/javascript\");{LE}"                                                        +
                                                                                             $"{base_indent}{________________}script.setAttribute(\"src\", \"https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js\"); {LE}" +
                                                                                             $"{base_indent}{________________}script.onload = function(){OB}{LE}"                                                                             +
                                                                                             $"{base_indent}{____________________}requireVega();{LE}"                                                                                         +
                                                                                             $"{base_indent}{________________}{CB};{LE}"                                                                                                      +
                                                                                             $"{base_indent}{________________}document.getElementsByTagName(\"head\")[0].appendChild(script); {LE}"                                           +
                                                                                             $"{base_indent}{____________}{CB}else{OB}{LE}"                                                                                                   +
                                                                                             $"{base_indent}{________________}requireVega();{LE}"                                                                                             +
                                                                                             $"{base_indent}{____________}{CB}{LE}";

                                                                                         script += $"{base_indent}{________}{CB});{LE}"                  +
                                                                                                   $"{base_indent}{____}{CB};{LE}"                       +
                                                                                                   $"{base_indent}</script>{LE}"                         +
                                                                                                   $"{base_indent}<script>{LE}"                          +
                                                                                                   $"{base_indent}{____}try {OB}{LE}"                    +
                                                                                                   $"{base_indent}{________}(async function () {OB}{LE}" +
                                                                                                   createAndLoad                                         +
                                                                                                   $"{base_indent}{________}{CB})();{LE}"                +
                                                                                                   $"{base_indent}{____}{CB} catch(err) {OB}{LE}"        +
                                                                                                   $"{base_indent}{________}(function () {OB}{LE}"       +
                                                                                                   createAndLoad                                         +
                                                                                                   $"{base_indent}{________}{CB})();{LE}"                +
                                                                                                   $"{base_indent}{____}{CB}{LE}"                        +
                                                                                                   $"{base_indent}</script>{LE}";

                                                                                         return script;
                                                                                     };

        public static readonly Func<Guid, string, string, string> ElementContentTemplate = (id,
                                                                                            title,
                                                                                            spec) =>
                                                                                           {
                                                                                               string html = $"{____________}<div id=\"{id}\">{LE}"                              +
                                                                                                             $"{________________}<h1>{title}</h1>{LE}"                           +
                                                                                                             $"{________________}<div id=\"vis-{id}\" class=\"view\"></div>{LE}" +
                                                                                                             $"{________________}<script language=\"javascript\">{LE}"           +
                                                                                                             //$"{____________________}var renderVegaLite = function(vegaEmbed) {{{LE}" +
                                                                                                             $"{____________________}var renderVegaLite{id.ToString().Replace("-", "")} = function(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) {OB}{LE}" +
                                                                                                             //$"{________}var renderVegaLite{id.ToString().Replace("-", "")} = function() {{{LE}" +
                                                                                                             $"{________________________}var vlSpec = {spec};{LE}"                        +
                                                                                                             $"{________________________}var opt = {OB}{LE}"                              +
                                                                                                             $"{____________________________}renderer: 'webgl',{LE}"                      +
                                                                                                             $"{____________________________}logLevel: vegaEmbed.Warn{LE}"                +
                                                                                                             $"{________________________}{CB};{LE}"                                       +
                                                                                                             $"{________________________}return vegaEmbed('#vis-{id}', vlSpec, opt);{LE}" +
                                                                                                             $"{____________________}{CB};{LE}"                                           +
                                                                                                             $"{LE}"                                                                      +
                                                                                                             $"{________________}</script>{LE}"                                           +
                                                                                                             $"{____________}</div>{LE}";

                                                                                               return html;
                                                                                           };

        public static readonly Func<Chart, string, string> HtmlTemplateSingleId = (chart,
                                                                                   content) =>
                                                                                  {
                                                                                      string html = $"<!DOCTYPE html>{LE}"                      +
                                                                                                    $"<html>{LE}"                               +
                                                                                                    $"{____}<head>{LE}"                         +
                                                                                                    $"{________}<meta charset=\"utf-8\" />{LE}" +
                                                                                                    $"{____}</head>{LE}"                        +
                                                                                                    $"{____}<body>{LE}"                         +
                                                                                                    RequireJavaScriptFunction(____________,
                                                                                                                              chart) +
                                                                                                    $"{content}{LE}"                 +
                                                                                                    $"{____}</body>{LE}"             +
                                                                                                    $"</html>{LE}";

                                                                                      return html;
                                                                                  };

        //view.change('table', vega.changeset()
        //                         .remove(view.data('table')[0])
        //                         .insert(generate(1)))
        //                         .runAsync();

        //view.data('table', generate(1))
    }

    //public struct VegaViewData
    //{
    //    [JsonProperty("API",
    //                  NamingStrategyType = typeof(DefaultNamingStrategy))]
    //    public string API { get; set; }

    //    [JsonProperty("Day",
    //                  NamingStrategyType = typeof(DefaultNamingStrategy))]
    //    public double Day { get; set; }

    //    [JsonProperty("Type",
    //                  NamingStrategyType = typeof(DefaultNamingStrategy))]
    //    public string Type { get; set; }

    //    [JsonProperty("Rate",
    //                  NamingStrategyType = typeof(DefaultNamingStrategy))]
    //    public double Rate { get; set; }

    //    public VegaViewData(string api,
    //                        double day,
    //                        string type,
    //                        double rate)
    //    {
    //        API  = api;
    //        Day  = day;
    //        Type = type;
    //        Rate = rate;
    //    }
    //}

//VegaViewData[] string_map = new List<VegaViewData>()
//{
//    new VegaViewData("##-###-#####",1.0,"Actual",280.51724137931035)
//}.ToArray();
}

//public static readonly string LoadScriptFunction = $"{________}var loadScript = function(url, uid) {{{LE}"               +
//                                                   $"{____________}var script = document.getElementById(uid);{LE}"       +
//                                                   $"{____________}if(script == null) {{{LE}"                            +
//                                                   $"{________________}script = document.createElement(\"script\");{LE}" +
//                                                   //$"{________}{________}script.setAttribute(\"id\", uid);{LE}"                               +
//                                                   $"{________________}script.setAttribute(\"type\", \"text/javascript\");{LE}"             +
//                                                   $"{________________}script.setAttribute(\"src\", url);{LE}"                              +
//                                                   $"{________________}document.getElementsByTagName(\"head\")[0].appendChild(script);{LE}" +
//                                                   $"{____________}{CB}{LE}"                                                                +
//                                                   $"{____________}return script;{LE}"                                                      +
//                                                   $"{________}{CB};{LE}";

//public static readonly Func<Guid, string, string, string> LoadContentTemplate = (id,
//                                                                                 title,
//                                                                                 spec) =>
//                                                                                {
//                                                                                    string html = $"{____________}<div id=\"{id}\">{LE}" +
//                                                                                                  RequireJavaScriptFunction(________________,
//                                                                                                                            id)                                       +
//                                                                                                  $"{________________}<h1>{title}</h1>{LE}"                           +
//                                                                                                  $"{________________}<div id=\"vis-{id}\" class=\"view\"></div>{LE}" +
//                                                                                                  $"{________________}<script type=\"text/javascript\">{LE}"          +
//                                                                                                  //$"{____________________}var renderVegaLite = function(vegaEmbed) {{{LE}" +
//                                                                                                  $"{____________________}var renderVegaLite{id.ToString().Replace("-", "")} = function(vegaEmbed) {{{LE}" +
//                                                                                                  //$"{________}var renderVegaLite{id.ToString().Replace("-", "")} = function() {{{LE}" +
//                                                                                                  $"{________________________}var vlSpec = {spec};{LE}"                 +
//                                                                                                  $"{________________________}var opt = {OB}"                           +
//                                                                                                  $"{____________________________}renderer: 'svg',"                     +
//                                                                                                  $"{____________________________}logLevel: vegaEmbed.Warn"             +
//                                                                                                  $"{________________________}{CB}"                                     +
//                                                                                                  $"{________________________}vegaEmbed('#vis-{id}', vlSpec, opt);{LE}" +
//                                                                                                  $"{____________________}{CB};"                                        +
//                                                                                                  $"{LE}"                                                               +
//                                                                                                  $"{________________}</script>{LE}"                                    +
//                                                                                                  $"{____________}</div>{LE}";

//                                                                                    return html;
//                                                                                };

//public static readonly Func<Guid, string, string, string> HtmlContentTemplate = (id,
//                                                                                 title,
//                                                                                 spec) =>
//                                                                                {
//                                                                                    string html = $"<!DOCTYPE html>{LE}"                                    +
//                                                                                                  $"<html>{LE}"                                             +
//                                                                                                  $"{____}<head>{LE}"                                       +
//                                                                                                  $"{________}<title>Vega-Lite Chart</title>{LE}"           +
//                                                                                                  $"{________}<meta charset=\"utf-8\" />{LE}"               +
//                                                                                                  $"{________}<script src=\"{VegaUrl}\"></script>{LE}"      +
//                                                                                                  $"{________}<script src=\"{VegaLiteUrl}\"></script>{LE}"  +
//                                                                                                  $"{________}<script src=\"{VegaEmbedUrl}\"></script>{LE}" +
//                                                                                                  $"{________}<style media=\"screen\">{LE}"                 +
//                                                                                                  $"      .vega-actions a {{{LE}"                           +
//                                                                                                  $"        margin-right: 5px;{LE}"                         +
//                                                                                                  $"      }}{LE}"                                           +
//                                                                                                  $"{________}</style>{LE}"                                 +
//                                                                                                  $"{____}</head>{LE}"                                      +
//                                                                                                  $"{____}<body>{LE}"                                       +
//                                                                                                  $"{________}<h1>{title}</h1>{LE}"                         +
//                                                                                                  $"{________}<div id=\"vis{id}\"></div>{LE}"               +
//                                                                                                  $"{________}<script>{LE}"                                 +
//                                                                                                  $"      var vlSpec = {spec};{LE}"                         +
//                                                                                                  $"      vegaEmbed('#vis{id}', vlSpec);{LE}"               +
//                                                                                                  $"{________}</script>{LE}"                                +
//                                                                                                  $"{____}</body>{LE}"                                      +
//                                                                                                  $"</html>{LE}";

//                                                                                    return html;
//                                                                                };

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
