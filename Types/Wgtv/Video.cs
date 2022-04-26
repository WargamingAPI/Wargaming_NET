using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types.Wgtv
{
    public struct Video
    {
        public string Title { get; set; }

        [JsonProperty("ext_title")] public string ExtTitle { get; set; }
        public string Description { get; set; }

        [JsonProperty("video_id")] public string VideoId { get; set; }

        [JsonProperty("video_url")] public string VideoUrl { get; set; }

        public Thumbnails Thumbnails { get; set; }
        public bool Important { get; set; }

        [JsonProperty("published_at")] public long PublishedAt { get; set; }
        public ulong Duration { get; set; }


        [JsonProperty("category_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<ulong> CategoryId { get; set; }

        [JsonProperty("project_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<ulong> ProjectId { get; set; }
    }
}