namespace VegaLite
{
    /// <summary>
    /// Generate sphere GeoJSON data for the full globe.
    /// </summary>
    public struct SphereUnion
    {
        public bool?       Bool;
        public SphereClass SphereClass;

        public static implicit operator SphereUnion(bool        Bool)        => new SphereUnion { Bool        = Bool };
        public static implicit operator SphereUnion(SphereClass SphereClass) => new SphereUnion { SphereClass = SphereClass };
    }
}