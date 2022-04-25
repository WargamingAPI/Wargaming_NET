#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Wargaming_Net.Types;
using Wargaming_Net.Types.Accounts;
using WargamingApi.Types;
using static WargamingApi.Types.Types;
using RequestArguments = Wargaming_Net.Types.RequestArguments;
using RequestParameters = Wargaming_Net.Types.RequestParameters;

namespace Wargaming_Net.Services
{
    public sealed class Accounts
    {
        private readonly WargamingNet _client;

        internal Accounts(WargamingNet client)
        {
            _client = client;
        }

        public async Task<Respond<Meta, IEnumerable<Account>>> SearchAccounts(
            Regions region,
            string search,
            Language language = Language.en,
            WargamingApi.Types.Types type = startswith,
            byte? limit = null,
            IEnumerable<string>? fields = null,
            IEnumerable<string>? game = null
        )
        {
            return await _client.GetRequest<Respond<Meta, IEnumerable<Account>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.account,
                    Type = Format.list,
                    RequestParameters = new RequestParameters
                    {
                        search = search,
                        fields = fields,
                        game = game,
                        language = language,
                        limit = limit,
                        type = type
                    }
                }
            );
        }

        public async Task<Respond<Meta, Dictionary<ulong, AccountInfo?>>> GetAccountInfo(
            Regions region,
            IEnumerable<long> accountId,
            Language language = Language.en,
            string? accessToken = null,
            IEnumerable<string>? fields = null
        )
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<ulong, AccountInfo?>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.account,
                    Type = Format.info,
                    RequestParameters = new RequestParameters
                    {
                        account_id = accountId,
                        access_token = accessToken,
                        fields = fields,
                        language = language
                    }
                }
            );
        }
    }
}
