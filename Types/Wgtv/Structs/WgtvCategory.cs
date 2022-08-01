using Newtonsoft.Json;

namespace Wargaming_Net.Types.Wgtv.Structs
{
    public struct WgtvCategory
    {
        public string Name { get; set; }
        public ulong Order { get; set; }

        [JsonProperty("category_id")] public ulong CategoryId { get; set; }
    }
}