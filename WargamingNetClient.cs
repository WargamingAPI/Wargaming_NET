#nullable enable
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Wargaming_Net.Services;
using Wargaming_Net.Types;
using Wargaming_Net.Types.Enums;
using WargamingApi;

namespace Wargaming_Net
{
    public sealed class WargamingNetClient
    {
        private readonly string m_requestForm;

        public WargamingNetClient(WargamingApiClient client)
        {
            /*
             * 0 - Region
             * 1 - Section
             * 2 - Type
             * 3 - Parameters
             */

            if (string.IsNullOrEmpty(client.ApplicationId) || string.IsNullOrWhiteSpace(client.ApplicationId))
                throw new NullReferenceException(
                    $"Application id can not be null, specify it in {nameof(WargamingApiClient.ApplicationId)} parameter");

            m_requestForm =
                @"https://api.worldoftanks.{0}/wgn/{1}/{2}/?application_id="
                + client.ApplicationId
                + "{3}";
        }

        public ServiceProvider Services { get; private set; } = null!;

        public ServiceProvider InitServices(Service services)
        {
            if (services == Service.None)
                return Services;

            var svc = new ServiceCollection().AddSingleton(this);

            if (services.HasService(Service.Accounts))
                svc = svc.AddSingleton<Accounts>();
            if (services.HasService(Service.Wgtv))
                svc = svc.AddSingleton<Wgtv>();
            if (services.HasService(Service.Servers))
                svc = svc.AddSingleton<Servers>();

            Services = svc.BuildServiceProvider();
            return Services;
        }

        internal async Task<T> GetRequest<T>(RequestArguments requestArguments)
        {
            return await WargamingApiClient.GetRequest<T>(
                new Uri(
                    string.Format(
                        m_requestForm,
                        nameof(requestArguments.Region),
                        nameof(requestArguments.Section),
                        nameof(requestArguments.Type),
                        requestArguments.Parameters
                    )
                )
            );
        }
    }
}