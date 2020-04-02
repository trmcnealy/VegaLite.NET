namespace VegaLite.Schema
{
    /// <summary>
    /// Generate sphere GeoJSON data for the full globe.
    /// </summary>
    public struct SphereUnion
    {
        public bool?       Bool;
        public SphereClass SphereClass;

        public static implicit operator SphereUnion(bool @bool)
        {
            return new SphereUnion
            {
                Bool = @bool
            };
        }

        public static implicit operator SphereUnion(SphereClass sphereClass)
        {
            return new SphereUnion
            {
                SphereClass = sphereClass
            };
        }
    }
}
