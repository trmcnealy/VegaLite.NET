using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    public class ClearDerivedStream
    {
        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public MarkType? Marktype { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source? Source { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }
}