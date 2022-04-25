﻿using System.Runtime.CompilerServices;

namespace Wargaming_Net.Types
{
    internal static class Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static bool HasService(this Service services, Service target)
        {
            return ((byte) services & (byte) target) != 0;
        }
    }
}