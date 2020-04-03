//import commonjs from "@rollup/plugin-commonjs";
//import json from "@rollup/plugin-json";
//import nodeResolve from "@rollup/plugin-node-resolve";
//import sourcemaps from "rollup-plugin-sourcemaps";

//export function disallowedImports() {
//    return {
//        resolveId: module => {
//            if (module === "util" || module === "d3") {
//                throw new Error("Cannot import from Vega, Node Util, or D3 in Vega-Lite.");
//            }
//            return null;
//        }
//    };
//}disallowedImports(),

export default {
    input: "build/index.js",
    external: ["vega", "vega-lite", "apache-arrow"],
    context: "window",
    output: {
        file: "build/vega-arrow-transforms.js",
        format: "umd",
        sourcemap: true,
        name: "vega.transforms.arrow",
        globals: {
            "vega": "vega",
            "vega-lite": "vegaLite",
            "apache-arrow": "apacheArrow"
        }
    }
    //plugins: [nodeResolve({ browser: true }), commonjs(), json(), sourcemaps()]
};