#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using Wargaming_Net.Types.Enums;
using Wargaming_Net.Types.Wgtv;
using Wargaming_Net.Types.Wgtv.Structs;
using WargamingApi.Types;
using WargamingApi.Types.Enums;
using RequestArguments = Wargaming_Net.Types.RequestArguments;
using RequestParameters = Wargaming_Net.Types.RequestParameters;

namespace Wargaming_Net.Services
{
    public sealed class Wgtv
    {
        private readonly WargamingNetClient m_client;

        public Wgtv(WargamingNetClient client)
        {
            m_client = client;
        }

        public async Task<Respond<WgtvMeta, TagsData>> GetTags(
            Regions region,
            Language language = Language.En,
            IEnumerable<string>? fields = null
        )
        {
            return await m_client.GetRequest<Respond<WgtvMeta, TagsData>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Wgtv,
                    Type = Format.Tags,
                    RequestParameters = new RequestParameters
                    {
                        Fields = fields,
                        Language = language
                    }
                }
            );
        }

        public async Task<IEnumerable<Project>> GetProjects(
            Regions region,
            Language language = Language.En,
            IEnumerable<string>? fields = null
        )
        {
            return (await GetTags(region, language, fields)).Data.Projects;
        }

        public async Task<IEnumerable<WgtvCategory>> GetCategories(
            Regions region,
            Language language = Language.En,
            IEnumerable<string>? fields = null
        )
        {
            return (await GetTags(region, language, fields)).Data.Categories;
        }

        public async Task<IEnumerable<Program>> GetPrograms(
            Regions region,
            Language language = Language.En,
            IEnumerable<string>? fields = null
        )
        {
            return (await GetTags(region, language, fields)).Data.Programs;
        }

        public async Task<Respond<WgtvMeta, Dictionary<string, IEnumerable<ulong>>>> GetVehicles(
            Regions region,
            IEnumerable<string>? categoryId = null,
            IEnumerable<string>? programId = null,
            IEnumerable<string>? projectId = null
        )
        {
            return await m_client.GetRequest<
                Respond<WgtvMeta, Dictionary<string, IEnumerable<ulong>>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Wgtv,
                    Type = Format.Vehicles,
                    RequestParameters = new RequestParameters
                    {
                        CategoryId = categoryId,
                        ProgramId = programId,
                        ProjectId = projectId
                    }
                }
            );
        }

        public async Task<Respond<WgtvMeta, IEnumerable<Video>>> GetVideos(
            Regions region,
            Language language = Language.En,
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
            return await m_client.GetRequest<Respond<WgtvMeta, IEnumerable<Video>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Wgtv,
                    Type = Format.Videos,
                    RequestParameters = new RequestParameters
                    {
                        Fields = fields,
                        Language = language,
                        Limit = limit,
                        CategoryId = categoryId,
                        ProgramId = programId,
                        ProjectId = projectId,
                        DateFrom = dateFrom,
                        Important = important,
                        PageNo = pageIndex,
                        Q = q,
                        VehicleId = vehicleId,
                        VideoId = videoId
                    }
                }
            );
        }
    }
}