using WargamingApi.Types;

namespace Wargaming_Net.Types.Wgtv
{
    public class WgtvMeta : Meta
    {
        public ulong page_total { get; set; }
        public ulong limit { get; set; }
        public ulong page { get; set; }
    }
}