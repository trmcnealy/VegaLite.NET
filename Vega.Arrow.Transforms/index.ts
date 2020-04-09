
import { Table } from "apache-arrow";

import { NormalizedUnitSpec } from "vega-lite/build/src/spec";

import { isUrlData, UrlData } from "vega-lite/build/src/data";

import { extractTransforms } from "vega-lite/build/src/transformextract";

import { defaultConfig } from "vega-lite/build/src/config";

import { Transforms2Arrow } from "./src/arrow-transform";

//export * from "./src/main";

export async function LoadApacheArrowFromUrl(url: string): Promise<Table> {
    const buf = await fetch(url).then(response => response.arrayBuffer());

    return await Table.fromAsync([new Uint8Array(buf)]);
};

function ArrowSpecTranform(spec: NormalizedUnitSpec): any {

    const modifiedSpec = extractTransforms(spec, defaultConfig);

    const data = spec.data;

    if (isUrlData(data) && ((data as UrlData).format.type as string) === "arrow") {

        delete modifiedSpec.data;

        const table = LoadApacheArrowFromUrl(data.url);

        const transforms = modifiedSpec.transform;

        delete modifiedSpec.transform;

        const modifiedData = Transforms2Arrow.convert(table, transforms);

        Object.assign({ data: { modifiedData } }, modifiedSpec);

        return modifiedData;
    }

    return spec;
}

//export { Transforms2Arrow } from "./src/arrow-transform";

export default { ArrowSpecTranform };