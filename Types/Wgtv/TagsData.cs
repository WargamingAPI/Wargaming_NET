using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Wargaming_Net.Types.Wgtv
{
    public struct TagsData
    {
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<Project> Projects { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<WgtvCategory> Categories { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<Program> Programs { get; set; }
    }
}