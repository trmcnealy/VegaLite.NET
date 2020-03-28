namespace VegaLite
{
    public struct PointUnion
    {
        public bool?          Bool;
        public PointEnum?     Enum;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator PointUnion(bool           @bool)           => new PointUnion { Bool           = @bool };
        public static implicit operator PointUnion(PointEnum      @enum)           => new PointUnion { Enum           = @enum };
        public static implicit operator PointUnion(OverlayMarkDef overlayMarkDef) => new PointUnion { OverlayMarkDef = overlayMarkDef };
    }
}