
namespace VegaLite
{
    /// <summary>
    /// The alignment to apply to symbol legends rows and columns. The supported string values
    /// are `"all"`, `"each"` (the default), and `none`. For more information, see the [grid
    /// layout documentation](https://vega.github.io/vega/docs/layout).
    ///
    /// __Default value:__ `"each"`.
    ///
    /// The alignment to apply to row/column facet's subplot.
    /// The supported string values are `"all"`, `"each"`, and `"none"`.
    ///
    /// - For `"none"`, a flow layout will be used, in which adjacent subviews are simply placed
    /// one after the other.
    /// - For `"each"`, subviews will be aligned into a clean grid structure, but each row or
    /// column may be of variable size.
    /// - For `"all"`, subviews will be aligned and each row or column will be sized identically
    /// based on the maximum observed size. String values for this property will be applied to
    /// both grid rows and columns.
    ///
    /// __Default value:__ `"all"`.
    /// </summary>
    public enum LayoutAlign { All, Each, None }

    /// <summary>
    /// The sizing format type. One of `"pad"`, `"fit"`, `"fit-x"`, `"fit-y"`,  or `"none"`. See
    /// the [autosize type](https://vega.github.io/vega-lite/docs/size.html#autosize)
    /// documentation for descriptions of each.
    ///
    /// __Default value__: `"pad"`
    /// </summary>
    public enum AutosizeType { Fit, FitX, FitY, None, Pad }

    /// <summary>
    /// Determines how size calculation should be performed, one of `"content"` or `"padding"`.
    /// The default setting (`"content"`) interprets the width and height settings as the data
    /// rectangle (plotting) dimensions, to which padding is then added. In contrast, the
    /// `"padding"` setting includes the padding within the view size calculations, such that the
    /// width and height settings indicate the **total** intended size of the view.
    ///
    /// __Default value__: `"content"`
    /// </summary>
    public enum Contains { Content, Padding }

    /// <summary>
    /// The bounds calculation method to use for determining the extent of a sub-plot. One of
    /// `full` (the default) or `flush`.
    ///
    /// - If set to `full`, the entire calculated bounds (including axes, title, and legend) will
    /// be used.
    /// - If set to `flush`, only the specified width and height values for the sub-view will be
    /// used. The `flush` setting can be useful when attempting to place sub-plots without axes
    /// or legends into a uniform grid structure.
    ///
    /// __Default value:__ `"full"`
    /// </summary>
    public enum BoundsEnum { Flush, Full }

    /// <summary>
    /// Type of input data: `"json"`, `"csv"`, `"tsv"`, `"dsv"`.
    ///
    /// __Default value:__  The default format type is determined by the extension of the file
    /// URL.
    /// If no extension is detected, `"json"` will be used by default.
    /// </summary>
    public enum DataFormatType { Csv, Dsv, Json, Topojson, Tsv }

    /// <summary>
    /// An [aggregate operation](https://vega.github.io/vega-lite/docs/aggregate.html#ops) to
    /// perform on the field prior to sorting (e.g., `"count"`, `"mean"` and `"median"`).
    /// An aggregation is required when there are multiple values of the sort field for each
    /// encoded data field.
    /// The input data objects will be aggregated, grouped by the encoded data field.
    ///
    /// For a full list of operations, please see the documentation for
    /// [aggregate](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
    ///
    /// __Default value:__ `"sum"` for stacked plots. Otherwise, `"mean"`.
    /// </summary>
    public enum NonArgAggregateOp { Average, Ci0, Ci1, Count, Distinct, Max, Mean, Median, Min, Missing, Q1, Q3, Stderr, Stdev, Stdevp, Sum, Valid, Values, Variance, Variancep }

    /// <summary>
    /// The encoding channel to extract selected values for, when a selection is
    /// [projected](https://vega.github.io/vega-lite/docs/project.html)
    /// over multiple fields or encodings.
    /// </summary>
    public enum SingleDefUnitChannel { Color, Fill, FillOpacity, Href, Key, Latitude, Latitude2, Longitude, Longitude2, Opacity, Shape, Size, Stroke, StrokeOpacity, StrokeWidth, Text, Url, X, X2, Y, Y2 }

