﻿#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using Wargaming_Net.Types.Enums;
using Wargaming_Net.Types.Servers;
using WargamingApi.Types;
using WargamingApi.Types.Enums;
using RequestArguments = Wargaming_Net.Types.RequestArguments;
using RequestParameters = Wargaming_Net.Types.RequestParameters;
using TypeServers =
    System.Collections.Generic.Dictionary<string,
        System.Collections.Generic.IEnumerable<Wargaming_Net.Types.Servers.Server>>;

namespace Wargaming_Net.Services
{
    public sealed class Servers
    {
        private readonly WargamingNetClient m_client;

        public Servers(WargamingNetClient client)
        {
            m_client = client;
        }

        public async Task<Respond<ServersMeta, TypeServers?>> GetServersOnline(
            Regions region,
            Language language = Language.En,
            IEnumerable<string>? fields = null,
            IEnumerable<string>? game = null
        )
        {
            return await m_client.GetRequest<Respond<ServersMeta, TypeServers?>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Servers,
                    Type = Format.Info,
                    RequestParameters = new RequestParameters
                    {
                        Fields = fields,
                        Game = game,
                        Language = language
                    }
                }
            );
        }
    }
}