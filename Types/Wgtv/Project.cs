using Newtonsoft.Json;

namespace Wargaming_Net.Types.Wgtv
{
    public struct Project
    {
        public string Name { get; set; }

        public ulong Order { get; set; }

        [JsonProperty("project_id")] public ulong ProjectId { get; set; }
    }
}