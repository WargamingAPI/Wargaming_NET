#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using Wargaming_Net.Types;
using Wargaming_Net.Types.Servers;
using WargamingApi.Types;
using RequestArguments = Wargaming_Net.Types.RequestArguments;
using RequestParameters = Wargaming_Net.Types.RequestParameters;

namespace Wargaming_Net.Services
{
    public sealed class Servers
    {
        private readonly WargamingNet _client;

        internal Servers(WargamingNet client)
        {
            _client = client;
        }

        public async Task<
            Respond<ServersMeta, Dictionary<string, IEnumerable<Server>>?>
        > GetServersOnline(
            Regions region,
            Language language = Language.en,
            IEnumerable<string>? fields = null,
            IEnumerable<string>? game = null
        )
        {
            return await _client.GetRequest<
                Respond<ServersMeta, Dictionary<string, IEnumerable<Server>>?>
            >(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.servers,
                    Type = Format.info,
                    RequestParameters = new RequestParameters
                    {
                        fields = fields,
                        game = game,
                        language = language
                    }
                }
            );
        }
    }
}
