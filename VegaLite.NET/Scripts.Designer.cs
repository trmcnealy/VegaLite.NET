﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VegaLite {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Scripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Scripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VegaLite.Scripts", typeof(Scripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///if ((typeof (window.requirejs) !== typeof (Function)) ||
        ///    (typeof (window.requirejs.config) !== typeof (Function))) {
        ///
        ///    var script = document.createElement(&quot;script&quot;);
        ///    script.setAttribute(&quot;type&quot;, &quot;text/javascript&quot;);
        ///    script.setAttribute(&quot;src&quot;, &quot;https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js&quot;);
        ///    script.onload = function() {
        ///        window.RequireVegaLite();
        ///    };
        ///    document.head.appendChild(script);
        ///} else {
        ///    window.RequireVegaLite();
        ///}
        ///.
        /// </summary>
        internal static string RequireJS {
            get {
                return ResourceManager.GetString("RequireJS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///function RequireVegaLite() {
        ///    if ((typeof (window.RequireVegaLiteSvg) !== typeof (Function)) &amp;&amp;
        ///        (typeof (window.RequireVegaLiteWebgl) !== typeof (Function))) {
        ///
        ///        var vegaLiteScript = document.createElement(&quot;script&quot;);
        ///        vegaLiteScript.setAttribute(&quot;type&quot;, &quot;text/javascript&quot;);
        ///        vegaLiteScript.setAttribute(&quot;src&quot;, &quot;https://trmcnealy.github.io/scripts/VegaLiteScript.js&quot;);
        ///        vegaLiteScript.onload = function () {
        ///            window.dispatchEvent(window.VegaLiteLoaded); [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RequireVegaLite {
            get {
                return ResourceManager.GetString("RequireVegaLite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///function VegaLiteScript_ID_() {
        ///    const vlSpec_ID_ = _VEGALITE_SPEC_;
        ///
        ///    RequireVegaLiteData(&quot;_ID_&quot;, vlSpec_ID_, &quot;svg&quot;, &quot;_DATASET_&quot;);
        ///}
        ///
        ///window.addEventListener(&quot;vega-lite-loaded&quot;, function (e) {
        ///    VegaLiteScript_ID_();
        ///}, false);
        ///.
        /// </summary>
        internal static string RequireVegaLiteData {
            get {
                return ResourceManager.GetString("RequireVegaLiteData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///function VegaLiteScript_ID_() {
        ///    const vlSpec_ID_ = _VEGALITE_SPEC_;
        ///
        ///    RequireVegaLiteDataBuffered(&quot;_ID_&quot;, vlSpec_ID_, &quot;_DATASET_&quot;, _ROWS_, _COLUMNS_);
        ///}
        ///
        ///window.addEventListener(&quot;vega-lite-loaded&quot;, function (e) {
        ///    VegaLiteScript_ID_();
        ///}, false);
        ///.
        /// </summary>
        internal static string RequireVegaLiteDataBuffered {
            get {
                return ResourceManager.GetString("RequireVegaLiteDataBuffered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///function VegaLiteScript_ID_() {
        ///    const vlSpec_ID_ = _VEGALITE_SPEC_;
        ///
        ///    RequireVegaLite(&quot;_ID_&quot;, vlSpec_ID_, &quot;svg&quot;);
        ///}
        ///
        ///window.addEventListener(&quot;vega-lite-loaded&quot;, function(e) {
        ///    VegaLiteScript_ID_();
        ///}, false);.
        /// </summary>
        internal static string RequireVegaLiteSvg {
            get {
                return ResourceManager.GetString("RequireVegaLiteSvg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///function VegaLiteScript_ID_() {
        ///    const vlSpec_ID_ = _VEGALITE_SPEC_;
        ///
        ///    RequireVegaLite(&quot;_ID_&quot;, vlSpec_ID_, &quot;webgl&quot;);
        ///}
        ///
        ///window.addEventListener(&quot;vega-lite-loaded&quot;, function(e) {
        ///    VegaLiteScript_ID_();
        ///}, false);.
        /// </summary>
        internal static string RequireVegaLiteWebgl {
            get {
                return ResourceManager.GetString("RequireVegaLiteWebgl", resourceCulture);
            }
        }
    }
}
