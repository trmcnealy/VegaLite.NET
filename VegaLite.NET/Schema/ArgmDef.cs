﻿using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public class ArgmDef
    {
        [JsonProperty("argmax",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Argmax { get; set; }

        [JsonProperty("argmin",
                      NullValueHandling = NullValueHandling.Ignore)]
        public string Argmin { get; set; }
    }
}
