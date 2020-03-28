namespace VegaLite
{
    /// <summary>
    /// Generate sphere GeoJSON data for the full globe.
    /// </summary>
    public struct SphereUnion
    {
        public bool?       Bool;
        public SphereClass SphereClass;

        public static implicit operator SphereUnion(bool        @bool)        => new SphereUnion { Bool        = @bool };
        public static implicit operator SphereUnion(SphereClass sphereClass) => new SphereUnion { SphereClass = sphereClass };
    }
}