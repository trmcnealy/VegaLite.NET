
function VegaLiteScript_ID_() {
    const vlSpec_ID_ = _VEGALITE_SPEC_;

    RequireVegaLiteData("_ID_", vlSpec_ID_, "_RENDER_", "_DATASET_");
}

window.addEventListener("vega-lite-loaded", function (e) {
    VegaLiteScript_ID_();
}, false);
