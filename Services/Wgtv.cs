#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using Wargaming_Net.Types.Enums;
using Wargaming_Net.Types.Wgtv;
using WargamingApi.Types;
using RequestArguments = Wargaming_Net.Types.RequestArguments;
using RequestParameters = Wargaming_Net.Types.RequestParameters;

namespace Wargaming_Net.Services
{
    public sealed class Wgtv
    {
        private readonly WargamingNet _client;

        internal Wgtv(WargamingNet client)
        {
            _client = client;
        }

        public async Task<Respond<WgtvMeta, TagsData>> GetTags(
            Regions region,
            Language language = Language.en,
            IEnumerable<string>? fields = null
        )
        {
            return await _client.GetRequest<Respond<WgtvMeta, TagsData>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.wgtv,
                    Type = Format.tags,
                    RequestParameters = new RequestParameters
                    {
                        fields = fields,
                        language = language
                    }
                }
            );
        }

        public async Task<IEnumerable<Project>> GetProjects(
            Regions region,
            Language language = Language.en,
            IEnumerable<string>? fields = null
        )
        {
            return (await GetTags(region, language, fields)).data.Projects;
        }

        public async Task<IEnumerable<WgtvCategory>> GetCategories(
            Regions region,
            Language language = Language.en,
            IEnumerable<string>? fields = null
        )
        {
            return (await GetTags(region, language, fields)).data.Categories;
        }

        public async Task<IEnumerable<Program>> GetPrograms(
            Regions region,
            Language language = Language.en,
            IEnumerable<string>? fields = null
        )
        {
            return (await GetTags(region, language, fields)).data.Programs;
        }

        public async Task<Respond<WgtvMeta, Dictionary<string, IEnumerable<ulong>>>> GetVehicles(
            Regions region,
            IEnumerable<string>? categoryId = null,
            IEnumerable<string>? programId = null,
            IEnumerable<string>? projectId = null
        )
        {
            return await _client.GetRequest<
                Respond<WgtvMeta, Dictionary<string, IEnumerable<ulong>>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.wgtv,
                    Type = Format.vehicles,
                    RequestParameters = new RequestParameters
                    {
                        category_id = categoryId,
                        program_id = programId,
                        project_id = projectId
                    }
                }
            );
        }

        public async Task<Respond<WgtvMeta, IEnumerable<Video>>> GetVideos(
            Regions region,
            Language language = Language.en,
            string? q = null,
            bool? important = null,
            byte? limit = null,
            long? dateFrom = null,
            long? pageIndex = null,
            IEnumerable<string>? fields = null,
            IEnumerable<long>? vehicleId = null,
            IEnumerable<string>? videoId = null,
            IEnumerable<string>? projectId = null,
            IEnumerable<string>? programId = null,
            IEnumerable<string>? categoryId = null
        )
        {
            return await _client.GetRequest<Respond<WgtvMeta, IEnumerable<Video>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.wgtv,
                    Type = Format.videos,
                    RequestParameters = new RequestParameters
                    {
                        fields = fields,
                        language = language,
                        limit = limit,
                        category_id = categoryId,
                        program_id = programId,
                        project_id = projectId,
                        date_from = dateFrom,
                        important = important,
                        page_no = pageIndex,
                        q = q,
                        vehicle_id = vehicleId,
                        video_id = videoId
                    }
                }
            );
        }
    }
}