using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types.Wgtv
{
    public struct Video
    {
        public string title { get; set; }
        public string ext_title { get; set; }
        public string description { get; set; }
        public string video_id { get; set; }
        public string video_url { get; set; }

        public Thumbnails thumbnails { get; set; }
        public bool important { get; set; }
        public long published_at { get; set; }
        public ulong duration { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<ulong> category_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<ulong> project_id { get; set; }
    }
}