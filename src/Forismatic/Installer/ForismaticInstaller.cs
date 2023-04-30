// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



using Forismatic.Core;

namespace Forismatic.Installer
{
    public class ForismaticInstaller
    {
        public static IForismaticApiClient CreateClient()
        {
            return Create(new HttpClient());
        }

        public static IForismaticApiClient CreateClient(HttpClient? httpClient)
        {
            ArgumentNullException.ThrowIfNull(httpClient);
            return Create(httpClient);
        }

        private static IForismaticApiClient Create(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(ForismaticConfigurationKeys.BaseAddress);
            return new ForismaticApiClient(new ForismaticRestClient(httpClient));
        }
    }
}