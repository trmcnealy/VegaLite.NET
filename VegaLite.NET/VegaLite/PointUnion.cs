namespace VegaLite
{
    public struct PointUnion
    {
        public bool?          Bool;
        public PointEnum?     Enum;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator PointUnion(bool           Bool)           => new PointUnion { Bool           = Bool };
        public static implicit operator PointUnion(PointEnum      Enum)           => new PointUnion { Enum           = Enum };
        public static implicit operator PointUnion(OverlayMarkDef OverlayMarkDef) => new PointUnion { OverlayMarkDef = OverlayMarkDef };
    }
}