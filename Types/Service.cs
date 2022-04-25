using System;

namespace Wargaming_Net.Types
{
    [Flags]
    public enum Service : byte
    {
        None = 0,
        Accounts = 1 << 0,
        Wgtv = 1 << 1,
        Servers = 1 << 2
    }
}