    /// <summary>
    /// Time unit for the field to be filtered.
    ///
    /// Time unit (e.g., `year`, `yearmonth`, `month`, `hours`) for a temporal field.
    /// or [a temporal field that gets casted as
    /// ordinal](https://vega.github.io/vega-lite/docs/type.html#cast).
    ///
    /// __Default value:__ `undefined` (None)
    ///
    /// __See also:__ [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html)
    /// documentation.
    ///
    /// The timeUnit.
    /// </summary>
    public enum TimeUnit { Date, Day, Hours, Hoursminutes, Hoursminutesseconds, Milliseconds, Minutes, Minutesseconds, Month, Monthdate, Monthdatehours, Quarter, Quartermonth, Seconds, Secondsmilliseconds, Utcdate, Utcday, Utchours, Utchoursminutes, Utchoursminutesseconds, Utcmilliseconds, Utcminutes, Utcminutesseconds, Utcmonth, Utcmonthdate, Utcmonthdatehours, Utcquarter, Utcquartermonth, Utcseconds, Utcsecondsmilliseconds, Utcyear, Utcyearmonth, Utcyearmonthdate, Utcyearmonthdatehours, Utcyearmonthdatehoursminutes, Utcyearmonthdatehoursminutesseconds, Utcyearquarter, Utcyearquartermonth, Year, Yearmonth, Yearmonthdate, Yearmonthdatehours, Yearmonthdatehoursminutes, Yearmonthdatehoursminutesseconds, Yearquarter, Yearquartermonth }

    /// <summary>
    /// The type of gradient. Use `"linear"` for a linear gradient.
    ///
    /// The type of gradient. Use `"radial"` for a radial gradient.
    /// </summary>
    public enum Gradient { Linear, Radial }

    public enum RepeatEnum { Column, Repeat, Row }

    /// <summary>
    /// The orientation of a non-stacked bar, tick, area, and line charts.
    /// The value is either horizontal (default) or vertical.
    /// - For bar, rule and tick, this determines whether the size of the bar and tick
    /// should be applied to x or y dimension.
    /// - For area, this property determines the orient property of the Vega output.
    /// - For line and trail marks, this property determines the sort order of the points in the
    /// line
    /// if `config.sortLineBy` is not specified.
    /// For stacked charts, this is always determined by the orientation of the stack;
    /// therefore explicitly specified value will be ignored.
    ///
    /// The default direction (`"horizontal"` or `"vertical"`) for gradient legends.
    ///
    /// __Default value:__ `"vertical"`.
    ///
    /// The default direction (`"horizontal"` or `"vertical"`) for symbol legends.
    ///
    /// __Default value:__ `"vertical"`.
    ///
    /// The direction of the legend, one of `"vertical"` or `"horizontal"`.
    ///
    /// __Default value:__
    /// - For top-/bottom-`orient`ed legends, `"horizontal"`
    /// - For left-/right-`orient`ed legends, `"vertical"`
    /// - For top/bottom-left/right-`orient`ed legends, `"horizontal"` for gradient legends and
    /// `"vertical"` for symbol legends.
    ///
    /// Orientation of the box plot. This is normally automatically determined based on types of
    /// fields on x and y channels. However, an explicit `orient` be specified when the
    /// orientation is ambiguous.
    ///
    /// __Default value:__ `"vertical"`.
    ///
    /// Orientation of the error bar. This is normally automatically determined, but can be
    /// specified when the orientation is ambiguous and cannot be automatically determined.
    ///
    /// Orientation of the error band. This is normally automatically determined, but can be
    /// specified when the orientation is ambiguous and cannot be automatically determined.
    /// </summary>
    public enum Orientation { Horizontal, Vertical }

    /// <summary>
    /// The format type for labels (`"number"` or `"time"`).
    ///
    /// __Default value:__
    /// - `"time"` for temporal fields and ordinal and nomimal fields with `timeUnit`.
    /// - `"number"` for quantitative fields as well as ordinal and nomimal fields without
    /// `timeUnit`.
    /// </summary>
    public enum FormatType { Number, Time }

    /// <summary>
    /// The horizontal alignment of the text or ranged marks (area, bar, image, rect, rule). One
    /// of `"left"`, `"right"`, `"center"`.
    ///
    /// Horizontal text alignment of axis tick labels, overriding the default setting for the
    /// current axis orientation.
    ///
    /// Horizontal text alignment of axis titles.
    ///
    /// Horizontal text alignment of header labels. One of `"left"`, `"center"`, or `"right"`.
    ///
    /// Horizontal text alignment (to the anchor) of header titles.
    ///
    /// The alignment of the legend label, can be left, center, or right.
    ///
    /// Horizontal text alignment for legend titles.
    ///
    /// __Default value:__ `"left"`.
    ///
    /// Horizontal text alignment for title text. One of `"left"`, `"center"`, or `"right"`.
    /// </summary>
    public enum Align { Center, Left, Right }

