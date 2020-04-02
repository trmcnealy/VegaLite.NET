using Newtonsoft.Json;

namespace VegaLite.Schema
{
    public static class Serialize
    {
        public static string ToJson(this Specification self)
        {
            return JsonConvert.SerializeObject(self,
                                               Converter.Settings);
        }
    }
}
