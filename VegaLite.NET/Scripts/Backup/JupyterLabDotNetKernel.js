//if (typeof (Storage) !== "undefined") {
//    //localStorage.setItem("vega_datasets", "20d83c0b22924853972b0dde79cf0b98");
//} else {
//    console.log("Sorry, your browser does not support Web Storage...");
//}

"use strict";

if ((typeof (VegaLiteScript) !== typeof (Function))) {
    VegaLiteScript = (iD, variableName, vegalite_spec, dataDims) => {

        let vega_require = requirejs.config({
            context: "vega",
            paths: {
                "d3-color": "https://d3js.org/d3-color.v1.min",
                "vega": "https://cdn.jsdelivr.net/npm/vega?noext",
                "vega-lite": "https://cdn.jsdelivr.net/npm/vega-lite?noext",
                "vega-embed": "https://cdn.jsdelivr.net/npm/vega-embed?noext",
                "vega-webgl": "https://unpkg.com/vega-webgl-renderer/build/vega-webgl-renderer"
            },
            map: {
                '*': { 'vega-scenegraph': "vega" }
            }
        });

        let create2dArray = function(rows, columns) {
            return [...Array(rows).keys()].map(i => new Float32Array(columns));
        };

        let copyDataToBuffer = function(id, csharpVariable) {

            const rows = dataDims.rows;
            const columns = dataDims.columns;

            if (rows === 0 || columns === 0) {
                return csharpVariable;
            }

            const vis_element = document.getElementById(`vis-${id}`);
            const canvas = vis_element.firstElementChild;
            const gl = canvas.getContext("webgl");

            const data = create2dArray(rows, columns);
            const buffers = new Array(rows);

            for (var i = 0; i < csharpVariable.length; ++i) {

                const obj = csharpVariable[i];

                var col_index = 0;
                for (const key in obj) {
                    data[i][col_index++] = obj[key];
                }

                buffers[i] = gl.createBuffer();
                gl.bindBuffer(gl.ARRAY_BUFFER, buffers[i]);
                gl.bufferData(gl.ARRAY_BUFFER, data[i], gl.STATIC_DRAW);
            }

            console.log("gl Buffer Enabled.");

            notebookScript[id].buffer = data;

            return data;
        };

        let updateViewDataId = function(view, id, csharpVariable) {
            try {
                const data = copyDataToBuffer(id, csharpVariable);
                view.data(variableName, /*data*/csharpVariable);
            } catch (err) {
                console.log(err);
            }
        };

        let renderVegaLite = function(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) {

            const vlSpec = vegalite_spec;

            //const opt = {
            //    renderer: "webgl",
            //    logLevel: vegaEmbed.Info
            //};

            const vgSpec = vegaLite.compile(vlSpec).spec;

            var view = new vega.View(vega.parse(vgSpec)).initialize("#vis-" + `${iD}`)
                                .renderer('webgl')
                                .run();

            return vegaEmbed("#vis-" + `${iD}`, vlSpec, opt);
        };

        vega_require(["d3-color", "vega", "vega-lite", "vega-embed", "vega-webgl"],
            function(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) {

                interactive.csharp.getVariable(variableName).then(function(csharpVariable) {

                    renderVegaLite(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl).then(function(result) {

                        //vega.sceneFromJSON(csharpVariable);
                        updateViewDataId(result.view, iD, csharpVariable);

                    });

                });
            });
    };

    function runVegaLite(id, dataName, rows, columns, vegalite_spec) {

        class DataDim {
            constructor(rows, columns) {
                this.rows = rows;
                this.columns = columns;
            }
        }

        const dataDims = new DataDim(rows, columns);
        const spec = vegalite_spec;

        VegaLiteScript(id, dataName, spec, dataDims);
    }
};

var VegaLiteScript;