    /// <summary>
    /// The vertical alignment of the text or ranged marks (area, bar, image, rect, rule). One of
    /// `"top"`, `"middle"`, `"bottom"`.
    ///
    /// __Default value:__ `"middle"`
    ///
    /// Vertical text baseline of axis tick labels, overriding the default setting for the
    /// current axis orientation. Can be `"top"`, `"middle"`, `"bottom"`, or `"alphabetic"`.
    ///
    /// Vertical text baseline for axis titles.
    ///
    /// Vertical text baseline for the header title. One of `"top"`, `"bottom"`, `"middle"`.
    ///
    /// __Default value:__ `"middle"`
    ///
    /// The position of the baseline of legend label, can be `"top"`, `"middle"`, `"bottom"`, or
    /// `"alphabetic"`.
    ///
    /// __Default value:__ `"middle"`.
    ///
    /// Vertical text baseline for legend titles.
    ///
    /// __Default value:__ `"top"`.
    ///
    /// Vertical text baseline for title and subtitle text. One of `"top"`, `"middle"`,
    /// `"bottom"`, or `"alphabetic"`.
    /// </summary>
    public enum Baseline { Alphabetic, Bottom, Middle, Top }

    public enum PurpleFontWeight { Bold, Bolder, Lighter, Normal }

    public enum LabelOverlapEnum { Greedy, Parity }

    /// <summary>
    /// The orientation of the legend, which determines how the legend is positioned within the
    /// scene. One of "left", "right", "top-left", "top-right", "bottom-left", "bottom-right",
    /// "none".
    ///
    /// __Default value:__ `"right"`
    ///
    /// The orientation of the legend, which determines how the legend is positioned within the
    /// scene. One of `"left"`, `"right"`, `"top"`, `"bottom"`, `"top-left"`, `"top-right"`,
    /// `"bottom-left"`, `"bottom-right"`, `"none"`.
    ///
    /// __Default value:__ `"right"`
    /// </summary>
    public enum LegendOrient { Bottom, BottomLeft, BottomRight, Left, None, Right, Top, TopLeft, TopRight }

    public enum TimeInterval { Day, Hour, Millisecond, Minute, Month, Second, Week, Year }

    public enum TitleAnchorEnum { End, Middle, Start }

    /// <summary>
    /// The orientation of the header label. One of `"top"`, `"bottom"`, `"left"` or `"right"`.
    ///
    /// The orientation of the header title. One of `"top"`, `"bottom"`, `"left"` or `"right"`.
    ///
    /// Orientation of the legend title.
    ///
    /// The orientation of the axis. One of `"top"`, `"bottom"`, `"left"` or `"right"`. The
    /// orientation can be used to further specialize the axis type (e.g., a y-axis oriented
    /// towards the right edge of the chart).
    ///
    /// __Default value:__ `"bottom"` for x-axes and `"left"` for y-axes.
    /// </summary>
    public enum Orient { Bottom, Left, Right, Top }

    /// <summary>
    /// The type of the legend. Use `"symbol"` to create a discrete legend and `"gradient"` for a
    /// continuous color gradient.
    ///
    /// __Default value:__ `"gradient"` for non-binned quantitative fields and temporal fields;
    /// `"symbol"` otherwise.
    /// </summary>
    public enum LegendType { Gradient, Symbol }

    public enum Domain { Unaggregated }

    public enum ScaleInterpolate { Cubehelix, CubehelixLong, Hcl, HclLong, Hsl, HslLong, Lab, Rgb }

    public enum ScaleInterpolateParamsType { Cubehelix, CubehelixLong, Rgb }

    public enum NiceTime { Day, Hour, Minute, Month, Second, Week, Year }

    public enum RangeEnum { Category, Diverging, Heatmap, Height, Ordinal, Ramp, Symbol, Width }

