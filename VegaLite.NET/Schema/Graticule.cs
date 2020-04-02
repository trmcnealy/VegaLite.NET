namespace VegaLite.Schema
{
    /// <summary>
    /// Generate graticule GeoJSON data for geographic reference lines.
    /// </summary>
    public struct Graticule
    {
        public bool?           Bool;
        public GraticuleParams GraticuleParams;

        public static implicit operator Graticule(bool @bool)
        {
            return new Graticule
            {
                Bool = @bool
            };
        }

        public static implicit operator Graticule(GraticuleParams graticuleParams)
        {
            return new Graticule
            {
                GraticuleParams = graticuleParams
            };
        }
    }
}
