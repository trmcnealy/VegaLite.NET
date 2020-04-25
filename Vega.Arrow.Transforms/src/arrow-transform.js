
import { Transform, ingest, inherits, transforms } from "vega";

import { Table } from "apache-arrow";

export default function ArrowTransform(params) {
    Transform.call(this, [], params);
}

ArrowTransform.DataTable = function(table_data) {

    if (table_data instanceof Table) {
        this._dataTable = table_data;
    }

    if (table_data instanceof ArrayBuffer) {
        table_data = new Uint8Array(table_data);
        this._dataTable = Table.from(Array.isArray(table_data) ? table_data : [table_data]);
    }

    return this._dataTable;
};

ArrowTransform.Definition = {
    type: "ArrowTransform",
    metadata: { changes: true, source: true },
    params: [
        { name: "filter", type: "Predicate" },
        { name: "getColumn", type: "field" },
        { name: "getColumnAt", type: "number" },
        { name: "select", type: "field", array: true },
        { name: "selectAt", type: "number", array: true },
        { name: "slice", type: "param", "params": [{ name: "begin", type: "number" }, { name: "end", type: "number" }] }
    ]
};

const prototype = inherits(ArrowTransform, Transform);

prototype.transform = async function(_, pulse) {

    if (!this._dataTable) {
        throw Error("ArrowTransform missing data Table.");
    }

    let filter = _.filter;
    let getColumn = _.getColumn;
    let getColumnAt = _.getColumnAt;
    let select = _.select;
    let selectAt = _.selectAt;
    let slice = _.slice;

    let results = null;

    if (filter) {
        results = await this._dataTable.filter(filter);
    } else if (getColumn) {
        results = await this._dataTable.getColumn(getColumn);
    } else if (getColumnAt) {
        results = await this._dataTable.getColumnAt(getColumnAt);
    } else if (select) {
        results = await this._dataTable.select(select);
    } else if (selectAt) {
        results = await this._dataTable.selectAt(selectAt);
    } else if (slice) {
        results = await this._dataTable.slice(slice.get("begin"), slice.get("end"));
    }

//results.forEach(ingest);

    for (var result in results) {
        ingest(result);
    }

    const out = pulse.fork(pulse.NO_FIELDS & pulse.NO_SOURCE);

    out.rem = this._value;

    this._value = out.add = out.source = results;

    return out;
};



// we can only support a small subset of aggregate operations with our current approach
//static agg_op_mappings = {
//    argmax: "",
//    argmin: "",
//    average: "",
//    count: "",
//    distinct: "",
//    product: "",
//    max: "",
//    mean: "",
//    median: "",
//    min: "",
//    missing: "",
//    q1: "",
//    q3: "",
//    ci0: "",
//    ci1: "",
//    stderr: "",
//    stdev: "",
//    stdevp: "",
//    sum: "",
//    valid: "",
//    values: "",
//    variance: "",
//    variancep: ""
//};

//static predicate_mappings = {
//    " == ": "eq",
//    "equal": "eq",
//    " > ": "le"

//};

//private static translate_op(op: string): string {
//    return this.agg_op_mappings[op] || op;
//}

//private static translate_predicate_op(op: string): string {
//    return this.predicate_mappings[op] || op;
//}