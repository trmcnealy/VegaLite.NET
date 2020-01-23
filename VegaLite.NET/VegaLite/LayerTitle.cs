using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// Title for the plot.
    /// </summary>
    public struct LayerTitle
    {
        public string       String;
        public List<string> StringArray;
        public TitleParams  TitleParams;

        public static implicit operator LayerTitle(string       String)      => new LayerTitle { String      = String };
        public static implicit operator LayerTitle(List<string> StringArray) => new LayerTitle { StringArray = StringArray };
        public static implicit operator LayerTitle(TitleParams  TitleParams) => new LayerTitle { TitleParams = TitleParams };
    }
}