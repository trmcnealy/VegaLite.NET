using Newtonsoft.Json;

namespace VegaLite
{
    public partial class RowColLayoutAlign
    {
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutAlign? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutAlign? Row { get; set; }
    }
}