// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



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

            serviceCollection.AddSingleton<IForismaticRestClient, ForismaticRestClient>();
            serviceCollection.AddSingleton<IForismaticApiClient, ForismaticApiClient>();

            return serviceCollection;
        }
    }
}