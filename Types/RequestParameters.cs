#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types
{
    public class RequestParameters : WargamingApi.Types.RequestParameters
    {
        public string? q { get; set; }
        public long? date_from { get; set; }
        public long? page_no { get; set; } = 1;

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? category_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? program_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? project_id { get; set; }

        [JsonConverter(typeof(ByteConverter))] public bool? important { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? vehicle_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? video_id { get; set; }
    }
}