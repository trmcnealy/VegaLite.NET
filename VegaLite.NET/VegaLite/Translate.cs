namespace VegaLite
{
    /// <summary>
    /// When truthy, allows a user to interactively move an interval selection
    /// back-and-forth. Can be `true`, `false` (to disable panning), or a
    /// [Vega event stream definition](https://vega.github.io/vega/docs/event-streams/)
    /// which must include a start and end event to trigger continuous panning.
    ///
    /// __Default value:__ `true`, which corresponds to
    /// `[mousedown, window:mouseup] > window:mousemove!` which corresponds to
    /// clicks and dragging within an interval selection to reposition it.
    ///
    /// __See also:__ [`translate`](https://vega.github.io/vega-lite/docs/translate.html)
    /// documentation.
    ///
    /// When truthy, allows a user to interactively resize an interval selection.
    /// Can be `true`, `false` (to disable zooming), or a [Vega event stream
    /// definition](https://vega.github.io/vega/docs/event-streams/). Currently,
    /// only `wheel` events are supported.
    ///
    /// __Default value:__ `true`, which corresponds to `wheel!`.
    ///
    /// __See also:__ [`zoom`](https://vega.github.io/vega-lite/docs/zoom.html) documentation.
    ///
    /// Controls whether data values should be toggled or only ever inserted into
    /// multi selections. Can be `true`, `false` (for insertion only), or a
    /// [Vega expression](https://vega.github.io/vega/docs/expressions/).
    ///
    /// __Default value:__ `true`, which corresponds to `event.shiftKey` (i.e.,
    /// data values are toggled when a user interacts with the shift-key pressed).
    ///
    /// __See also:__ [`toggle`](https://vega.github.io/vega-lite/docs/toggle.html) documentation.
    /// </summary>
    public struct Translate
    {
        public bool?  Bool;
        public string String;

        public static implicit operator Translate(bool   @bool)   => new Translate { Bool   = @bool };
        public static implicit operator Translate(string @string) => new Translate { String = @string };
    }
}