    /// <summary>
    /// The type of scale. Vega-Lite supports the following categories of scale types:
    ///
    /// 1) [**Continuous Scales**](https://vega.github.io/vega-lite/docs/scale.html#continuous)
    /// -- mapping continuous domains to continuous output ranges
    /// ([`"linear"`](https://vega.github.io/vega-lite/docs/scale.html#linear),
    /// [`"pow"`](https://vega.github.io/vega-lite/docs/scale.html#pow),
    /// [`"sqrt"`](https://vega.github.io/vega-lite/docs/scale.html#sqrt),
    /// [`"symlog"`](https://vega.github.io/vega-lite/docs/scale.html#symlog),
    /// [`"log"`](https://vega.github.io/vega-lite/docs/scale.html#log),
    /// [`"time"`](https://vega.github.io/vega-lite/docs/scale.html#time),
    /// [`"utc"`](https://vega.github.io/vega-lite/docs/scale.html#utc).
    ///
    /// 2) [**Discrete Scales**](https://vega.github.io/vega-lite/docs/scale.html#discrete) --
    /// mapping discrete domains to discrete
    /// ([`"ordinal"`](https://vega.github.io/vega-lite/docs/scale.html#ordinal)) or continuous
    /// ([`"band"`](https://vega.github.io/vega-lite/docs/scale.html#band) and
    /// [`"point"`](https://vega.github.io/vega-lite/docs/scale.html#point)) output ranges.
    ///
    /// 3) [**Discretizing
    /// Scales**](https://vega.github.io/vega-lite/docs/scale.html#discretizing) -- mapping
    /// continuous domains to discrete output ranges
    /// [`"bin-ordinal"`](https://vega.github.io/vega-lite/docs/scale.html#bin-ordinal),
    /// [`"quantile"`](https://vega.github.io/vega-lite/docs/scale.html#quantile),
    /// [`"quantize"`](https://vega.github.io/vega-lite/docs/scale.html#quantize) and
    /// [`"threshold"`](https://vega.github.io/vega-lite/docs/scale.html#threshold).
    ///
    /// __Default value:__ please see the [scale type
    /// table](https://vega.github.io/vega-lite/docs/scale.html#type).
    /// </summary>
    public enum ScaleType { Band, BinOrdinal, Linear, Log, Ordinal, Point, Pow, Quantile, Quantize, Sqrt, Symlog, Threshold, Time, Utc }

    /// <summary>
    /// The sort order. One of `"ascending"` (default) or `"descending"`.
    ///
    /// The [encoding channel](https://vega.github.io/vega-lite/docs/encoding.html#channels) to
    /// sort by (e.g., `"x"`, `"y"`)
    /// </summary>
    public enum Sort { Ascending, Color, Descending, Fill, FillOpacity, Opacity, Shape, Size, SortColor, SortFill, SortFillOpacity, SortOpacity, SortShape, SortSize, SortStroke, SortStrokeOpacity, SortStrokeWidth, SortText, SortX, SortY, Stroke, StrokeOpacity, StrokeWidth, Text, X, Y }

    /// <summary>
    /// The [encoding channel](https://vega.github.io/vega-lite/docs/encoding.html#channels) to
    /// sort by (e.g., `"x"`, `"y"`)
    /// </summary>
    public enum SortByChannel { Color, Fill, FillOpacity, Opacity, Shape, Size, Stroke, StrokeOpacity, StrokeWidth, Text, X, Y }

    /// <summary>
    /// The sort order. One of `"ascending"` (default) or `"descending"`.
    /// </summary>
    public enum SortOrder { Ascending, Descending }

    /// <summary>
    /// The encoded field's type of measurement (`"quantitative"`, `"temporal"`, `"ordinal"`, or
    /// `"nominal"`).
    /// It can also be a `"geojson"` type for encoding
    /// ['geoshape'](https://vega.github.io/vega-lite/docs/geoshape.html).
    ///
    ///
    /// __Note:__
    ///
    /// - DataSource values for a temporal field can be either a date-time string (e.g., `"2015-03-07
    /// 12:32:17"`, `"17:01"`, `"2015-03-16"`. `"2015"`) or a timestamp number (e.g.,
    /// `1552199579097`).
    /// - DataSource `type` describes the semantics of the data rather than the primitive data types
    /// (number, string, etc.). The same primitive data type can have different types of
    /// measurement. For example, numeric data can represent quantitative, ordinal, or nominal
    /// data.
    /// - When using with [`bin`](https://vega.github.io/vega-lite/docs/bin.html), the `type`
    /// property can be either `"quantitative"` (for using a linear bin scale) or [`"ordinal"`
    /// (for using an ordinal bin
    /// scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html), the
    /// `type` property can be either `"temporal"` (for using a temporal scale) or [`"ordinal"`
    /// (for using an ordinal scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html),
    /// the `type` property refers to the post-aggregation data type. For example, we can
    /// calculate count `distinct` of a categorical field `"cat"` using `{"aggregate":
    /// "distinct", "field": "cat", "type": "quantitative"}`. The `"type"` of the aggregate
    /// output is `"quantitative"`.
    /// - Secondary channels (e.g., `x2`, `y2`, `xError`, `yError`) do not have `type` as they
    /// have exactly the same type as their primary channels (e.g., `x`, `y`).
    ///
    /// __See also:__ [`type`](https://vega.github.io/vega-lite/docs/type.html) documentation.
    /// </summary>
    public enum StandardType { Nominal, Ordinal, Quantitative, Temporal }

