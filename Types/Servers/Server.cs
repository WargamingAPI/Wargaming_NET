using Newtonsoft.Json;

namespace Wargaming_Net.Types.Servers
{
    public struct Server
    {
        [JsonProperty("players_online")] public long PlayersOnline { get; set; }

        [JsonProperty("server")] public string ServerName { get; set; }
    }
}