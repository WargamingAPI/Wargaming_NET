using System.Collections.Generic;
using WargamingApi.Types;

namespace Wargaming_Net.Types.Accounts
{
    public class AccountInfo : Respond<Meta, Dictionary<ulong, Account?>>
    {
        //TODO: add private fields
        /*
         private		                                Приватные данные игрока
         private.free_xp	            numeric	        Количество свободного опыта
         private.gold	                numeric	        Текущий баланс золота
         private.premium_expires_at	    timestamp	    Срок действия премиум аккаунта
         */
    }
}