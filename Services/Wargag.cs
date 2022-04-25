#nullable enable
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Wargaming_Net.Types;
using WargamingApi.Types;
using RequestArguments = Wargaming_Net.Types.RequestArguments;

namespace Wargaming_Net.Services
{
    public sealed class Wargag
    {
        private readonly WargamingNet _client;

        internal Wargag(WargamingNet client)
        {
            _client = client;
        }

        public async Task<Respond<Meta, Content[]>> SearchContent(Regions region, WargagRequestParameters parameters)
        {
            return await _client.GetRequest<Respond<Meta, Content[]>>(new RequestArguments
            {
                Region = region,
                Section = Sections.wargag,
                Type = Format.search
            }, parameters);
        }

        public async Task<Respond<Meta, Comment[]>> GetComments(Regions region, WargagRequestParameters parameters)
        {
            return await _client.GetRequest<Respond<Meta, Comment[]>>(new RequestArguments
            {
                Region = region,
                Section = Sections.wargag,
                Type = Format.comments
            }, parameters);
        }

        public async Task<Respond<Meta, WargagCategory[]>> GetCategories(Regions region,
            WargagRequestParameters parameters)
        {
            return await _client.GetRequest<Respond<Meta, WargagCategory[]>>(new RequestArguments
            {
                Region = region,
                Section = Sections.wargag,
                Type = Format.categories
            }, parameters);
        }

        public async Task<Respond<Meta, Content[]>> GetContent(Regions region,
            WargagRequestParameters? parameters = null)
        {
            return await _client.GetRequest<Respond<Meta, Content[]>>(new RequestArguments
            {
                Region = region,
                Section = Sections.wargag,
                Type = Format.content
            }, parameters ?? new WargagRequestParameters());
        }

        public async Task<Respond<Meta, Tag[]>> GetTags(Regions region, WargagRequestParameters? parameters = null)
        {
            return await _client.GetRequest<Respond<Meta, Tag[]>>(new RequestArguments
            {
                Region = region,
                Section = Sections.wargag,
                Type = Format.tags
            }, parameters ?? new WargagRequestParameters());
        }
    }
}