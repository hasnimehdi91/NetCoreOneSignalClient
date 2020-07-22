using System;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreOneSignalV7Client
{
    public static class OneSignalExtension
    {
        public static IServiceCollection AddOneSignal(this IServiceCollection services,
            Action<OneSignalOptions> configure = null)
        {
            var options = new OneSignalOptions();
            configure?.Invoke(options);
            services.AddTransient<IOneSignalClient, OneSignalClient>(oneSignalClient => new OneSignalClient(options));
            return services;
        }
    }
}