
function VegaLiteScript_ID_() {
    const vlSpec_ID_ = _VEGALITE_SPEC_;

    RequireVegaLiteDataBuffered("_ID_", vlSpec_ID_, "_DATASET_", _ROWS_, _COLUMNS_);
}

window.addEventListener("vega-lite-loaded", function (e) {
    VegaLiteScript_ID_();
}, false);