    public enum BinEnum { Binned }

    /// <summary>
    /// The encoded field's type of measurement (`"quantitative"`, `"temporal"`, `"ordinal"`, or
    /// `"nominal"`).
    /// It can also be a `"geojson"` type for encoding
    /// ['geoshape'](https://vega.github.io/vega-lite/docs/geoshape.html).
    ///
    ///
    /// __Note:__
    ///
    /// - DataSource values for a temporal field can be either a date-time string (e.g., `"2015-03-07
    /// 12:32:17"`, `"17:01"`, `"2015-03-16"`. `"2015"`) or a timestamp number (e.g.,
    /// `1552199579097`).
    /// - DataSource `type` describes the semantics of the data rather than the primitive data types
    /// (number, string, etc.). The same primitive data type can have different types of
    /// measurement. For example, numeric data can represent quantitative, ordinal, or nominal
    /// data.
    /// - When using with [`bin`](https://vega.github.io/vega-lite/docs/bin.html), the `type`
    /// property can be either `"quantitative"` (for using a linear bin scale) or [`"ordinal"`
    /// (for using an ordinal bin
    /// scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html), the
    /// `type` property can be either `"temporal"` (for using a temporal scale) or [`"ordinal"`
    /// (for using an ordinal scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html),
    /// the `type` property refers to the post-aggregation data type. For example, we can
    /// calculate count `distinct` of a categorical field `"cat"` using `{"aggregate":
    /// "distinct", "field": "cat", "type": "quantitative"}`. The `"type"` of the aggregate
    /// output is `"quantitative"`.
    /// - Secondary channels (e.g., `x2`, `y2`, `xError`, `yError`) do not have `type` as they
    /// have exactly the same type as their primary channels (e.g., `x`, `y`).
    ///
    /// __See also:__ [`type`](https://vega.github.io/vega-lite/docs/type.html) documentation.
    /// </summary>
    public enum LatitudeType { Quantitative }

    /// <summary>
    /// The encoded field's type of measurement (`"quantitative"`, `"temporal"`, `"ordinal"`, or
    /// `"nominal"`).
    /// It can also be a `"geojson"` type for encoding
    /// ['geoshape'](https://vega.github.io/vega-lite/docs/geoshape.html).
    ///
    ///
    /// __Note:__
    ///
    /// - DataSource values for a temporal field can be either a date-time string (e.g., `"2015-03-07
    /// 12:32:17"`, `"17:01"`, `"2015-03-16"`. `"2015"`) or a timestamp number (e.g.,
    /// `1552199579097`).
    /// - DataSource `type` describes the semantics of the data rather than the primitive data types
    /// (number, string, etc.). The same primitive data type can have different types of
    /// measurement. For example, numeric data can represent quantitative, ordinal, or nominal
    /// data.
    /// - When using with [`bin`](https://vega.github.io/vega-lite/docs/bin.html), the `type`
    /// property can be either `"quantitative"` (for using a linear bin scale) or [`"ordinal"`
    /// (for using an ordinal bin
    /// scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`timeUnit`](https://vega.github.io/vega-lite/docs/timeunit.html), the
    /// `type` property can be either `"temporal"` (for using a temporal scale) or [`"ordinal"`
    /// (for using an ordinal scale)](https://vega.github.io/vega-lite/docs/type.html#cast-bin).
    /// - When using with [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html),
    /// the `type` property refers to the post-aggregation data type. For example, we can
    /// calculate count `distinct` of a categorical field `"cat"` using `{"aggregate":
    /// "distinct", "field": "cat", "type": "quantitative"}`. The `"type"` of the aggregate
    /// output is `"quantitative"`.
    /// - Secondary channels (e.g., `x2`, `y2`, `xError`, `yError`) do not have `type` as they
    /// have exactly the same type as their primary channels (e.g., `x`, `y`).
    ///
    /// __See also:__ [`type`](https://vega.github.io/vega-lite/docs/type.html) documentation.
    /// </summary>
    public enum TypeForShape { Geojson, Nominal, Ordinal }

    /// <summary>
    /// For band scales, indicates if ticks and grid lines should be placed at the center of a
    /// band (default) or at the band extents to indicate intervals.
    /// </summary>
    public enum TickBand { Center, Extent }

    /// <summary>
    /// The imputation method to use for the field value of imputed data objects.
    /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
    ///
    /// __Default value:__  `"value"`
    /// </summary>
    public enum ImputeParamsMethod { Max, Mean, Median, Min, Value }

