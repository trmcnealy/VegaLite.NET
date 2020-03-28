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

        public static implicit operator LayerTitle(string       @string)      => new LayerTitle { String      = @string };
        public static implicit operator LayerTitle(List<string> stringArray) => new LayerTitle { StringArray = stringArray };
        public static implicit operator LayerTitle(TitleParams  titleParams) => new LayerTitle { TitleParams = titleParams };
    }
}