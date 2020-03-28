
function RequireVegaLite() {
    if ((typeof (window.RequireVegaLiteSvg) !== typeof (Function)) &&
        (typeof (window.RequireVegaLiteWebgl) !== typeof (Function))) {

        var vegaLiteScript = document.createElement("script");
        vegaLiteScript.setAttribute("type", "text/javascript");
        vegaLiteScript.setAttribute("src", "https://trmcnealy.github.io/scripts/VegaLiteScript.js");
        vegaLiteScript.onload = function () {
            window.dispatchEvent(window.VegaLiteLoaded);
        };
        document.head.appendChild(vegaLiteScript);
    }
    else {
        window.dispatchEvent(window.VegaLiteLoaded);
    }
}
