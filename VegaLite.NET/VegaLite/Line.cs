namespace VegaLite
{
    public struct Line
    {
        public bool?          Bool;
        public OverlayMarkDef OverlayMarkDef;

        public static implicit operator Line(bool           Bool)           => new Line { Bool           = Bool };
        public static implicit operator Line(OverlayMarkDef OverlayMarkDef) => new Line { OverlayMarkDef = OverlayMarkDef };
    }
}