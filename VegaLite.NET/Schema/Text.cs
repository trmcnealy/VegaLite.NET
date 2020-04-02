using System.Collections.Generic;

namespace VegaLite.Schema
{
    /// <summary>
    /// A string or array of strings indicating the name of custom styles to apply to the mark. A
    /// style is a named collection of mark property defaults defined within the [style
    /// configuration](https://vega.github.io/vega-lite/docs/mark.html#style-config). If style is
    /// an array, later styles will override earlier styles. Any [mark
    /// properties](https://vega.github.io/vega-lite/docs/encoding.html#mark-prop) explicitly
    /// defined within the `encoding` will override a style default.
    ///
    /// __Default value:__ The mark's name. For example, a bar mark will have style `"bar"` by
    /// default.
    /// __Note:__ Any specified style will augment the default style. For example, a bar mark
    /// with `"style": "foo"` will receive from `config.style.bar` and `config.style.foo` (the
    /// specified style `"foo"` has higher precedence).
    ///
    /// Placeholder text if the `text` channel is not specified
    ///
    /// A constant value in visual domain (e.g., `"red"` / `"#0099ff"` / [gradient
    /// definition](https://vega.github.io/vega-lite/docs/types.html#gradient) for color, values
    /// between `0` to `1` for opacity).
    ///
    /// The subtitle Text.
    ///
    /// The title text.
    ///
    /// Output field names. This can be either a string or an array of strings with two elements
    /// denoting the name for the fields for stack start and stack end respectively.
    /// If a single string(e.g., `"val"`) is provided, the end field will be `"val_end"`.
    ///
    /// A string or array of strings indicating the name of custom styles to apply to the view
    /// background. A style is a named collection of mark property defaults defined within the
    /// [style configuration](https://vega.github.io/vega-lite/docs/mark.html#style-config). If
    /// style is an array, later styles will override earlier styles.
    ///
    /// __Default value:__ `"cell"`
    /// __Note:__ Any specified view background properties will augment the default style.
    /// </summary>
    public struct Text
    {
        public string       String;
        public List<string> StringArray;

        public static implicit operator Text(string @string)
        {
            return new Text
            {
                String = @string
            };
        }

        public static implicit operator Text(List<string> stringArray)
        {
            return new Text
            {
                StringArray = stringArray
            };
        }
    }
}
