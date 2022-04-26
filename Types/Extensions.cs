using System;
using System.Runtime.CompilerServices;
using Wargaming_Net.Types.Enums;

namespace Wargaming_Net.Types
{
    internal static class Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static bool HasService(this Service services, Service target)
        {
            return ((byte) services & (byte) target) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string EnumToString(this Format target)
        {
            return target switch
            {
                Format.List => nameof(Format.List),
                Format.Info => nameof(Format.Info),
                Format.Tags => nameof(Format.Tags),
                Format.Content => nameof(Format.Content),
                Format.Search => nameof(Format.Search),
                Format.Comments => nameof(Format.Comments),
                Format.Categories => nameof(Format.Categories),
                Format.Rate => nameof(Format.Rate),
                Format.NewComment => nameof(Format.NewComment),
                Format.DeleteComment => nameof(Format.DeleteComment),
                Format.Videos => nameof(Format.Videos),
                Format.Vehicles => nameof(Format.Vehicles),
                _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
            };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string EnumToString(this Sections target)
        {
            return target switch
            {
                Sections.Account => nameof(Sections.Account),
                Sections.Wgtv => nameof(Sections.Wgtv),
                Sections.Servers => nameof(Sections.Servers),
                _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
            };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string EnumToString(this Service target)
        {
            return target switch
            {
                Service.None => nameof(Service.None),
                Service.Accounts => nameof(Service.Accounts),
                Service.Wgtv => nameof(Service.Wgtv),
                Service.Servers => nameof(Service.Servers),
                _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
            };
        }
    }
}