using System.Collections.Generic;

namespace Wargaming_Net.Types.Wgtv.Structs
{
    public struct TagsData
    {
        public IEnumerable<Project> Projects { get; set; }

        public IEnumerable<WgtvCategory> Categories { get; set; }

        public IEnumerable<Program> Programs { get; set; }
    }
}