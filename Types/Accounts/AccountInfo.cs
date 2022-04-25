#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types.Accounts
{
    public struct AccountInfo
    {
        public ulong account_id { get; set; }
        public long created_at { get; set; }
        public string nickname { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? games { get; set; }
        //TODO: add private fields
        /*
         private		                                Приватные данные игрока
         private.free_xp	            numeric	        Количество свободного опыта
         private.gold	                numeric	        Текущий баланс золота
         private.premium_expires_at	    timestamp	    Срок действия премиум аккаунта
         */
    }
}