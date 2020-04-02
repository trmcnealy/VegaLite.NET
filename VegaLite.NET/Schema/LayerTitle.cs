using System.Collections.Generic;

namespace VegaLite.Schema
{
    /// <summary>
    /// Title for the plot.
    /// </summary>
    public struct LayerTitle
    {
        public string       String;
        public List<string> StringArray;
        public TitleParams  TitleParams;

        public static implicit operator LayerTitle(string @string)
        {
            return new LayerTitle
            {
                String = @string
            };
        }

        public static implicit operator LayerTitle(List<string> stringArray)
        {
            return new LayerTitle
            {
                StringArray = stringArray
            };
        }

        public static implicit operator LayerTitle(TitleParams titleParams)
        {
            return new LayerTitle
            {
                TitleParams = titleParams
            };
        }
    }
}
