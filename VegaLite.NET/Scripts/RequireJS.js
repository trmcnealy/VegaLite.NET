
if ((typeof (window.requirejs) !== typeof (Function)) ||
    (typeof (window.requirejs.config) !== typeof (Function))) {

    var script = document.createElement("script");
    script.setAttribute("type", "text/javascript");
    script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
    script.onload = function() {
        window.RequireVegaLite();
    };
    document.head.appendChild(script);
} else {
    window.RequireVegaLite();
}
