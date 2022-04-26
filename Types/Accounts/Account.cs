#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types.Accounts
{
    public class Account
    {
        public ulong account_id { get; set; }
        public long created_at { get; set; }
        public string nickname { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? games { get; set; }
    }
}