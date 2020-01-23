using System.Collections.Generic;

namespace VegaLite
{
    /// <summary>
    /// A two-element (`[min, max]`) array indicating the range of desired bin values.
    /// </summary>
    public struct BinExtent
    {
        public BinExtentClass BinExtentClass;
        public List<double>   DoubleArray;

        public static implicit operator BinExtent(BinExtentClass BinExtentClass) => new BinExtent { BinExtentClass = BinExtentClass };
        public static implicit operator BinExtent(List<double>   DoubleArray)    => new BinExtent { DoubleArray    = DoubleArray };
    }
}