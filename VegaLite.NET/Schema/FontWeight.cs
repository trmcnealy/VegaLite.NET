namespace VegaLite.Schema
{
    /// <summary>
    /// The font weight.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight of axis tick labels.
    ///
    /// Font weight of the title.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight of the header title.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// The font weight of legend label.
    ///
    /// The font weight of the legend title.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight for title text.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    ///
    /// Font weight for subtitle text.
    /// This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`,
    /// ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
    /// </summary>
    public struct FontWeight
    {
        public double?         Double;
        public FontWeightEnum? Enum;

        public static implicit operator FontWeight(double @double)
        {
            return new FontWeight
            {
                Double = @double
            };
        }

        public static implicit operator FontWeight(FontWeightEnum @enum)
        {
            return new FontWeight
            {
                Enum = @enum
            };
        }
    }
}