    /// <summary>
    /// Mode for stacking marks. One of `"zero"` (default), `"center"`, or `"normalize"`.
    /// The `"zero"` offset will stack starting at `0`. The `"center"` offset will center the
    /// stacks. The `"normalize"` offset will compute percentage values for each stack point,
    /// with output values in the range `[0,1]`.
    ///
    /// __Default value:__ `"zero"`
    /// </summary>
    public enum StackOffset { Center, Normalize, Zero }

    public enum ValueWidthEnum { Width }

    public enum ValueHeightEnum { Height }

    public enum HeightEnum { Container }

    /// <summary>
    /// The mark type. This could a primitive mark type
    /// (one of `"bar"`, `"circle"`, `"square"`, `"tick"`, `"line"`,
    /// `"area"`, `"point"`, `"geoshape"`, `"rule"`, and `"text"`)
    /// or a composite mark type (`"boxplot"`, `"errorband"`, `"errorbar"`).
    ///
    /// All types of primitive marks.
    /// </summary>
    public enum BoxPlot { Area, Bar, Boxplot, Circle, Errorband, Errorbar, Geoshape, Image, Line, Point, Rect, Rule, Square, Text, Tick, Trail }

    /// <summary>
    /// The mouse cursor used over the mark. Any valid [CSS cursor
    /// type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
    /// </summary>
    public enum Cursor { Alias, AllScroll, Auto, Cell, ColResize, ContextMenu, Copy, Crosshair, Default, EResize, EwResize, Grab, Grabbing, Help, Move, NResize, NeResize, NeswResize, NoDrop, None, NotAllowed, NsResize, NwResize, NwseResize, Pointer, Progress, RowResize, SResize, SeResize, SwResize, Text, VerticalText, WResize, Wait, ZoomIn, ZoomOut }

    /// <summary>
    /// The direction of the text. One of `"ltr"` (left-to-right) or `"rtl"` (right-to-left).
    /// This property determines on which side is truncated in response to the limit parameter.
    ///
    /// __Default value:__ `"ltr"`
    /// </summary>
    public enum Dir { Ltr, Rtl }

    /// <summary>
    /// The line interpolation method to use for line and area marks. One of the following:
    /// - `"linear"`: piecewise linear segments, as in a polyline.
    /// - `"linear-closed"`: close the linear segments to form a polygon.
    /// - `"step"`: alternate between horizontal and vertical segments, as in a step function.
    /// - `"step-before"`: alternate between vertical and horizontal segments, as in a step
    /// function.
    /// - `"step-after"`: alternate between horizontal and vertical segments, as in a step
    /// function.
    /// - `"basis"`: a B-spline, with control point duplication on the ends.
    /// - `"basis-open"`: an open B-spline; may not intersect the start or end.
    /// - `"basis-closed"`: a closed B-spline, as in a loop.
    /// - `"cardinal"`: a Cardinal spline, with control point duplication on the ends.
    /// - `"cardinal-open"`: an open Cardinal spline; may not intersect the start or end, but
    /// will intersect other control points.
    /// - `"cardinal-closed"`: a closed Cardinal spline, as in a loop.
    /// - `"bundle"`: equivalent to basis, except the tension parameter is used to straighten the
    /// spline.
    /// - `"monotone"`: cubic interpolation that preserves monotonicity in y.
    ///
    /// The line interpolation method for the error band. One of the following:
    /// - `"linear"`: piecewise linear segments, as in a polyline.
    /// - `"linear-closed"`: close the linear segments to form a polygon.
    /// - `"step"`: a piecewise constant function (a step function) consisting of alternating
    /// horizontal and vertical lines. The y-value changes at the midpoint of each pair of
    /// adjacent x-values.
    /// - `"step-before"`: a piecewise constant function (a step function) consisting of
    /// alternating horizontal and vertical lines. The y-value changes before the x-value.
    /// - `"step-after"`: a piecewise constant function (a step function) consisting of
    /// alternating horizontal and vertical lines. The y-value changes after the x-value.
    /// - `"basis"`: a B-spline, with control point duplication on the ends.
    /// - `"basis-open"`: an open B-spline; may not intersect the start or end.
    /// - `"basis-closed"`: a closed B-spline, as in a loop.
    /// - `"cardinal"`: a Cardinal spline, with control point duplication on the ends.
    /// - `"cardinal-open"`: an open Cardinal spline; may not intersect the start or end, but
    /// will intersect other control points.
    /// - `"cardinal-closed"`: a closed Cardinal spline, as in a loop.
    /// - `"bundle"`: equivalent to basis, except the tension parameter is used to straighten the
    /// spline.
    /// - `"monotone"`: cubic interpolation that preserves monotonicity in y.
    /// </summary>
    public enum Interpolate { Basis, BasisClosed, BasisOpen, Bundle, Cardinal, CardinalClosed, CardinalOpen, CatmullRom, Linear, LinearClosed, Monotone, Natural, Step, StepAfter, StepBefore }

