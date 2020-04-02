
function VegaLiteScript_ID_() {
    const vlSpec_ID_ = _VEGALITE_SPEC_;

    RequireVegaLite("_ID_", vlSpec_ID_, "webgl");
}

window.addEventListener("vega-lite-loaded", function(e) {
    VegaLiteScript_ID_();
}, false);
