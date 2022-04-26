using Newtonsoft.Json;
using WargamingApi.Types;

namespace Wargaming_Net.Types.Wgtv
{
    public class WgtvMeta : Meta
    {
        [JsonProperty("page_total")] public ulong PageTotal { get; set; }

        public ulong Limit { get; set; }
        public ulong Page { get; set; }
    }
}