using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite
{
    public class PurpleBinding
    {
        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("element", NullValueHandling = NullValueHandling.Ignore)]
        public string Element { get; set; }

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public string Input { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Options { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        [JsonProperty("autocomplete", NullValueHandling = NullValueHandling.Ignore)]
        public string Autocomplete { get; set; }

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

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

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public Stream Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stream> Merge { get; set; }
    }
}