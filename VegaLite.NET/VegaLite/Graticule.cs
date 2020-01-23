namespace VegaLite
{
    /// <summary>
    /// Generate graticule GeoJSON data for geographic reference lines.
    /// </summary>
    public struct Graticule
    {
        public bool?           Bool;
        public GraticuleParams GraticuleParams;

        public static implicit operator Graticule(bool            Bool)            => new Graticule { Bool            = Bool };
        public static implicit operator Graticule(GraticuleParams GraticuleParams) => new Graticule { GraticuleParams = GraticuleParams };
    }
}