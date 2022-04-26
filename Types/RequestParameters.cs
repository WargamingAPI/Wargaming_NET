#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types
{
    public class RequestParameters : WargamingApi.Types.RequestParameters
    {
        public string? Q { get; set; }

        [JsonProperty("date_from")] public long? DateFrom { get; set; }

        [JsonProperty("page_no")] public long? PageNo { get; set; } = 1;

        [JsonProperty("category_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? CategoryId { get; set; }

        [JsonProperty("program_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? ProgramId { get; set; }

        [JsonProperty("project_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? ProjectId { get; set; }

        [JsonConverter(typeof(ByteConverter))] public bool? Important { get; set; }

        [JsonProperty("vehicle_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? VehicleId { get; set; }

        [JsonProperty("video_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? VideoId { get; set; }
    }
}