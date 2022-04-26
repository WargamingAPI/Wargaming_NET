using Newtonsoft.Json;

namespace Wargaming_Net.Types.Wgtv
{
    public struct Program
    {
        public string Name { get; set; }

        public ulong Order { get; set; }

        [JsonProperty("program_id")] public ulong ProgramId { get; set; }
    }
}