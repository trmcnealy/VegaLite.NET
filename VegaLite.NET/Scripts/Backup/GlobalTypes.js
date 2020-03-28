const NamedStruct = (name, ...keys) => ((...v) => keys.reduce((o, k, i) => {
        o[k] = v[i];
        return o;
    },
    { _name: name }));

const dim = NamedStruct("dim", "rows", "columns");