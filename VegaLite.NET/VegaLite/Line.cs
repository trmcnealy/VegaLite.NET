namespace VegaLite
{
    public struct Line
    {
        public bool?          Bool;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator Line(bool           @bool)           => new Line { Bool           = @bool };
        public static implicit operator Line(OverlayMarkDef overlayMarkDef) => new Line { OverlayMarkDef = overlayMarkDef };
    }
}