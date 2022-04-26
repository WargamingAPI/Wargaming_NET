namespace Wargaming_Net.Types.Enums
{
    public enum Format : byte
    {
        // Account, Clans, Servers[info]
        List,
        Info,

        // Wargag, Wgtv
        Tags,
        Content,
        Search,
        Comments,
        Categories,
        Rate,
        NewComment,
        DeleteComment,

        // Wgtv
        Videos,
        Vehicles
    }
}