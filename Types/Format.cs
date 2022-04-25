namespace Wargaming_Net.Types
{
    public enum Format : byte
    {
        // Account, Clans, Servers[info]
        list,
        info,

        // Wargag, Wgtv
        tags,
        content,
        search,
        comments,
        categories,
        rate,
        newcomment,
        deletecomment,

        // Wgtv
        videos,
        vehicles
    }
}