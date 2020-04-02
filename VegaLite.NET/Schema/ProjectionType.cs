namespace VegaLite.Schema
{
    /// <summary>
    /// The cartographic projection to use. This value is case-insensitive, for example
    /// `"albers"` and `"Albers"` indicate the same projection type. You can find all valid
    /// projection types [in the
    /// documentation](https://vega.github.io/vega-lite/docs/projection.html#projection-types).
    ///
    /// __Default value:__ `mercator`
    /// </summary>
    public enum ProjectionType
    {
        Albers,
        AlbersUsa,
        AzimuthalEqualArea,
        AzimuthalEquidistant,
        ConicConformal,
        ConicEqualArea,
        ConicEquidistant,
        EqualEarth,
        Equirectangular,
        Gnomonic,
        Identity,
        Mercator,
        NaturalEarth1,
        Orthographic,
        Stereographic,
        TransverseMercator
    };
}