!function(global) {

    if ((typeof (global.requirejs) !== typeof (Function)) ||
        (typeof (global.requirejs.config) !== typeof (Function))) {
        var script = document.createElement("script");
        script.setAttribute("type", "text/javascript");
        script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
        document.getElementsByTagName("head")[0].appendChild(script);
    }

    let vega_require = global.requirejs.config({
        context: "vega",
        paths: {
            "d3-color": "https://d3js.org/d3-color.v1.min",
            "vega": "https://cdn.jsdelivr.net/npm/vega?noext",
            "vega-lite": "https://cdn.jsdelivr.net/npm/vega-lite?noext",
            "vega-embed": "https://cdn.jsdelivr.net/npm/vega-embed?noext",
            "vega-webgl": "https://unpkg.com/vega-webgl-renderer/build/vega-webgl-renderer"
        },
        map: {
            '*': { 'vega-scenegraph': "vega" }
        }
    });

    function create2dArray(rows, columns) {
        return [...Array(rows).keys()].map(i => new Float32Array(columns));
    }

    function copyDataToBuffer(id, csharpVariable, dataDims) {

        const rows = dataDims.rows;
        const columns = dataDims.columns;

        if (rows === 0 || columns === 0) {
            return csharpVariable;
        }

        const vis_element = document.getElementById(`vis-${id}`);
        const canvas = vis_element.firstElementChild;
        const gl = canvas.getContext("webgl");

        const data = create2dArray(rows, columns);
        const buffers = new Array(rows);

        for (var i = 0; i < csharpVariable.length; ++i) {

            const obj = csharpVariable[i];

            var col_index = 0;
            for (const key in obj) {
                data[i][col_index++] = obj[key];
            }

            buffers[i] = gl.createBuffer();
            gl.bindBuffer(gl.ARRAY_BUFFER, buffers[i]);
            gl.bufferData(gl.ARRAY_BUFFER, data[i], gl.STATIC_DRAW);
        }

        console.log("gl Buffer Enabled.");

        return data;
    }

    function updateViewDataId(view, id, variableName, csharpVariable, dataDims) {
        try {
            const data = copyDataToBuffer(id, csharpVariable, dataDims);
            view.data(variableName, data);
        } catch (err) {
            console.log(err);
        }
    }

    function renderVegaLiteWebgl(id, vegalite_spec) {
        return (d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) => {

            const vlSpec = vegalite_spec;

            const opt = {
                renderer: "webgl",
                logLevel: vegaEmbed.Info
            };

            return vegaEmbed("#vis-" + `${id}`, vlSpec, opt);
        };
    }

    function renderVegaLiteSvg(id, vegalite_spec) {
        return (d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) => {

            const vlSpec = vegalite_spec;

            const opt = {
                renderer: "svg",
                logLevel: vegaEmbed.Info
            };

            return vegaEmbed("#vis-" + `${id}`, vlSpec, opt);
        };
    }

    function requireVegaLiteWebgl(id, vegalite_spec, variableName, rows, columns) {

        class DataDim {
            constructor(rows, columns) {
                this.rows = rows;
                this.columns = columns;
            }
        }

        const dataDims = new DataDim(rows, columns);

        vega_require(["d3-color", "vega", "vega-lite", "vega-embed", "vega-webgl"],
            function(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) {

                interactive.csharp.getVariable(variableName).then(function(csharpVariable) {

                    renderVegaLiteWebgl(id, vegalite_spec)(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl).then(function(result) {

                        updateViewDataId(result.view, id, variableName, csharpVariable, dataDims);

                    });

                });
            });
    }

    VegaLiteScript.requireVegaLiteWebgl = requireVegaLiteWebgl;

    function requireVegaLiteSvg(id, vegalite_spec) {

        vega_require(["d3-color", "vega", "vega-lite", "vega-embed", "vega-webgl"],
            function(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl) {

                renderVegaLiteSvg(id, vegalite_spec)(d3Color, vega, vegaLite, vegaEmbed, vegaWebgl).then();

            });
    }

    VegaLiteScript.requireVegaLiteSvg = requireVegaLiteSvg;

}(this);