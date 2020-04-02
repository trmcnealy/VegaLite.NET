namespace VegaLite.Schema
{
    public struct Line
    {
        public bool?          Bool;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator Line(bool @bool)
        {
            return new Line
            {
                Bool = @bool
            };
        }

        public static implicit operator Line(OverlayMarkDef overlayMarkDef)
        {
            return new Line
            {
                OverlayMarkDef = overlayMarkDef
            };
        }
    }
}
