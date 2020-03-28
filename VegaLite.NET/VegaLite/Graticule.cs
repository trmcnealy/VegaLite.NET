namespace VegaLite
{
    /// <summary>
    /// Generate graticule GeoJSON data for geographic reference lines.
    /// </summary>
    public struct Graticule
    {
        public bool?           Bool;
        public GraticuleParams GraticuleParams;

        public static implicit operator Graticule(bool            @bool)            => new Graticule { Bool            = @bool };
        public static implicit operator Graticule(GraticuleParams graticuleParams) => new Graticule { GraticuleParams = graticuleParams };
    }
}