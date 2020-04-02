using System.Collections.Generic;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class Selection
    {
        [JsonProperty("not",
                      NullValueHandling = NullValueHandling.Ignore)]
        public SelectionOperand? Not { get; set; }

        [JsonProperty("and",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectionOperand> And { get; set; }

        [JsonProperty("or",
                      NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectionOperand> Or { get; set; }
    }
}
