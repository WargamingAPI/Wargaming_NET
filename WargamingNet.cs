using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Wargaming_Net.Services;
using Wargaming_Net.Types;
using Wargaming_Net.Types.Enums;

namespace Wargaming_Net
{
    public sealed class WargamingNet
    {
        private readonly string _requestForm;

        public WargamingNet(string applicationId)
        {
            /*
             * 0 - Region
             * 1 - Section
             * 2 - Type
             * 3 - Parameters
             */
            _requestForm =
                @"https://api.worldoftanks.{0}/wgn/{1}/{2}/?application_id="
                + applicationId
                + "{3}";
        }

        public ServiceProvider Services { get; private set; } = null!;

        public ServiceProvider InitServices(Service services)
        {
            if (services == Service.None)
                return Services;

            IServiceCollection svc = new ServiceCollection();

            if (services.HasService(Service.Accounts))
                svc = svc.AddSingleton(new Accounts(this));
            if (services.HasService(Service.Wgtv))
                svc = svc.AddSingleton(new Wgtv(this));
            if (services.HasService(Service.Servers))
                svc = svc.AddSingleton(new Servers(this));

            Services = svc.BuildServiceProvider();
            return Services;
        }

        internal async Task<T> GetRequest<T>(RequestArguments requestArguments)
        {
            return await WargamingApi.WargamingApi.GetRequest<T>(
                new Uri(
                    string.Format(
                        _requestForm,
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
