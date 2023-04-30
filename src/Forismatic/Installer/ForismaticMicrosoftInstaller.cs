using Forismatic.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Forismatic.Installer
{
    public static class ForismaticMicrosoftInstaller
    {
        public static IServiceCollection AddForismatic(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddHttpClient<ForismaticRestClient>(configure =>
            {
                configure.BaseAddress = new Uri(ForismaticConfigurationKeys.BaseAddress);
            });

            serviceCollection.AddScoped<ForismaticRestClient>();
            serviceCollection.AddScoped<IForismaticApiClient, ForismaticApiClient>();

            return serviceCollection;
        }
    }
}