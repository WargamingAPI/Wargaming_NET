#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types.Accounts
{
    public class Account
    {
        [JsonProperty("account_id")] public ulong AccountId { get; set; }

        [JsonProperty("created_at")] public long CreatedAt { get; set; }

        public string Nickname { get; set; } = "";

        public IEnumerable<string>? Games { get; set; }
    }
}