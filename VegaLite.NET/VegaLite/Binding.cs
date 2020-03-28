using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// When set, a selection is populated by input elements (also known as dynamic query
    /// widgets)
    /// or by interacting with the corresponding legend. Direct manipulation interaction is
    /// disabled by default;
    /// to re-enable it, set the selection's
    /// [`on`](https://vega.github.io/vega-lite/docs/selection.html#common-selection-properties)
    /// property.
    ///
    /// Legend bindings are restricted to selections that only specify a single field or
    /// encoding.
    ///
    /// Query widget binding takes the form of Vega's [input element binding
    /// definition](https://vega.github.io/vega/docs/signals/#bind)
    /// or can be a mapping between projected field/encodings and binding definitions.
    ///
    /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
    /// </summary>
    public struct Binding
    {
        public Dictionary<string, AnyStream> AnythingMap;
        public LegendBindingEnum?               Enum;

        public static implicit operator Binding(Dictionary<string, AnyStream> anythingMap) => new Binding { AnythingMap = anythingMap };
        public static implicit operator Binding(LegendBindingEnum                @enum)        => new Binding { Enum        = @enum };
    }
}