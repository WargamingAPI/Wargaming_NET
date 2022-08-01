#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using Wargaming_Net.Types.Accounts;
using Wargaming_Net.Types.Enums;
using WargamingApi.Types;
using WargamingApi.Types.Enums;
using static WargamingApi.Types.Enums.Type;
using RequestArguments = Wargaming_Net.Types.RequestArguments;
using RequestParameters = Wargaming_Net.Types.RequestParameters;

namespace Wargaming_Net.Services
{
    public sealed class Accounts
    {
        private readonly WargamingNetClient m_client;

        public Accounts(WargamingNetClient client)
        {
            m_client = client;
        }

        public async Task<Respond<Meta, IEnumerable<Account>>> SearchAccounts(
            Regions region,
            string search,
            Language language = Language.En,
            Type type = StartsWith,
            byte? limit = null,
            IEnumerable<string>? fields = null,
            IEnumerable<string>? game = null
        )
        {
            return await m_client.GetRequest<Respond<Meta, IEnumerable<Account>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Account,
                    Type = Format.List,
                    RequestParameters = new RequestParameters
                    {
                        Search = search,
                        Fields = fields,
                        Game = game,
                        Language = language,
                        Limit = limit,
                        Type = type
                    }
                }
            );
        }

        public async Task<Respond<Meta, Dictionary<ulong, AccountInfo?>>> GetAccountInfo(
            Regions region,
            IEnumerable<long> accountId,
            Language language = Language.En,
            string? accessToken = null,
            IEnumerable<string>? fields = null
        )
        {
            return await m_client.GetRequest<Respond<Meta, Dictionary<ulong, AccountInfo?>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Account,
                    Type = Format.Info,
                    RequestParameters = new RequestParameters
                    {
                        AccountId = accountId,
                        AccessToken = accessToken,
                        Fields = fields,
                        Language = language
                    }
                }
            );
        }
    }
}