using Newtonsoft.Json;

namespace VegaLite
{
    public static class Serialize
    {
        public static string ToJson(this Specification self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}