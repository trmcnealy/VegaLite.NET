import * as vegaImport from "vega";
//import * as vegaLiteImport from "vega-lite";
import * as apacheArrowImport from "apache-arrow";

export const vega = vegaImport;
//export const vegaLite = vegaLiteImport;
export const apacheArrow = apacheArrowImport;

import Transform = vegaImport.Transform;
import Table = apacheArrowImport.Table;

//import { FieldName } from "vega-lite/build/src/channeldef";
//import { LogicalComposition } from "vega-lite/build/src/logical";
//import { Predicate } from "vega-lite/build/src/predicate";

//arrow.predicate.col('precipitation').eq(0)

export class Slice {
    public begin: number;
    public end: number;

    constructor(begin: number, end: number) {
        this.begin = begin;
        this.end = end;
    }
}

export class ArrowTransform extends Transform {
    public type: string = "ArrowTransform";

    public countBy?: string;

    public filter?: string;

    public getColumn?: string;

    public getColumnAt?: number;

    public select?: string[];

    public selectAt?: number[];

    public slice?: Slice;

    protected _data?: Table;

    protected _value: any;

    constructor(params?: any[]) {
        super([], params);
    }

    public data(table_data: any): ArrowTransform {

        if (table_data instanceof Table) {
            this._data = table_data;
            return this;
        }

        if (table_data instanceof ArrayBuffer) {
            table_data = new Uint8Array(table_data);
            this._data = Table.from(Array.isArray(table_data) ? table_data : [table_data]);
            return this;
        }

        this._data = Table.new(table_data);

        return this;
    }

    public async transform(pulse: any, params?: any): Promise<any> {

        if (!this._data) {
            throw Error(
                "ArrowTransform missing data Table."
            );
        }

        if (!params) {
            throw Error(
                "ArrowTransform missing params."
            );
        }

        var _countBy = params.countBy as string;
        var _filter = params.filter;
        var _getColumn = params.getColumn;
        var _getColumnAt = params.getColumnAt;
        var _select = params.select;
        var _selectAt = params.selectAt;
        var _slice = params.slice;

        var result: any;

        if (_countBy) {
            result = await this._data.countBy(_countBy);
            //result.forEach(ingest);
            //pulse.
        } else if (_filter) {
            result = await this._data.filter(_filter);
            //result.forEach(ingest);
        } else if (_getColumn) {
            result = await this._data.getColumn(_getColumn);
            //result.forEach(ingest);
        } else if (_getColumnAt) {
            result = await this._data.getColumnAt(_getColumnAt);
            //result.forEach(ingest);
        } else if (_select) {
            result = await this._data.select(_select);
            //result.forEach(ingest);
        } else if (_selectAt) {
            result = await this._data.selectAt(_selectAt);
            //result.forEach(ingest);
        } else if (_slice) {
            result = await this._data.slice(_slice.get("begin"), _slice.get("end"));
            //result.forEach(ingest);
        }
                

        const out = pulse.fork(pulse.NO_FIELDS & pulse.NO_SOURCE);

        out.rem = this._value;

        this._value = out.add = out.source = result;

        return out;
    }
}

export function register(Vega: any) {
    if ("undefined" !== Vega) {
        Vega.transforms["ArrowFilter"] = ArrowTransform;
    }
}


//export default function ArrowTransform(params: any[]) {
//    Transform.call(this, [], params);
//}



//ArrowTransform.Definition = {
//    type: "ArrowFilter",
//    metadata: { changes: true, source: true },
//    params: [
//        { name: "countBy", type: "field" },
//        { name: "filter", type: "expr" },
//        { name: "getColumn", type: "field" },
//        { name: "getColumnAt", type: "number" },
//        { name: "select", type: "field", "array": true },
//        { name: "selectAt", type: "number", "array": true },
//        { name: "slice", type: "param", "params": [{ name: "begin", type: "number" }, { name: "end", type: "number" }] }
//    ]
//};

//const prototype = inherits(ArrowTransform, Transform);

//ArrowTransform.prototype.transform = async function (_, pulse) {

//    if (!ArrowTransform._data) {
//        throw Error(
//            "ArrowTransform missing data Table."
//        );
//    }

//    var countBy = _.countBy;
//    var filter = _.filter;
//    var getColumn = _.getColumn;
//    var getColumnAt = _.getColumnAt;
//    var select = _.select;
//    var selectAt = _.selectAt;
//    var slice = _.slice;

//    var result;

//    if (countBy) {
//        result = await ArrowTransform._data.countBy(countBy);
//    } else if (filter) {
//        result = await ArrowTransform._data.filter(filter);
//    } else if (getColumn) {
//        result = await ArrowTransform._data.getColumn(getColumn);
//    } else if (getColumnAt) {
//        result = await ArrowTransform._data.getColumnAt(getColumnAt);
//    } else if (select) {
//        result = await ArrowTransform._data.select(select);
//    } else if (selectAt) {
//        result = await ArrowTransform._data.selectAt(selectAt);
//    } else if (slice) {
//        result = await ArrowTransform._data.slice(slice.get("begin"), slice.get("end"));
//    }

//    result.forEach(ingest);

//    const out = pulse.fork(pulse.NO_FIELDS & pulse.NO_SOURCE);

//    out.rem = this.value;

//    this.value = out.add = out.source = result;

//    return out;
//};