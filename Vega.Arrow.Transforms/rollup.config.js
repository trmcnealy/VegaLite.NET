
//import { rollup } from 'rollup';
import nodeResolve from "@rollup/plugin-node-resolve";
//import typescript from "@rollup/plugin-typescript";
//import wasm from "@rollup/plugin-wasm";
//import progress from "rollup-plugin-progress";
//import json from "@rollup/plugin-json";
//import globImport from "rollup-plugin-glob-import";
import commonjs from "@rollup/plugin-commonjs";
//import compiler from "rollup-plugin-closure-compiler-js";

//"rollup": "^2.3.0",
//"rollup-plugin-glob-import": "^0.4.5",
//"rollup-plugin-node-resolve": "^5.2.0",
//"rollup-plugin-progress": "^1.1.1",
//"rollup-plugin-sourcemaps": "^0.5.0",
//"rollup-plugin-terser": "^5.3.0",
//"rollup-plugin-closure-compiler-js": "^1.0.6",
//"@rollup/plugin-commonjs": "^11.0.2",
//"@rollup/plugin-inject": "^4.0.1",
//"@rollup/plugin-json": "^4.0.2",
//"@rollup/plugin-node-resolve": "^7.1.1",
//"@rollup/plugin-typescript": "^4.0.0",
//"@rollup/plugin-wasm": "^3.0.0",
//"@rollup/pluginutils": "^3.0.8"

export default {
    input: [
        "build/index.js"
    ],
    external: [
        "apache-arrow",
        "vega-lite"
    ],
    context: "window",
    output: {
        name: "vega.transforms.arrow",
        format: "umd",
        //dir: "build",
        file: "build/vega-arrow-transforms.js",
        //interop: true,
        preferConst: true,
        globals: {
            "vega-lite": "vegalite",
            "apache-arrow": "apacheArrow"
        },
        sourcemap: true,
        plugins: [
            nodeResolve({
                browser: true,
                preferBuiltins: true,
                customResolveOptions: {
                    moduleDirectory: "node_modules/vega-lite/build/src"
                }
            }),
            commonjs()
            //wasm(),
            //json(),
            //compiler({
            //    //language_in: 'ECMASCRIPT_2015',
            //    //language_out: 'NO_TRANSPILE',
            //    //compilation_level: "ADVANCED",
            //    //assume_function_wrapper: true,
            //    //module_resolution: 'NODE',
            //    inject_libraries: true,
            //    force_inject_library: "vega-lite/build/src"
            //})
            //globImport({
            //    include: "vega-lite"
            //})
            //progress({
            //    clearLine: false
            //})
        ]
    }
};