    public enum Invalid { Filter }

    /// <summary>
    /// The stroke cap for line ending style. One of `"butt"`, `"round"`, or `"square"`.
    ///
    /// __Default value:__ `"square"`
    /// </summary>
    public enum StrokeCap { Butt, Round, Square }

    /// <summary>
    /// The stroke line join method. One of `"miter"`, `"round"` or `"bevel"`.
    ///
    /// __Default value:__ `"miter"`
    /// </summary>
    public enum StrokeJoin { Bevel, Miter, Round }

    public enum Content { Data, Encoding }

    /// <summary>
    /// The extent of the band. Available options include:
    /// - `"ci"`: Extend the band to the confidence interval of the mean.
    /// - `"stderr"`: The size of band are set to the value of standard error, extending from the
    /// mean.
    /// - `"stdev"`: The size of band are set to the value of standard deviation, extending from
    /// the mean.
    /// - `"iqr"`: Extend the band to the q1 and q3.
    ///
    /// __Default value:__ `"stderr"`.
    ///
    /// The extent of the rule. Available options include:
    /// - `"ci"`: Extend the rule to the confidence interval of the mean.
    /// - `"stderr"`: The size of rule are set to the value of standard error, extending from the
    /// mean.
    /// - `"stdev"`: The size of rule are set to the value of standard deviation, extending from
    /// the mean.
    /// - `"iqr"`: Extend the rule to the q1 and q3.
    ///
    /// __Default value:__ `"stderr"`.
    /// </summary>
    public enum ExtentExtent { Ci, Iqr, MinMax, Stderr, Stdev }

    public enum PointEnum { Transparent }

    /// <summary>
    /// The cartographic projection to use. This value is case-insensitive, for example
    /// `"albers"` and `"Albers"` indicate the same projection type. You can find all valid
    /// projection types [in the
    /// documentation](https://vega.github.io/vega-lite/docs/projection.html#projection-types).
    ///
    /// __Default value:__ `mercator`
    /// </summary>
    public enum ProjectionType { Albers, AlbersUsa, AzimuthalEqualArea, AzimuthalEquidistant, ConicConformal, ConicEqualArea, ConicEquidistant, EqualEarth, Equirectangular, Gnomonic, Identity, Mercator, NaturalEarth1, Orthographic, Stereographic, TransverseMercator }

    public enum ResolveMode { Independent, Shared }

    /// <summary>
    /// Establishes a two-way binding between the interval selection and the scales
    /// used within the same view. This allows a user to interactively pan and
    /// zoom the view.
    ///
    /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
    /// </summary>
    public enum PurpleLegendBinding { Legend, Scales }

    public enum MarkType { Arc, Area, Group, Image, Line, Path, Rect, Rule, Shape, Symbol, Text, Trail }

    public enum Source { Scope, View, Window }

    /// <summary>
    /// By default, `all` data values are considered to lie within an empty selection.
    /// When set to `none`, empty selections contain no data values.
    /// </summary>
    public enum Empty { All, None }

    /// <summary>
    /// With layered and multi-view displays, a strategy that determines how
    /// selections' data queries are resolved when applied in a filter transform,
    /// conditional encoding rule, or scale domain.
    ///
    /// __See also:__ [`resolve`](https://vega.github.io/vega-lite/docs/selection-resolve.html)
    /// documentation.
    /// </summary>
    public enum SelectionResolution { Global, Intersect, Union }

    /// <summary>
    /// Determines the default event processing and data query for the selection. Vega-Lite
    /// currently supports three selection types:
    ///
    /// - `"single"` -- to select a single discrete data value on `click`.
    /// - `"multi"` -- to select multiple discrete data value; the first value is selected on
    /// `click` and additional values toggled on shift-`click`.
    /// - `"interval"` -- to select a continuous range of data values on `drag`.
    /// </summary>
    public enum SelectionDefType { Interval, Multi, Single }

    /// <summary>
    /// Default title orientation (`"top"`, `"bottom"`, `"left"`, or `"right"`)
    /// </summary>
    public enum TitleOrient { Bottom, Left, None, Right, Top }

