using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VegaLite
{
    public struct ScatterPlotData
    {
        [JsonProperty("X",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public double X { get; set; }

        [JsonProperty("Y",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public double Y { get; set; }

        public ScatterPlotData(double x,
                               double y)
        {
            X = x;
            Y = y;
        }
    }
}
