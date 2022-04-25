using System;
using WargamingApi.Types;

namespace Wargaming_Net.Types
{
    public class WargagRequestParameters : RequestParameters
    {
        public long rating_threshold { get; set; }
        public ulong category_id { get; set; }
        public ulong content_id { get; set; }
        public ulong page_no { get; set; }

        public string order_by { get; set; }
        public string type { get; set; }
        public string q { get; set; }

        public DateTime date { get; set; }
        public Tags tag_id { get; set; }
    }

    public enum Tags
    {
        WoT = 1,
        WoWP = 2,
        WoWS = 3,
        WG = 7
    }

    public class WargagCategory
    {
        public string Name { get; set; }
        public string type { get; set; }
        public ulong category_id { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public Tags tag_id { get; set; }
    }

    public class Author
    {
        public string status { get; set; }
        public string status_image { get; set; }
        public ulong reputation { get; set; }
    }

    public class Comment
    {
        public string comment { get; set; }
        public string nickname { get; set; }

        public ulong account_id { get; set; }
        public ulong comment_id { get; set; }
        public ulong content_id { get; set; }

        public Author author { get; set; }
        public DateTime created_at { get; set; }
    }

    public class Content
    {
        public long rating { get; set; }
        public ulong account_id { get; set; }
        public ulong content_id { get; set; }

        public string nickname { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string wargag_url { get; set; }
        public string media_url { get; set; }
        public string media_preview_url { get; set; }

        public Author author { get; set; }
        public Tags tag_id { get; set; }
        public DateTime created_at { get; set; }
    }
}