    /// <summary>
    /// The aggregation operation to apply to the fields (e.g., `"sum"`, `"average"`, or
    /// `"count"`).
    /// See the [full list of supported aggregation
    /// operations](https://vega.github.io/vega-lite/docs/aggregate.html#ops)
    /// for more information.
    ///
    /// The aggregation operation to apply (e.g., `"sum"`, `"average"` or `"count"`). See the
    /// list of all supported operations
    /// [here](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
    /// </summary>
    public enum AggregateOp { Argmax, Argmin, Average, Ci0, Ci1, Count, Distinct, Max, Mean, Median, Min, Missing, Q1, Q3, Stderr, Stdev, Stdevp, Sum, Valid, Values, Variance, Variancep }

    /// <summary>
    /// The imputation method to use for the field value of imputed data objects.
    /// One of `"value"`, `"mean"`, `"median"`, `"max"` or `"min"`.
    ///
    /// __Default value:__  `"value"`
    ///
    /// The functional form of the regression model. One of `"linear"`, `"log"`, `"exp"`,
    /// `"pow"`, `"quad"`, or `"poly"`.
    ///
    /// __Default value:__ `"linear"`
    /// </summary>
    public enum TransformMethod { Exp, Linear, Log, Max, Mean, Median, Min, Poly, Pow, Quad, Value }

    /// <summary>
    /// The window or aggregation operation to apply within a window (e.g., `"rank"`, `"lead"`,
    /// `"sum"`, `"average"` or `"count"`). See the list of all supported operations
    /// [here](https://vega.github.io/vega-lite/docs/window.html#ops).
    ///
    /// The aggregation operation to apply to the fields (e.g., `"sum"`, `"average"`, or
    /// `"count"`).
    /// See the [full list of supported aggregation
    /// operations](https://vega.github.io/vega-lite/docs/aggregate.html#ops)
    /// for more information.
    ///
    /// The aggregation operation to apply (e.g., `"sum"`, `"average"` or `"count"`). See the
    /// list of all supported operations
    /// [here](https://vega.github.io/vega-lite/docs/aggregate.html#ops).
    /// </summary>
    public enum Op { Argmax, Argmin, Average, Ci0, Ci1, Count, CumeDist, DenseRank, Distinct, FirstValue, Lag, LastValue, Lead, Max, Mean, Median, Min, Missing, NthValue, Ntile, PercentRank, Q1, Q3, Rank, RowNumber, Stderr, Stdev, Stdevp, Sum, Valid, Values, Variance, Variancep }

    public enum ExtentEnum { MinMax }

    /// <summary>
    /// The extent of the band. Available options include:
    /// - `"ci"`: Extend the band to the confidence interval of the mean.
    /// - `"stderr"`: The size of band are set to the value of standard error, extending from the
    /// mean.
    /// - `"stdev"`: The size of band are set to the value of standard deviation, extending from
    /// the mean.
    /// - `"iqr"`: Extend the band to the q1 and q3.
    ///
    /// __Default value:__ `"stderr"`.
    ///
    /// The extent of the rule. Available options include:
    /// - `"ci"`: Extend the rule to the confidence interval of the mean.
    /// - `"stderr"`: The size of rule are set to the value of standard error, extending from the
    /// mean.
    /// - `"stdev"`: The size of rule are set to the value of standard deviation, extending from
    /// the mean.
    /// - `"iqr"`: Extend the rule to the q1 and q3.
    ///
    /// __Default value:__ `"stderr"`.
    /// </summary>
    public enum ErrorbandExtent { Ci, Iqr, Stderr, Stdev }

    /// <summary>
    /// Defines how Vega-Lite generates title for fields. There are three possible styles:
    /// - `"verbal"` (Default) - displays function in a verbal style (e.g., "Sum of field",
    /// "Year-month of date", "field (binned)").
    /// - `"function"` - displays function using parentheses and capitalized texts (e.g.,
    /// "SUM(field)", "YEARMONTH(date)", "BIN(field)").
    /// - `"plain"` - displays only the field name without functions (e.g., "field", "date",
    /// "field").
    /// </summary>
    public enum FieldTitle { Functional, Plain, Verbal }

    /// <summary>
    /// Establishes a two-way binding between the interval selection and the scales
    /// used within the same view. This allows a user to interactively pan and
    /// zoom the view.
    ///
    /// __See also:__ [`bind`](https://vega.github.io/vega-lite/docs/bind.html) documentation.
    /// </summary>
    public enum Bind { Scales }

    public enum LegendBindingEnum { Legend }
}
