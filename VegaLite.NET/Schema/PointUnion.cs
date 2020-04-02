namespace VegaLite.Schema
{
    public struct PointUnion
    {
        public bool?          Bool;
        public PointEnum?     Enum;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator PointUnion(bool @bool)
        {
            return new PointUnion
            {
                Bool = @bool
            };
        }

        public static implicit operator PointUnion(PointEnum @enum)
        {
            return new PointUnion
            {
                Enum = @enum
            };
        }

        public static implicit operator PointUnion(OverlayMarkDef overlayMarkDef)
        {
            return new PointUnion
            {
                OverlayMarkDef = overlayMarkDef
            };
        }
    }
}
