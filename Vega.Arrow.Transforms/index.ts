
import { Table } from "apache-arrow";

//import * as vega from "vega";

import * as vega from "vega-typings";

import ArrowTransform from "./src/arrow-transform";

//export * from "./src/main";

export async function LoadApacheArrowFromUrl(url: string): Promise<Table> {
    const buf = await fetch(url).then(response => response.arrayBuffer());

    return await Table.fromAsync([new Uint8Array(buf)]);
};

function ArrowSpecTranform(spec: vega.Spec): any {

    const anyVega = vega as any;

    anyVega.transforms["arrowtransform"] = ArrowTransform;


    for (let data of spec.data) {

        if (data instanceof anyVega.UrlData && (data.format.type as string === "arrow")) {

            const table = LoadApacheArrowFromUrl(data.url);




        } else if (data instanceof anyVega.ValuesData && (data.format.type as string === "arrow"))  {

        }

    }


//    const data = spec.data;
//
//    if (isUrlData(data.url) && ((data as UrlData).format.type as string) === "arrow") {
//
//        delete modifiedSpec.data;
//
//        const table = LoadApacheArrowFromUrl(data.url);
//
//        const transforms = modifiedSpec.transform;
//
//        delete modifiedSpec.transform;
//
//        const modifiedData = Transforms2Arrow.convert(table, transforms);
//
//        Object.assign({ data: { modifiedData } }, modifiedSpec);
//
//        return modifiedData;
//    }

    return spec;
}

//export { Transforms2Arrow } from "./src/arrow-transform";

export default { ArrowSpecTranform };