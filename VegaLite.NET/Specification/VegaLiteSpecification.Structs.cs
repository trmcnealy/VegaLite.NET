
using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    /// <summary>
    /// The alignment to apply to grid rows and columns.
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
    /// Alternatively, an object value of the form `{"row": string, "column": string}` can be
    /// used to supply different alignments for rows and columns.
    ///
    /// __Default value:__ `"all"`.
    /// </summary>
    public struct AlignUnion
    {
        public LayoutAlign? Enum;
        public RowColLayoutAlign RowColLayoutAlign;

        public static implicit operator AlignUnion(LayoutAlign @enum) => new AlignUnion { Enum = @enum };
        public static implicit operator AlignUnion(RowColLayoutAlign rowColLayoutAlign) => new AlignUnion { RowColLayoutAlign = rowColLayoutAlign };
    }

    /// <summary>
    /// How the visualization size should be determined. If a string, should be one of `"pad"`,
    /// `"fit"` or `"none"`.
    /// Object values can additionally specify parameters for content sizing and automatic
    /// resizing.
    ///
    /// __Default value__: `pad`
    /// </summary>
    public struct Autosize
    {
        public AutoSizeParams AutoSizeParams;
        public AutosizeType? Enum;

        public static implicit operator Autosize(AutoSizeParams autoSizeParams) => new Autosize { AutoSizeParams = autoSizeParams };
        public static implicit operator Autosize(AutosizeType @enum) => new Autosize { Enum = @enum };
    }

    public struct SpecificationCenter
    {
        public bool? Bool;
        public RowColBoolean RowColBoolean;

        public static implicit operator SpecificationCenter(bool @bool) => new SpecificationCenter { Bool = @bool };
        public static implicit operator SpecificationCenter(RowColBoolean rowColBoolean) => new SpecificationCenter { RowColBoolean = rowColBoolean };
    }

    /// <summary>
    /// Generate graticule GeoJSON data for geographic reference lines.
    /// </summary>
    public struct Graticule
    {
        public bool? Bool;
        public GraticuleParams GraticuleParams;

        public static implicit operator Graticule(bool @bool) => new Graticule { Bool = @bool };
        public static implicit operator Graticule(GraticuleParams graticuleParams) => new Graticule { GraticuleParams = graticuleParams };
    }

    /// <summary>
    /// Generate sphere GeoJSON data for the full globe.
    /// </summary>
    public struct SphereUnion
    {
        public bool? Bool;
        public SphereClass SphereClass;

        public static implicit operator SphereUnion(bool @bool) => new SphereUnion { Bool = @bool };
        public static implicit operator SphereUnion(SphereClass sphereClass) => new SphereUnion { SphereClass = sphereClass };
    }

    public struct InlineDatasetElement
    {
        public Dictionary<string, object> AnythingMap;
        public bool? Bool;
        public double? Double;
        public string String;

        public static implicit operator InlineDatasetElement(Dictionary<string, object> anythingMap) => new InlineDatasetElement { AnythingMap = anythingMap };
        public static implicit operator InlineDatasetElement(bool @bool) => new InlineDatasetElement { Bool = @bool };
        public static implicit operator InlineDatasetElement(double @double) => new InlineDatasetElement { Double = @double };
        public static implicit operator InlineDatasetElement(string @string) => new InlineDatasetElement { String = @string };
    }

    /// <summary>
    /// The full data set, included inline. This can be an array of objects or primitive values,
    /// an object, or a string.
    /// Arrays of primitive values are ingested as objects with a `data` property. Strings are
    /// parsed according to the specified format type.
    /// </summary>
    public struct InlineDataset
    {
        public List<InlineDatasetElement> AnythingArray;
        public Dictionary<string, object> AnythingMap;
        public string String;

        public static implicit operator InlineDataset(List<InlineDatasetElement> anythingArray) => new InlineDataset { AnythingArray = anythingArray };
        public static implicit operator InlineDataset(Dictionary<string, object> anythingMap) => new InlineDataset { AnythingMap = anythingMap };
        public static implicit operator InlineDataset(string @string) => new InlineDataset { String = @string };
    }

    /// <summary>
    /// Aggregation function for the field
    /// (e.g., `"mean"`, `"sum"`, `"median"`, `"min"`, `"max"`, `"count"`).
    ///
    /// __Default value:__ `undefined` (None)
    ///
    /// __See also:__ [`aggregate`](https://vega.github.io/vega-lite/docs/aggregate.html)
    /// documentation.
    /// </summary>
    public struct Aggregate
    {
        public ArgmDef ArgmDef;
        public NonArgAggregateOp? Enum;

        public static implicit operator Aggregate(ArgmDef argmDef) => new Aggregate { ArgmDef = argmDef };
        public static implicit operator Aggregate(NonArgAggregateOp @enum) => new Aggregate { Enum = @enum };
    }

    /// <summary>
    /// A two-element (`[min, max]`) array indicating the range of desired bin values.
    /// </summary>
    public struct BinExtent
    {
        public BinExtentClass BinExtentClass;
        public List<double> DoubleArray;

        public static implicit operator BinExtent(BinExtentClass binExtentClass) => new BinExtent { BinExtentClass = binExtentClass };
        public static implicit operator BinExtent(List<double> doubleArray) => new BinExtent { DoubleArray = doubleArray };
    }

    public struct PurpleBin
    {
        public BinParams BinParams;
        public bool? Bool;

        public static implicit operator PurpleBin(BinParams binParams) => new PurpleBin { BinParams = binParams };
        public static implicit operator PurpleBin(bool @bool) => new PurpleBin { Bool = @bool };
        public bool IsNull => Bool == null && BinParams == null;
    }

    /// <summary>
    /// Filter using a selection name.
    ///
    /// A [selection name](https://vega.github.io/vega-lite/docs/selection.html), or a series of
    /// [composed selections](https://vega.github.io/vega-lite/docs/selection.html#compose).
    /// </summary>
    public struct SelectionOperand
    {
        public Selection Selection;
        public string String;

        public static implicit operator SelectionOperand(Selection selection) => new SelectionOperand { Selection = selection };
        public static implicit operator SelectionOperand(string @string) => new SelectionOperand { String = @string };
    }

    /// <summary>
    /// Predicate for triggering the condition
    ///
    /// The `filter` property must be one of the predicate definitions:
    ///
    /// 1) an [expression](https://vega.github.io/vega-lite/docs/types.html#expression) string,
    /// where `datum` can be used to refer to the current data object
    ///
    /// 2) one of the field predicates:
    /// [`equal`](https://vega.github.io/vega-lite/docs/filter.html#equal-predicate),
    /// [`lt`](https://vega.github.io/vega-lite/docs/filter.html#lt-predicate),
    /// [`lte`](https://vega.github.io/vega-lite/docs/filter.html#lte-predicate),
    /// [`gt`](https://vega.github.io/vega-lite/docs/filter.html#gt-predicate),
    /// [`gte`](https://vega.github.io/vega-lite/docs/filter.html#gte-predicate),
    /// [`range`](https://vega.github.io/vega-lite/docs/filter.html#range-predicate),
    /// [`oneOf`](https://vega.github.io/vega-lite/docs/filter.html#one-of-predicate),
    /// or [`valid`](https://vega.github.io/vega-lite/docs/filter.html#valid-predicate),
    ///
    /// 3) a [selection
    /// predicate](https://vega.github.io/vega-lite/docs/filter.html#selection-predicate)
    ///
    /// 4) a logical operand that combines (1), (2), or (3).
    /// </summary>
    public struct LogicalOperandPredicate
    {
        public Predicate Predicate;
        public string String;

        public static implicit operator LogicalOperandPredicate(Predicate predicate) => new LogicalOperandPredicate { Predicate = predicate };
        public static implicit operator LogicalOperandPredicate(string @string) => new LogicalOperandPredicate { String = @string };
    }

    /// <summary>
    /// Value representing the day of a week. This can be one of:
    /// (1) integer value -- `1` represents Monday;
    /// (2) case-insensitive day name (e.g., `"Monday"`);
    /// (3) case-insensitive, 3-character short day name (e.g., `"Mon"`).
    ///
    /// **Warning:** A DateTime definition object with `day`** should not be combined with
    /// `year`, `quarter`, `month`, or `date`.
    /// </summary>
    public struct Day
    {
        public double? Double;
        public string String;

        public static implicit operator Day(double @double) => new Day { Double = @double };
        public static implicit operator Day(string @string) => new Day { String = @string };
    }

    /// <summary>
    /// One of:
    /// (1) integer value representing the month from `1`-`12`. `1` represents January;
    /// (2) case-insensitive month name (e.g., `"January"`);
    /// (3) case-insensitive, 3-character short month name (e.g., `"Jan"`).
    /// </summary>
    public struct Month
    {
        public double? Double;
        public string String;

        public static implicit operator Month(double @double) => new Month { Double = @double };
        public static implicit operator Month(string @string) => new Month { String = @string };
    }

    public struct Equal
    {
        public bool? Bool;
        public DateTime DateTime;
        public double? Double;
        public string String;

        public static implicit operator Equal(bool @bool) => new Equal { Bool = @bool };
        public static implicit operator Equal(DateTime dateTime) => new Equal { DateTime = dateTime };
        public static implicit operator Equal(double @double) => new Equal { Double = @double };
        public static implicit operator Equal(string @string) => new Equal { String = @string };
    }

    public struct Lt
    {
        public DateTime DateTime;
        public double? Double;
        public string String;

        public static implicit operator Lt(DateTime dateTime) => new Lt { DateTime = dateTime };
        public static implicit operator Lt(double @double) => new Lt { Double = @double };
        public static implicit operator Lt(string @string) => new Lt { String = @string };
    }

    public struct PurpleRange
    {
        public DateTime DateTime;
        public double? Double;

        public static implicit operator PurpleRange(DateTime dateTime) => new PurpleRange { DateTime = dateTime };
        public static implicit operator PurpleRange(double @double) => new PurpleRange { Double = @double };
        public bool IsNull => DateTime == null && Double == null;
    }

    public struct ValueUnion
    {
        public string String;
        public ValueLinearGradient ValueLinearGradient;

        public static implicit operator ValueUnion(string @string) => new ValueUnion { String = @string };
        public static implicit operator ValueUnion(ValueLinearGradient valueLinearGradient) => new ValueUnion { ValueLinearGradient = valueLinearGradient };
        public bool IsNull => ValueLinearGradient == null && String == null;
    }

    /// <summary>
    /// __Required.__ A string defining the name of the field from which to pull a data value
    /// or an object defining iterated values from the
    /// [`repeat`](https://vega.github.io/vega-lite/docs/repeat.html) operator.
    ///
    /// __See also:__ [`field`](https://vega.github.io/vega-lite/docs/field.html) documentation.
    ///
    /// __Notes:__
    /// 1)  Dots (`.`) and brackets (`[` and `]`) can be used to access nested objects (e.g.,
    /// `"field": "foo.bar"` and `"field": "foo['bar']"`).
    /// If field names contain dots or brackets but are not nested, you can use `\\` to escape
    /// dots and brackets (e.g., `"a\\.b"` and `"a\\[0\\]"`).
    /// See more details about escaping in the [field
    /// documentation](https://vega.github.io/vega-lite/docs/field.html).
    /// 2) `field` is not required if `aggregate` is `count`.
    ///
    /// The data [field](https://vega.github.io/vega-lite/docs/field.html) to sort by.
    ///
    /// __Default value:__ If unspecified, defaults to the field specified in the outer data
    /// reference.
    /// </summary>
    public struct Field
    {
        public RepeatRef RepeatRef;
        public string String;

        public static implicit operator Field(RepeatRef repeatRef) => new Field { RepeatRef = repeatRef };
        public static implicit operator Field(string @string) => new Field { String = @string };
    }

    /// <summary>
    /// The font weight.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight of axis tick labels.
    ///
    /// Font weight of the title.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight of the header title.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// The font weight of legend label.
    ///
    /// The font weight of the legend title.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight for title text.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight for subtitle text.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    /// </summary>
    public struct FontWeight
    {
        public double? Double;
        public PurpleFontWeight? Enum;

        public static implicit operator FontWeight(double @double) => new FontWeight { Double = @double };
        public static implicit operator FontWeight(PurpleFontWeight @enum) => new FontWeight { Enum = @enum };
    }

    /// <summary>
    /// The strategy to use for resolving overlap of axis labels. If `false` (the default), no
    /// overlap reduction is attempted. If set to `true` or `"parity"`, a strategy of removing
    /// every other label is used (this works well for standard linear axes). If set to
    /// `"greedy"`, a linear scan of the labels is performed, removing any labels that overlaps
    /// with the last visible label (this often works better for log-scaled axes).
    ///
    /// __Default value:__ `true` for non-nominal fields with non-log scales; `"greedy"` for log
    /// scales; otherwise `false`.
    ///
    /// The strategy to use for resolving overlap of labels in gradient legends. If `false`, no
    /// overlap reduction is attempted. If set to `true` or `"parity"`, a strategy of removing
    /// every other label is used. If set to `"greedy"`, a linear scan of the labels is
    /// performed, removing any label that overlaps with the last visible label (this often works
    /// better for log-scaled axes).
    ///
    /// __Default value:__ `"greedy"` for `log scales otherwise `true`.
    ///
    /// The strategy to use for resolving overlap of labels in gradient legends. If `false`, no
    /// overlap reduction is attempted. If set to `true` (default) or `"parity"`, a strategy of
    /// removing every other label is used. If set to `"greedy"`, a linear scan of the labels is
    /// performed, removing any label that overlaps with the last visible label (this often works
    /// better for log-scaled axes).
    ///
    /// __Default value:__ `true`.
    /// </summary>
    public struct LabelOverlap
    {
        public bool? Bool;
        public LabelOverlapEnum? Enum;

        public static implicit operator LabelOverlap(bool @bool) => new LabelOverlap { Bool = @bool };
        public static implicit operator LabelOverlap(LabelOverlapEnum @enum) => new LabelOverlap { Enum = @enum };
    }

    public struct TickCount
    {
        public double? Double;
        public TimeInterval? Enum;

        public static implicit operator TickCount(double @double) => new TickCount { Double = @double };
        public static implicit operator TickCount(TimeInterval @enum) => new TickCount { Enum = @enum };
    }

    public struct PurpleText
    {
        public string String;
        public List<string> StringArray;

        public static implicit operator PurpleText(string @string) => new PurpleText { String = @string };
        public static implicit operator PurpleText(List<string> stringArray) => new PurpleText { StringArray = stringArray };
        public bool IsNull => StringArray == null && String == null;
    }

    /// <summary>
    /// Customized domain values.
    ///
    /// For _quantitative_ fields, `domain` can take the form of a two-element array with minimum
    /// and maximum values. [Piecewise
    /// scales](https://vega.github.io/vega-lite/docs/scale.html#piecewise) can be created by
    /// providing a `domain` with more than two entries.
    /// If the input field is aggregated, `domain` can also be a string value `"unaggregated"`,
    /// indicating that the domain should include the raw data values prior to the aggregation.
    ///
    /// For _temporal_ fields, `domain` can be a two-element array minimum and maximum values, in
    /// the form of either timestamps or the [DateTime definition
    /// objects](https://vega.github.io/vega-lite/docs/types.html#datetime).
    ///
    /// For _ordinal_ and _nominal_ fields, `domain` can be an array that lists valid input
    /// values.
    ///
    /// The `selection` property can be used to [interactively
    /// determine](https://vega.github.io/vega-lite/docs/selection.html#scale-domains) the scale
    /// domain.
    /// </summary>
    public struct DomainUnion
    {
        public List<Equal> AnythingArray;
        public DomainClass DomainClass;
        public Domain? Enum;

        public static implicit operator DomainUnion(List<Equal> anythingArray) => new DomainUnion { AnythingArray = anythingArray };
        public static implicit operator DomainUnion(DomainClass domainClass) => new DomainUnion { DomainClass = domainClass };
        public static implicit operator DomainUnion(Domain @enum) => new DomainUnion { Enum = @enum };
    }

    /// <summary>
    /// The interpolation method for range values. By default, a general interpolator for
    /// numbers, dates, strings and colors (in HCL space) is used. For color ranges, this
    /// property allows interpolation in alternative color spaces. Legal values include `rgb`,
    /// `hsl`, `hsl-long`, `lab`, `hcl`, `hcl-long`, `cubehelix` and `cubehelix-long` ('-long'
    /// variants use longer paths in polar coordinate spaces). If object-valued, this property
    /// accepts an object with a string-valued _type_ property and an optional numeric _gamma_
    /// property applicable to rgb and cubehelix interpolators. For more, see the [d3-interpolate
    /// documentation](https://github.com/d3/d3-interpolate).
    ///
    /// * __Default value:__ `hcl`
    /// </summary>
    public struct InterpolateUnion
    {
        public ScaleInterpolate? Enum;
        public ScaleInterpolateParams ScaleInterpolateParams;

        public static implicit operator InterpolateUnion(ScaleInterpolate @enum) => new InterpolateUnion { Enum = @enum };
        public static implicit operator InterpolateUnion(ScaleInterpolateParams scaleInterpolateParams) => new InterpolateUnion { ScaleInterpolateParams = scaleInterpolateParams };
    }

    /// <summary>
    /// Extending the domain so that it starts and ends on nice round values. This method
    /// typically modifies the scale’s domain, and may only extend the bounds to the nearest
    /// round value. Nicing is useful if the domain is computed from data and may be irregular.
    /// For example, for a domain of _[0.201479…, 0.996679…]_, a nice domain might be _[0.2,
    /// 1.0]_.
    ///
    /// For quantitative scales such as linear, `nice` can be either a boolean flag or a number.
    /// If `nice` is a number, it will represent a desired tick count. This allows greater
    /// control over the step size used to extend the bounds, guaranteeing that the returned
    /// ticks will exactly cover the domain.
    ///
    /// For temporal fields with time and utc scales, the `nice` value can be a string indicating
    /// the desired time interval. Legal values are `"millisecond"`, `"second"`, `"minute"`,
    /// `"hour"`, `"day"`, `"week"`, `"month"`, and `"year"`. Alternatively, `time` and `utc`
    /// scales can accept an object-valued interval specifier of the form `{"interval": "month",
    /// "step": 3}`, which includes a desired number of interval steps. Here, the domain would
    /// snap to quarter (Jan, Apr, Jul, Oct) boundaries.
    ///
    /// __Default value:__ `true` for unbinned _quantitative_ fields; `false` otherwise.
    /// </summary>
    public struct NiceUnion
    {
        public bool? Bool;
        public double? Double;
        public NiceTime? Enum;
        public NiceClass NiceClass;

        public static implicit operator NiceUnion(bool @bool) => new NiceUnion { Bool = @bool };
        public static implicit operator NiceUnion(double @double) => new NiceUnion { Double = @double };
        public static implicit operator NiceUnion(NiceTime @enum) => new NiceUnion { Enum = @enum };
        public static implicit operator NiceUnion(NiceClass niceClass) => new NiceUnion { NiceClass = niceClass };
    }

    public struct RangeRange
    {
        public double? Double;
        public string String;

        public static implicit operator RangeRange(double @double) => new RangeRange { Double = @double };
        public static implicit operator RangeRange(string @string) => new RangeRange { String = @string };
    }

    /// <summary>
    /// The range of the scale. One of:
    ///
    /// - A string indicating a [pre-defined named scale
    /// range](https://vega.github.io/vega-lite/docs/scale.html#range-config) (e.g., example,
    /// `"symbol"`, or `"diverging"`).
    ///
    /// - For [continuous scales](https://vega.github.io/vega-lite/docs/scale.html#continuous),
    /// two-element array indicating  minimum and maximum values, or an array with more than two
    /// entries for specifying a [piecewise
    /// scale](https://vega.github.io/vega-lite/docs/scale.html#piecewise).
    ///
    /// - For [discrete](https://vega.github.io/vega-lite/docs/scale.html#discrete) and
    /// [discretizing](https://vega.github.io/vega-lite/docs/scale.html#discretizing) scales, an
    /// array of desired output values.
    ///
    /// __Notes:__
    ///
    /// 1) For color scales you can also specify a color
    /// [`scheme`](https://vega.github.io/vega-lite/docs/scale.html#scheme) instead of `range`.
    ///
    /// 2) Any directly specified `range` for `x` and `y` channels will be ignored. Range can be
    /// customized via the view's corresponding
    /// [size](https://vega.github.io/vega-lite/docs/size.html) (`width` and `height`).
    /// </summary>
    public struct ScaleRange
    {
        public List<RangeRange> AnythingArray;
        public RangeEnum? Enum;

        public static implicit operator ScaleRange(List<RangeRange> anythingArray) => new ScaleRange { AnythingArray = anythingArray };
        public static implicit operator ScaleRange(RangeEnum @enum) => new ScaleRange { Enum = @enum };
    }

    /// <summary>
    /// A string indicating a color
    /// [scheme](https://vega.github.io/vega-lite/docs/scale.html#scheme) name (e.g.,
    /// `"category10"` or `"blues"`) or a [scheme parameter
    /// object](https://vega.github.io/vega-lite/docs/scale.html#scheme-params).
    ///
    /// Discrete color schemes may be used with
    /// [discrete](https://vega.github.io/vega-lite/docs/scale.html#discrete) or
    /// [discretizing](https://vega.github.io/vega-lite/docs/scale.html#discretizing) scales.
    /// Continuous color schemes are intended for use with color scales.
    ///
    /// For the full list of supported schemes, please refer to the [Vega
    /// Scheme](https://vega.github.io/vega/docs/schemes/#reference) reference.
    /// </summary>
    public struct Scheme
    {
        public SchemeParams SchemeParams;
        public string String;

        public static implicit operator Scheme(SchemeParams schemeParams) => new Scheme { SchemeParams = schemeParams };
        public static implicit operator Scheme(string @string) => new Scheme { String = @string };
    }

    /// <summary>
    /// Sort order for the encoded field.
    ///
    /// For continuous fields (quantitative or temporal), `sort` can be either `"ascending"` or
    /// `"descending"`.
    ///
    /// For discrete fields, `sort` can be one of the following:
    /// - `"ascending"` or `"descending"` -- for sorting by the values' natural order in
    /// JavaScript.
    /// - [A string indicating an encoding channel name to sort
    /// by](https://vega.github.io/vega-lite/docs/sort.html#sort-by-encoding) (e.g., `"x"` or
    /// `"y"`) with an optional minus prefix for descending sort (e.g., `"-x"` to sort by
    /// x-field, descending). This channel string is short-form of [a sort-by-encoding
    /// definition](https://vega.github.io/vega-lite/docs/sort.html#sort-by-encoding). For
    /// example, `"sort": "-x"` is equivalent to `"sort": {"encoding": "x", "order":
    /// "descending"}`.
    /// - [A sort field definition](https://vega.github.io/vega-lite/docs/sort.html#sort-field)
    /// for sorting by another field.
    /// - [An array specifying the field values in preferred
    /// order](https://vega.github.io/vega-lite/docs/sort.html#sort-array). In this case, the
    /// sort order will obey the values in the array, followed by any unspecified values in their
    /// original order. For discrete time field, values in the sort array can be [date-time
    /// definition objects](types#datetime). In addition, for time units `"month"` and `"day"`,
    /// the values can be the month or day names (case insensitive) or their 3-letter initials
    /// (e.g., `"Mon"`, `"Tue"`).
    /// - `null` indicating no sort.
    ///
    /// __Default value:__ `"ascending"`
    ///
    /// __Note:__ `null` and sorting by another channel is not supported for `row` and `column`.
    ///
    /// __See also:__ [`sort`](https://vega.github.io/vega-lite/docs/sort.html) documentation.
    /// </summary>
    public struct SortUnion
    {
        public List<Equal> AnythingArray;
        public EncodingSortField EncodingSortField;
        public Sort? Enum;

        public static implicit operator SortUnion(List<Equal> anythingArray) => new SortUnion { AnythingArray = anythingArray };
        public static implicit operator SortUnion(EncodingSortField encodingSortField) => new SortUnion { EncodingSortField = encodingSortField };
        public static implicit operator SortUnion(Sort @enum) => new SortUnion { Enum = @enum };
        public bool IsNull => AnythingArray == null && EncodingSortField == null && Enum == null;
    }

    public struct ColorCondition
    {
        public ConditionalPredicateValueDefGradientStringNullClass ConditionalPredicateValueDefGradientStringNullClass;
        public List<ConditionalValueDefGradientStringNull> ConditionalValueDefGradientStringNullArray;

        public static implicit operator ColorCondition(ConditionalPredicateValueDefGradientStringNullClass conditionalPredicateValueDefGradientStringNullClass) => new ColorCondition { ConditionalPredicateValueDefGradientStringNullClass = conditionalPredicateValueDefGradientStringNullClass };
        public static implicit operator ColorCondition(List<ConditionalValueDefGradientStringNull> conditionalValueDefGradientStringNullArray) => new ColorCondition { ConditionalValueDefGradientStringNullArray = conditionalValueDefGradientStringNullArray };
    }

    public struct SortArray
    {
        public List<Equal> AnythingArray;
        public SortOrder? Enum;
        public SortEncodingSortField SortEncodingSortField;

        public static implicit operator SortArray(List<Equal> anythingArray) => new SortArray { AnythingArray = anythingArray };
        public static implicit operator SortArray(SortOrder @enum) => new SortArray { Enum = @enum };
        public static implicit operator SortArray(SortEncodingSortField sortEncodingSortField) => new SortArray { SortEncodingSortField = sortEncodingSortField };
        public bool IsNull => AnythingArray == null && SortEncodingSortField == null && Enum == null;
    }

    public struct FluffyBin
    {
        public BinParams BinParams;
        public bool? Bool;
        public BinEnum? Enum;

        public static implicit operator FluffyBin(BinParams binParams) => new FluffyBin { BinParams = binParams };
        public static implicit operator FluffyBin(bool @bool) => new FluffyBin { Bool = @bool };
        public static implicit operator FluffyBin(BinEnum @enum) => new FluffyBin { Enum = @enum };
        public bool IsNull => Bool == null && BinParams == null && Enum == null;
    }

    public struct Detail
    {
        public TypedFieldDef TypedFieldDef;
        public List<TypedFieldDef> TypedFieldDefArray;

        public static implicit operator Detail(TypedFieldDef typedFieldDef) => new Detail { TypedFieldDef = typedFieldDef };
        public static implicit operator Detail(List<TypedFieldDef> typedFieldDefArray) => new Detail { TypedFieldDefArray = typedFieldDefArray };
    }

    public struct Spacing
    {
        public double? Double;
        public RowColNumber RowColNumber;

        public static implicit operator Spacing(double @double) => new Spacing { Double = @double };
        public static implicit operator Spacing(RowColNumber rowColNumber) => new Spacing { RowColNumber = rowColNumber };
    }

    public struct ConditionUnion
    {
        public ConditionalDef ConditionalDef;
        public List<ConditionalNumberValueDef> ConditionalNumberValueDefArray;

        public static implicit operator ConditionUnion(ConditionalDef conditionalDef) => new ConditionUnion { ConditionalDef = conditionalDef };
        public static implicit operator ConditionUnion(List<ConditionalNumberValueDef> conditionalNumberValueDefArray) => new ConditionUnion { ConditionalNumberValueDefArray = conditionalNumberValueDefArray };
    }

    public struct HrefCondition
    {
        public List<ConditionElement> ConditionElementArray;
        public ConditionalPredicateValueDefStringClass ConditionalPredicateValueDefStringClass;

        public static implicit operator HrefCondition(List<ConditionElement> conditionElementArray) => new HrefCondition { ConditionElementArray = conditionElementArray };
        public static implicit operator HrefCondition(ConditionalPredicateValueDefStringClass conditionalPredicateValueDefStringClass) => new HrefCondition { ConditionalPredicateValueDefStringClass = conditionalPredicateValueDefStringClass };
    }

    public struct Order
    {
        public List<OrderFieldDef> OrderFieldDefArray;
        public OrderFieldDefClass OrderFieldDefClass;

        public static implicit operator Order(List<OrderFieldDef> orderFieldDefArray) => new Order { OrderFieldDefArray = orderFieldDefArray };
        public static implicit operator Order(OrderFieldDefClass orderFieldDefClass) => new Order { OrderFieldDefClass = orderFieldDefClass };
    }

    public struct ShapeCondition
    {
        public ConditionalPredicateMarkPropFieldDefTypeForShapeClass ConditionalPredicateMarkPropFieldDefTypeForShapeClass;
        public List<ConditionalStringValueDef> ConditionalStringValueDefArray;

        public static implicit operator ShapeCondition(ConditionalPredicateMarkPropFieldDefTypeForShapeClass conditionalPredicateMarkPropFieldDefTypeForShapeClass) => new ShapeCondition { ConditionalPredicateMarkPropFieldDefTypeForShapeClass = conditionalPredicateMarkPropFieldDefTypeForShapeClass };
        public static implicit operator ShapeCondition(List<ConditionalStringValueDef> conditionalStringValueDefArray) => new ShapeCondition { ConditionalStringValueDefArray = conditionalStringValueDefArray };
    }

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
    /// A [mark style property](https://vega.github.io/vega-lite/docs/config.html#style) to apply
    /// to the title text mark.
    ///
    /// __Default value:__ `"group-title"`.
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
        public string String;
        public List<string> StringArray;

        public static implicit operator Text(string @string) => new Text { String = @string };
        public static implicit operator Text(List<string> stringArray) => new Text { StringArray = stringArray };
    }

    public struct TextCondition
    {
        public ConditionalPredicateValueDefTextClass ConditionalPredicateValueDefTextClass;
        public List<ConditionalValueDefText> ConditionalValueDefTextArray;

        public static implicit operator TextCondition(ConditionalPredicateValueDefTextClass conditionalPredicateValueDefTextClass) => new TextCondition { ConditionalPredicateValueDefTextClass = conditionalPredicateValueDefTextClass };
        public static implicit operator TextCondition(List<ConditionalValueDefText> conditionalValueDefTextArray) => new TextCondition { ConditionalValueDefTextArray = conditionalValueDefTextArray };
    }

    public struct Tooltip
    {
        public FieldDefWithConditionStringFieldDefString FieldDefWithConditionStringFieldDefString;
        public List<StringFieldDef> StringFieldDefArray;

        public static implicit operator Tooltip(FieldDefWithConditionStringFieldDefString fieldDefWithConditionStringFieldDefString) => new Tooltip { FieldDefWithConditionStringFieldDefString = fieldDefWithConditionStringFieldDefString };
        public static implicit operator Tooltip(List<StringFieldDef> stringFieldDefArray) => new Tooltip { StringFieldDefArray = stringFieldDefArray };
        public bool IsNull => StringFieldDefArray == null && FieldDefWithConditionStringFieldDefString == null;
    }

    public struct ConditionalAxisPropertyColorNullCondition
    {
        public ConditionalPredicateValueDefColorNull ConditionalPredicateValueDefColorNull;
        public List<ConditionalPredicateValueDefColorNull> ConditionalPredicateValueDefColorNullArray;

        public static implicit operator ConditionalAxisPropertyColorNullCondition(ConditionalPredicateValueDefColorNull conditionalPredicateValueDefColorNull) => new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNull = conditionalPredicateValueDefColorNull };
        public static implicit operator ConditionalAxisPropertyColorNullCondition(List<ConditionalPredicateValueDefColorNull> conditionalPredicateValueDefColorNullArray) => new ConditionalAxisPropertyColorNullCondition { ConditionalPredicateValueDefColorNullArray = conditionalPredicateValueDefColorNullArray };
    }

    public struct Color
    {
        public ConditionalAxisPropertyColorNull ConditionalAxisPropertyColorNull;
        public string String;

        public static implicit operator Color(ConditionalAxisPropertyColorNull conditionalAxisPropertyColorNull) => new Color { ConditionalAxisPropertyColorNull = conditionalAxisPropertyColorNull };
        public static implicit operator Color(string @string) => new Color { String = @string };
        public bool IsNull => ConditionalAxisPropertyColorNull == null && String == null;
    }

    public struct ConditionalAxisPropertyNumberNullCondition
    {
        public ConditionalPredicateValueDefNumberNull ConditionalPredicateValueDefNumberNull;
        public List<ConditionalPredicateValueDefNumberNull> ConditionalPredicateValueDefNumberNullArray;

        public static implicit operator ConditionalAxisPropertyNumberNullCondition(ConditionalPredicateValueDefNumberNull conditionalPredicateValueDefNumberNull) => new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNull = conditionalPredicateValueDefNumberNull };
        public static implicit operator ConditionalAxisPropertyNumberNullCondition(List<ConditionalPredicateValueDefNumberNull> conditionalPredicateValueDefNumberNullArray) => new ConditionalAxisPropertyNumberNullCondition { ConditionalPredicateValueDefNumberNullArray = conditionalPredicateValueDefNumberNullArray };
    }

    public struct Dash
    {
        public ConditionalAxisPropertyNumberNull ConditionalAxisPropertyNumberNull;
        public List<double> DoubleArray;

        public static implicit operator Dash(ConditionalAxisPropertyNumberNull conditionalAxisPropertyNumberNull) => new Dash { ConditionalAxisPropertyNumberNull = conditionalAxisPropertyNumberNull };
        public static implicit operator Dash(List<double> doubleArray) => new Dash { DoubleArray = doubleArray };
    }

    public struct ConditionalAxisPropertyNumberNullConditionUnion
    {
        public ConditionalPredicateValueDefNumberNullElement ConditionalPredicateValueDefNumberNullElement;
        public List<ConditionalPredicateValueDefNumberNullElement> ConditionalPredicateValueDefNumberNullElementArray;

        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(ConditionalPredicateValueDefNumberNullElement conditionalPredicateValueDefNumberNullElement) => new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElement = conditionalPredicateValueDefNumberNullElement };
        public static implicit operator ConditionalAxisPropertyNumberNullConditionUnion(List<ConditionalPredicateValueDefNumberNullElement> conditionalPredicateValueDefNumberNullElementArray) => new ConditionalAxisPropertyNumberNullConditionUnion { ConditionalPredicateValueDefNumberNullElementArray = conditionalPredicateValueDefNumberNullElementArray };
    }

    public struct GridDashOffset
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double? Double;

        public static implicit operator GridDashOffset(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new GridDashOffset { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator GridDashOffset(double @double) => new GridDashOffset { Double = @double };
    }

    public struct GridOpacity
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double? Double;

        public static implicit operator GridOpacity(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new GridOpacity { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator GridOpacity(double @double) => new GridOpacity { Double = @double };
    }

    public struct GridWidth
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public double? Double;

        public static implicit operator GridWidth(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new GridWidth { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator GridWidth(double @double) => new GridWidth { Double = @double };
    }

    public struct LabelAlign
    {
        public ConditionalAxisPropertyNumberNullClass ConditionalAxisPropertyNumberNullClass;
        public Align? Enum;

        public static implicit operator LabelAlign(ConditionalAxisPropertyNumberNullClass conditionalAxisPropertyNumberNullClass) => new LabelAlign { ConditionalAxisPropertyNumberNullClass = conditionalAxisPropertyNumberNullClass };
        public static implicit operator LabelAlign(Align @enum) => new LabelAlign { Enum = @enum };
    }

    public struct ConditionalAxisPropertyTextBaselineNullCondition
    {
        public ConditionalPredicateValueDefTextBaselineNull ConditionalPredicateValueDefTextBaselineNull;
        public List<ConditionalPredicateValueDefTextBaselineNull> ConditionalPredicateValueDefTextBaselineNullArray;

        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(ConditionalPredicateValueDefTextBaselineNull conditionalPredicateValueDefTextBaselineNull) => new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNull = conditionalPredicateValueDefTextBaselineNull };
        public static implicit operator ConditionalAxisPropertyTextBaselineNullCondition(List<ConditionalPredicateValueDefTextBaselineNull> conditionalPredicateValueDefTextBaselineNullArray) => new ConditionalAxisPropertyTextBaselineNullCondition { ConditionalPredicateValueDefTextBaselineNullArray = conditionalPredicateValueDefTextBaselineNullArray };
    }

    public struct TextBaseline
    {
        public ConditionalAxisPropertyTextBaselineNull ConditionalAxisPropertyTextBaselineNull;
        public Baseline? Enum;

        public static implicit operator TextBaseline(ConditionalAxisPropertyTextBaselineNull conditionalAxisPropertyTextBaselineNull) => new TextBaseline { ConditionalAxisPropertyTextBaselineNull = conditionalAxisPropertyTextBaselineNull };
        public static implicit operator TextBaseline(Baseline @enum) => new TextBaseline { Enum = @enum };
    }

    /// <summary>
    /// Indicates if labels should be hidden if they exceed the axis range. If `false` (the
    /// default) no bounds overlap analysis is performed. If `true`, labels will be hidden if
    /// they exceed the axis range by more than 1 pixel. If this property is a number, it
    /// specifies the pixel tolerance: the maximum amount by which a label bounding box may
    /// exceed the axis range.
    ///
    /// __Default value:__ `false`.
    ///
    /// Indicates if the first and last axis labels should be aligned flush with the scale range.
    /// Flush alignment for a horizontal axis will left-align the first label and right-align the
    /// last label. For vertical axes, bottom and top text baselines are applied instead. If this
    /// property is a number, it also indicates the number of pixels by which to offset the first
    /// and last labels; for example, a value of 2 will flush-align the first and last labels and
    /// also push them 2 pixels outward from the center of the axis. The additional adjustment
    /// can sometimes help the labels better visually group with corresponding axis ticks.
    ///
    /// __Default value:__ `true` for axis of a continuous x-scale. Otherwise, `false`.
    /// </summary>
    public struct Label
    {
        public bool? Bool;
        public double? Double;

        public static implicit operator Label(bool @bool) => new Label { Bool = @bool };
        public static implicit operator Label(double @double) => new Label { Double = @double };
    }

    public struct ConditionalAxisPropertyStringNullCondition
    {
        public ConditionalPredicateStringValueDef ConditionalPredicateStringValueDef;
        public List<ConditionalPredicateStringValueDef> ConditionalPredicateStringValueDefArray;

        public static implicit operator ConditionalAxisPropertyStringNullCondition(ConditionalPredicateStringValueDef conditionalPredicateStringValueDef) => new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDef = conditionalPredicateStringValueDef };
        public static implicit operator ConditionalAxisPropertyStringNullCondition(List<ConditionalPredicateStringValueDef> conditionalPredicateStringValueDefArray) => new ConditionalAxisPropertyStringNullCondition { ConditionalPredicateStringValueDefArray = conditionalPredicateStringValueDefArray };
    }

    public struct LabelFont
    {
        public ConditionalAxisPropertyStringNull ConditionalAxisPropertyStringNull;
        public string String;

        public static implicit operator LabelFont(ConditionalAxisPropertyStringNull conditionalAxisPropertyStringNull) => new LabelFont { ConditionalAxisPropertyStringNull = conditionalAxisPropertyStringNull };
        public static implicit operator LabelFont(string @string) => new LabelFont { String = @string };
    }

    public struct ConditionalAxisPropertyFontStyleNullCondition
    {
        public ConditionalPredicateValueDefFontStyleNull ConditionalPredicateValueDefFontStyleNull;
        public List<ConditionalPredicateValueDefFontStyleNull> ConditionalPredicateValueDefFontStyleNullArray;

        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(ConditionalPredicateValueDefFontStyleNull conditionalPredicateValueDefFontStyleNull) => new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNull = conditionalPredicateValueDefFontStyleNull };
        public static implicit operator ConditionalAxisPropertyFontStyleNullCondition(List<ConditionalPredicateValueDefFontStyleNull> conditionalPredicateValueDefFontStyleNullArray) => new ConditionalAxisPropertyFontStyleNullCondition { ConditionalPredicateValueDefFontStyleNullArray = conditionalPredicateValueDefFontStyleNullArray };
    }

    public struct LabelFontStyle
    {
        public ConditionalAxisPropertyFontStyleNull ConditionalAxisPropertyFontStyleNull;
        public string String;

        public static implicit operator LabelFontStyle(ConditionalAxisPropertyFontStyleNull conditionalAxisPropertyFontStyleNull) => new LabelFontStyle { ConditionalAxisPropertyFontStyleNull = conditionalAxisPropertyFontStyleNull };
        public static implicit operator LabelFontStyle(string @string) => new LabelFontStyle { String = @string };
    }

    public struct ConditionalPredicateValueDefFontWeightNullValue
    {
        public double? Double;
        public PurpleFontWeight? Enum;

        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(double @double) => new ConditionalPredicateValueDefFontWeightNullValue { Double = @double };
        public static implicit operator ConditionalPredicateValueDefFontWeightNullValue(PurpleFontWeight @enum) => new ConditionalPredicateValueDefFontWeightNullValue { Enum = @enum };
        public bool IsNull => Double == null && Enum == null;
    }

    public struct ConditionalAxisPropertyFontWeightNullCondition
    {
        public ConditionalPredicateValueDefFontWeightNull ConditionalPredicateValueDefFontWeightNull;
        public List<ConditionalPredicateValueDefFontWeightNull> ConditionalPredicateValueDefFontWeightNullArray;

        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(ConditionalPredicateValueDefFontWeightNull conditionalPredicateValueDefFontWeightNull) => new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNull = conditionalPredicateValueDefFontWeightNull };
        public static implicit operator ConditionalAxisPropertyFontWeightNullCondition(List<ConditionalPredicateValueDefFontWeightNull> conditionalPredicateValueDefFontWeightNullArray) => new ConditionalAxisPropertyFontWeightNullCondition { ConditionalPredicateValueDefFontWeightNullArray = conditionalPredicateValueDefFontWeightNullArray };
    }

    public struct LabelFontWeightUnion
    {
        public ConditionalAxisPropertyFontWeightNull ConditionalAxisPropertyFontWeightNull;
        public double? Double;
        public PurpleFontWeight? Enum;

        public static implicit operator LabelFontWeightUnion(ConditionalAxisPropertyFontWeightNull conditionalAxisPropertyFontWeightNull) => new LabelFontWeightUnion { ConditionalAxisPropertyFontWeightNull = conditionalAxisPropertyFontWeightNull };
        public static implicit operator LabelFontWeightUnion(double @double) => new LabelFontWeightUnion { Double = @double };
        public static implicit operator LabelFontWeightUnion(PurpleFontWeight @enum) => new LabelFontWeightUnion { Enum = @enum };
    }

    public struct Keyvals
    {
        public List<object> AnythingArray;
        public ImputeSequence ImputeSequence;

        public static implicit operator Keyvals(List<object> anythingArray) => new Keyvals { AnythingArray = anythingArray };
        public static implicit operator Keyvals(ImputeSequence imputeSequence) => new Keyvals { ImputeSequence = imputeSequence };
    }

    /// <summary>
    /// Type of stacking offset if the field should be stacked.
    /// `stack` is only applicable for `x` and `y` channels with continuous domains.
    /// For example, `stack` of `y` can be used to customize stacking for a vertical bar chart.
    ///
    /// `stack` can be one of the following values:
    /// - `"zero"` or `true`: stacking with baseline offset at zero value of the scale (for
    /// creating typical stacked [bar](https://vega.github.io/vega-lite/docs/stack.html#bar) and
    /// [area](https://vega.github.io/vega-lite/docs/stack.html#area) chart).
    /// - `"normalize"` - stacking with normalized domain (for creating [normalized stacked bar
    /// and area charts](https://vega.github.io/vega-lite/docs/stack.html#normalized). <br/>
    /// -`"center"` - stacking with center baseline (for
    /// [streamgraph](https://vega.github.io/vega-lite/docs/stack.html#streamgraph)).
    /// - `null` or `false` - No-stacking. This will produce layered
    /// [bar](https://vega.github.io/vega-lite/docs/stack.html#layered-bar-chart) and area
    /// chart.
    ///
    /// __Default value:__ `zero` for plots with all of the following conditions are true:
    /// (1) the mark is `bar` or `area`;
    /// (2) the stacked measure channel (x or y) has a linear scale;
    /// (3) At least one of non-position channels mapped to an unaggregated field that is
    /// different from x and y. Otherwise, `null` by default.
    ///
    /// __See also:__ [`stack`](https://vega.github.io/vega-lite/docs/stack.html) documentation.
    /// </summary>
    public struct Stack
    {
        public bool? Bool;
        public StackOffset? Enum;

        public static implicit operator Stack(bool @bool) => new Stack { Bool = @bool };
        public static implicit operator Stack(StackOffset @enum) => new Stack { Enum = @enum };
        public bool IsNull => Bool == null && Enum == null;
    }

    public struct XUnion
    {
        public double? Double;
        public ValueWidthEnum? Enum;

        public static implicit operator XUnion(double @double) => new XUnion { Double = @double };
        public static implicit operator XUnion(ValueWidthEnum @enum) => new XUnion { Enum = @enum };
    }

    public struct YUnion
    {
        public double? Double;
        public ValueHeightEnum? Enum;

        public static implicit operator YUnion(double @double) => new YUnion { Double = @double };
        public static implicit operator YUnion(ValueHeightEnum @enum) => new YUnion { Enum = @enum };
    }

    public struct HeightUnion
    {
        public double? Double;
        public HeightEnum? Enum;
        public Step Step;

        public static implicit operator HeightUnion(double @double) => new HeightUnion { Double = @double };
        public static implicit operator HeightUnion(HeightEnum @enum) => new HeightUnion { Enum = @enum };
        public static implicit operator HeightUnion(Step step) => new HeightUnion { Step = step };
    }

    /// <summary>
    /// Default color.
    ///
    /// __Default value:__ <span style="color: #4682b4;">&#9632;</span> `"#4682b4"`
    ///
    /// __Note:__
    /// - This property cannot be used in a [style
    /// config](https://vega.github.io/vega-lite/docs/mark.html#style-config).
    /// - The `fill` and `stroke` properties have higher precedence than `color` and will
    /// override `color`.
    /// </summary>
    public struct ColorUnion
    {
        public ColorLinearGradient ColorLinearGradient;
        public string String;

        public static implicit operator ColorUnion(ColorLinearGradient colorLinearGradient) => new ColorUnion { ColorLinearGradient = colorLinearGradient };
        public static implicit operator ColorUnion(string @string) => new ColorUnion { String = @string };
    }

    public struct FillUnion
    {
        public FillLinearGradient FillLinearGradient;
        public string String;

        public static implicit operator FillUnion(FillLinearGradient fillLinearGradient) => new FillUnion { FillLinearGradient = fillLinearGradient };
        public static implicit operator FillUnion(string @string) => new FillUnion { String = @string };
        public bool IsNull => FillLinearGradient == null && String == null;
    }

    public struct Value
    {
        public bool? Bool;
        public double? Double;
        public string String;
        public TooltipContent TooltipContent;

        public static implicit operator Value(bool @bool) => new Value { Bool = @bool };
        public static implicit operator Value(double @double) => new Value { Double = @double };
        public static implicit operator Value(string @string) => new Value { String = @string };
        public static implicit operator Value(TooltipContent tooltipContent) => new Value { TooltipContent = tooltipContent };
        public bool IsNull => Bool == null && TooltipContent == null && Double == null && String == null;
    }

    public struct Box
    {
        public bool? Bool;
        public MarkConfig MarkConfig;

        public static implicit operator Box(bool @bool) => new Box { Bool = @bool };
        public static implicit operator Box(MarkConfig markConfig) => new Box { MarkConfig = markConfig };
    }

    public struct BoxPlotDefExtent
    {
        public double? Double;
        public ExtentExtent? Enum;

        public static implicit operator BoxPlotDefExtent(double @double) => new BoxPlotDefExtent { Double = @double };
        public static implicit operator BoxPlotDefExtent(ExtentExtent @enum) => new BoxPlotDefExtent { Enum = @enum };
    }

    public struct Line
    {
        public bool? Bool;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator Line(bool @bool) => new Line { Bool = @bool };
        public static implicit operator Line(OverlayMarkDef overlayMarkDef) => new Line { OverlayMarkDef = overlayMarkDef };
    }

    public struct PointUnion
    {
        public bool? Bool;
        public PointEnum? Enum;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator PointUnion(bool @bool) => new PointUnion { Bool = @bool };
        public static implicit operator PointUnion(PointEnum @enum) => new PointUnion { Enum = @enum };
        public static implicit operator PointUnion(OverlayMarkDef overlayMarkDef) => new PointUnion { OverlayMarkDef = overlayMarkDef };
    }

    /// <summary>
    /// A string describing the mark type (one of `"bar"`, `"circle"`, `"square"`, `"tick"`,
    /// `"line"`,
    /// `"area"`, `"point"`, `"rule"`, `"geoshape"`, and `"text"`) or a [mark definition
    /// object](https://vega.github.io/vega-lite/docs/mark.html#mark-def).
    /// </summary>
    public struct AnyMark
    {
        public BoxPlotDefClass BoxPlotDefClass;
        public BoxPlot? Enum;

        public static implicit operator AnyMark(BoxPlotDefClass boxPlotDefClass) => new AnyMark { BoxPlotDefClass = boxPlotDefClass };
        public static implicit operator AnyMark(BoxPlot @enum) => new AnyMark { Enum = @enum };
    }

    public struct PurpleStream
    {
        public List<object> AnythingArray;
        public double? Double;
        public PurpleBinding PurpleBinding;
        public string String;

        public static implicit operator PurpleStream(List<object> anythingArray) => new PurpleStream { AnythingArray = anythingArray };
        public static implicit operator PurpleStream(double @double) => new PurpleStream { Double = @double };
        public static implicit operator PurpleStream(PurpleBinding purpleBinding) => new PurpleStream { PurpleBinding = purpleBinding };
        public static implicit operator PurpleStream(string @string) => new PurpleStream { String = @string };
    }

    public struct BindUnion
    {
        public Dictionary<string, PurpleStream> AnythingMap;
        public PurpleLegendBinding? Enum;

        public static implicit operator BindUnion(Dictionary<string, PurpleStream> anythingMap) => new BindUnion { AnythingMap = anythingMap };
        public static implicit operator BindUnion(PurpleLegendBinding @enum) => new BindUnion { Enum = @enum };
    }

    public struct ClearUnion
    {
        public bool? Bool;
        public ClearDerivedStream ClearDerivedStream;
        public string String;

        public static implicit operator ClearUnion(bool @bool) => new ClearUnion { Bool = @bool };
        public static implicit operator ClearUnion(ClearDerivedStream clearDerivedStream) => new ClearUnion { ClearDerivedStream = clearDerivedStream };
        public static implicit operator ClearUnion(string @string) => new ClearUnion { String = @string };
    }

    public struct SelectionInit
    {
        public bool? Bool;
        public DateTime DateTime;
        public double? Double;
        public string String;

        public static implicit operator SelectionInit(bool @bool) => new SelectionInit { Bool = @bool };
        public static implicit operator SelectionInit(DateTime dateTime) => new SelectionInit { DateTime = dateTime };
        public static implicit operator SelectionInit(double @double) => new SelectionInit { Double = @double };
        public static implicit operator SelectionInit(string @string) => new SelectionInit { String = @string };
        public bool IsNull => Bool == null && DateTime == null && Double == null && String == null;
    }

    public struct InitValue
    {
        public List<Equal> AnythingArray;
        public bool? Bool;
        public DateTime DateTime;
        public double? Double;
        public string String;

        public static implicit operator InitValue(List<Equal> anythingArray) => new InitValue { AnythingArray = anythingArray };
        public static implicit operator InitValue(bool @bool) => new InitValue { Bool = @bool };
        public static implicit operator InitValue(DateTime dateTime) => new InitValue { DateTime = dateTime };
        public static implicit operator InitValue(double @double) => new InitValue { Double = @double };
        public static implicit operator InitValue(string @string) => new InitValue { String = @string };
        public bool IsNull => AnythingArray == null && Bool == null && DateTime == null && Double == null && String == null;
    }

    public struct Init
    {
        public Dictionary<string, InitValue> AnythingMap;
        public List<Dictionary<string, SelectionInit>> AnythingMapArray;

        public static implicit operator Init(Dictionary<string, InitValue> anythingMap) => new Init { AnythingMap = anythingMap };
        public static implicit operator Init(List<Dictionary<string, SelectionInit>> anythingMapArray) => new Init { AnythingMapArray = anythingMapArray };
    }

    public struct OnUnion
    {
        public OnDerivedStream OnDerivedStream;
        public string String;

        public static implicit operator OnUnion(OnDerivedStream onDerivedStream) => new OnUnion { OnDerivedStream = onDerivedStream };
        public static implicit operator OnUnion(string @string) => new OnUnion { String = @string };
    }

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
        public bool? Bool;
        public string String;

        public static implicit operator Translate(bool @bool) => new Translate { Bool = @bool };
        public static implicit operator Translate(string @string) => new Translate { String = @string };
    }

    /// <summary>
    /// Title for the plot.
    /// </summary>
    public struct LayerTitle
    {
        public string String;
        public List<string> StringArray;
        public TitleParams TitleParams;

        public static implicit operator LayerTitle(string @string) => new LayerTitle { String = @string };
        public static implicit operator LayerTitle(List<string> stringArray) => new LayerTitle { StringArray = stringArray };
        public static implicit operator LayerTitle(TitleParams titleParams) => new LayerTitle { TitleParams = titleParams };
    }

    /// <summary>
    /// An object indicating bin properties, or simply `true` for using default bin parameters.
    /// </summary>
    public struct TransformBin
    {
        public BinParams BinParams;
        public bool? Bool;

        public static implicit operator TransformBin(BinParams binParams) => new TransformBin { BinParams = binParams };
        public static implicit operator TransformBin(bool @bool) => new TransformBin { Bool = @bool };
    }

    /// <summary>
    /// Definition for fields to be repeated. One of:
    /// 1) An array of fields to be repeated. If `"repeat"` is an array, the field can be
    /// referred using `{"repeat": "repeat"}`
    /// 2) An object that mapped `"row"` and/or `"column"` to the listed of fields to be repeated
    /// along the particular orientations. The objects `{"repeat": "row"}` and `{"repeat":
    /// "column"}` can be used to refer to the repeated field respectively.
    /// </summary>
    public struct RepeatUnion
    {
        public RepeatMapping RepeatMapping;
        public List<string> StringArray;

        public static implicit operator RepeatUnion(RepeatMapping repeatMapping) => new RepeatUnion { RepeatMapping = repeatMapping };
        public static implicit operator RepeatUnion(List<string> stringArray) => new RepeatUnion { StringArray = stringArray };
    }

    /// <summary>
    /// The extent of the whiskers. Available options include:
    /// - `"min-max"`: min and max are the lower and upper whiskers respectively.
    /// - A number representing multiple of the interquartile range. This number will be
    /// multiplied by the IQR to determine whisker boundary, which spans from the smallest data
    /// to the largest data within the range _[Q1 - k * IQR, Q3 + k * IQR]_ where _Q1_ and _Q3_
    /// are the first and third quartiles while _IQR_ is the interquartile range (_Q3-Q1_).
    ///
    /// __Default value:__ `1.5`.
    /// </summary>
    public struct BoxplotExtent
    {
        public double? Double;
        public ExtentEnum? Enum;

        public static implicit operator BoxplotExtent(double @double) => new BoxplotExtent { Double = @double };
        public static implicit operator BoxplotExtent(ExtentEnum @enum) => new BoxplotExtent { Enum = @enum };
    }

    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
    public struct AnchorUnion
    {
        public TitleAnchorEnum? Enum;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator AnchorUnion(TitleAnchorEnum @enum) => new AnchorUnion { Enum = @enum };
        public static implicit operator AnchorUnion(PurpleSignalRef purpleSignalRef) => new AnchorUnion { PurpleSignalRef = purpleSignalRef };
        public bool IsNull => PurpleSignalRef == null && Enum == null;
    }

    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
    public struct LayoutBounds
    {
        public BoundsEnum? Enum;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator LayoutBounds(BoundsEnum @enum) => new LayoutBounds { Enum = @enum };
        public static implicit operator LayoutBounds(PurpleSignalRef purpleSignalRef) => new LayoutBounds { PurpleSignalRef = purpleSignalRef };
    }

    public struct BottomCenter
    {
        public bool? Bool;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator BottomCenter(bool @bool) => new BottomCenter { Bool = @bool };
        public static implicit operator BottomCenter(PurpleSignalRef purpleSignalRef) => new BottomCenter { PurpleSignalRef = purpleSignalRef };
    }

    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
    public struct Direction
    {
        public Orientation? Enum;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator Direction(Orientation @enum) => new Direction { Enum = @enum };
        public static implicit operator Direction(PurpleSignalRef purpleSignalRef) => new Direction { PurpleSignalRef = purpleSignalRef };
    }

    public struct RangeRawArray
    {
        public double? Double;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator RangeRawArray(double @double) => new RangeRawArray { Double = @double };
        public static implicit operator RangeRawArray(PurpleSignalRef purpleSignalRef) => new RangeRawArray { PurpleSignalRef = purpleSignalRef };
    }

    /// <summary>
    /// The default visualization padding, in pixels, from the edge of the visualization canvas
    /// to the data rectangle. If a number, specifies padding for all sides.
    /// If an object, the value should have the format `{"left": 5, "top": 5, "right": 5,
    /// "bottom": 5}` to specify padding for each side of the visualization.
    ///
    /// __Default value__: `5`
    /// </summary>
    public struct Padding
    {
        public double? Double;
        public PaddingClass PaddingClass;

        public static implicit operator Padding(double @double) => new Padding { Double = @double };
        public static implicit operator Padding(PaddingClass paddingClass) => new Padding { PaddingClass = paddingClass };
    }

    public struct RangeRaw
    {
        public List<RangeRawArray> AnythingArray;
        public bool? Bool;
        public double? Double;
        public PurpleSignalRef PurpleSignalRef;
        public string String;

        public static implicit operator RangeRaw(List<RangeRawArray> anythingArray) => new RangeRaw { AnythingArray = anythingArray };
        public static implicit operator RangeRaw(bool @bool) => new RangeRaw { Bool = @bool };
        public static implicit operator RangeRaw(double @double) => new RangeRaw { Double = @double };
        public static implicit operator RangeRaw(PurpleSignalRef purpleSignalRef) => new RangeRaw { PurpleSignalRef = purpleSignalRef };
        public static implicit operator RangeRaw(string @string) => new RangeRaw { String = @string };
        public bool IsNull => AnythingArray == null && Bool == null && PurpleSignalRef == null && Double == null && String == null;
    }

    public struct SignalRefExtent
    {
        public List<RangeRawArray> AnythingArray;
        public PurpleSignalRef PurpleSignalRef;

        public static implicit operator SignalRefExtent(List<RangeRawArray> anythingArray) => new SignalRefExtent { AnythingArray = anythingArray };
        public static implicit operator SignalRefExtent(PurpleSignalRef purpleSignalRef) => new SignalRefExtent { PurpleSignalRef = purpleSignalRef };
    }

    public struct ColorScheme
    {
        public PurpleSignalRef PurpleSignalRef;
        public string String;
        public List<string> StringArray;

        public static implicit operator ColorScheme(PurpleSignalRef purpleSignalRef) => new ColorScheme { PurpleSignalRef = purpleSignalRef };
        public static implicit operator ColorScheme(string @string) => new ColorScheme { String = @string };
        public static implicit operator ColorScheme(List<string> stringArray) => new ColorScheme { StringArray = stringArray };
    }

    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
    /// </summary>
    public struct CategoryUnion
    {
        public List<RangeRaw> AnythingArray;
        public CategorySignalRef CategorySignalRef;
        public RangeEnum? Enum;

        public static implicit operator CategoryUnion(List<RangeRaw> anythingArray) => new CategoryUnion { AnythingArray = anythingArray };
        public static implicit operator CategoryUnion(CategorySignalRef categorySignalRef) => new CategoryUnion { CategorySignalRef = categorySignalRef };
        public static implicit operator CategoryUnion(RangeEnum @enum) => new CategoryUnion { Enum = @enum };
    }

    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for diverging
    /// quantitative ramps.
    /// </summary>
    public struct DivergingUnion
    {
        public List<RangeRaw> AnythingArray;
        public DivergingSignalRef DivergingSignalRef;
        public RangeEnum? Enum;

        public static implicit operator DivergingUnion(List<RangeRaw> anythingArray) => new DivergingUnion { AnythingArray = anythingArray };
        public static implicit operator DivergingUnion(DivergingSignalRef divergingSignalRef) => new DivergingUnion { DivergingSignalRef = divergingSignalRef };
        public static implicit operator DivergingUnion(RangeEnum @enum) => new DivergingUnion { Enum = @enum };
    }

    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for quantitative
    /// heatmaps.
    /// </summary>
    public struct HeatmapUnion
    {
        public List<RangeRaw> AnythingArray;
        public RangeEnum? Enum;
        public HeatmapSignalRef HeatmapSignalRef;

        public static implicit operator HeatmapUnion(List<RangeRaw> anythingArray) => new HeatmapUnion { AnythingArray = anythingArray };
        public static implicit operator HeatmapUnion(RangeEnum @enum) => new HeatmapUnion { Enum = @enum };
        public static implicit operator HeatmapUnion(HeatmapSignalRef heatmapSignalRef) => new HeatmapUnion { HeatmapSignalRef = heatmapSignalRef };
    }

    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
    /// </summary>
    public struct OrdinalUnion
    {
        public List<RangeRaw> AnythingArray;
        public RangeEnum? Enum;
        public OrdinalSignalRef OrdinalSignalRef;

        public static implicit operator OrdinalUnion(List<RangeRaw> anythingArray) => new OrdinalUnion { AnythingArray = anythingArray };
        public static implicit operator OrdinalUnion(RangeEnum @enum) => new OrdinalUnion { Enum = @enum };
        public static implicit operator OrdinalUnion(OrdinalSignalRef ordinalSignalRef) => new OrdinalUnion { OrdinalSignalRef = ordinalSignalRef };
    }

    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for sequential
    /// quantitative ramps.
    /// </summary>
    public struct RampUnion
    {
        public List<RangeRaw> AnythingArray;
        public RangeEnum? Enum;
        public RampSignalRef RampSignalRef;

        public static implicit operator RampUnion(List<RangeRaw> anythingArray) => new RampUnion { AnythingArray = anythingArray };
        public static implicit operator RampUnion(RangeEnum @enum) => new RampUnion { Enum = @enum };
        public static implicit operator RampUnion(RampSignalRef rampSignalRef) => new RampUnion { RampSignalRef = rampSignalRef };
    }

    /// <summary>
    /// When set, a selection is populated by interacting with the corresponding legend. Direct
    /// manipulation interaction is disabled by default;
    /// to re-enable it, set the selection's
    /// [`on`](https://vega.github.io/vega-lite/docs/selection.html#common-selection-properties)
    /// property.
    ///
    /// Legend bindings are restricted to selections that only specify a single field or encoding.
    /// </summary>
    public struct LegendBinding
    {
        public LegendBindingEnum? Enum;
        public LegendStreamBinding LegendStreamBinding;

        public static implicit operator LegendBinding(LegendBindingEnum @enum) => new LegendBinding { Enum = @enum };
        public static implicit operator LegendBinding(LegendStreamBinding legendStreamBinding) => new LegendBinding { LegendStreamBinding = legendStreamBinding };
    }

    public struct FluffyStream
    {
        public List<object> AnythingArray;
        public double? Double;
        public FluffyBinding FluffyBinding;
        public string String;

        public static implicit operator FluffyStream(List<object> anythingArray) => new FluffyStream { AnythingArray = anythingArray };
        public static implicit operator FluffyStream(double @double) => new FluffyStream { Double = @double };
        public static implicit operator FluffyStream(FluffyBinding fluffyBinding) => new FluffyStream { FluffyBinding = fluffyBinding };
        public static implicit operator FluffyStream(string @string) => new FluffyStream { String = @string };
    }

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
        public Dictionary<string, FluffyStream> AnythingMap;
        public LegendBindingEnum? Enum;

        public static implicit operator Binding(Dictionary<string, FluffyStream> anythingMap) => new Binding { AnythingMap = anythingMap };
        public static implicit operator Binding(LegendBindingEnum @enum) => new Binding { Enum = @enum };
    }

    /// <summary>
    /// The default height when the plot has either a discrete y-field or no y-field.
    ///
    /// __Default value:__ a step size based on `config.view.step`.
    /// </summary>
    public struct DiscreteHeightUnion
    {
        public DiscreteHeightClass DiscreteHeightClass;
        public double? Double;

        public static implicit operator DiscreteHeightUnion(DiscreteHeightClass discreteHeightClass) => new DiscreteHeightUnion { DiscreteHeightClass = discreteHeightClass };
        public static implicit operator DiscreteHeightUnion(double @double) => new DiscreteHeightUnion { Double = @double };
    }

    /// <summary>
    /// The default width when the plot has either a discrete x-field or no x-field.
    ///
    /// __Default value:__ a step size based on `config.view.step`.
    /// </summary>
    public struct DiscreteWidthUnion
    {
        public DiscreteWidthClass DiscreteWidthClass;
        public double? Double;

        public static implicit operator DiscreteWidthUnion(DiscreteWidthClass discreteWidthClass) => new DiscreteWidthUnion { DiscreteWidthClass = discreteWidthClass };
        public static implicit operator DiscreteWidthUnion(double @double) => new DiscreteWidthUnion { Double = @double };
    }
}
