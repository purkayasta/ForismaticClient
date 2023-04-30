// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------


using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace Forismatic.Core
{
    public interface IForismaticRestClient
    {
        Task<T?> GetAsync<T>(string url, CancellationToken token = default);
    }
    public class ForismaticRestClient : IForismaticRestClient
    {
        private HttpClient? _httpClient;
        private readonly IHttpClientFactory? _httpClientFactory;

        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreReadOnlyProperties = true,
            IgnoreReadOnlyFields = true
        };

        public ForismaticRestClient(IHttpClientFactory? httpClientFactory)
        {
            ArgumentNullException.ThrowIfNull(httpClientFactory);
            _httpClientFactory = httpClientFactory;
        }

        internal ForismaticRestClient(HttpClient? httpClient)
        {
            ArgumentNullException.ThrowIfNull(httpClient);
            _httpClient = httpClient;
        }

        public async Task<T?> GetAsync<T>(string url, CancellationToken token = default)
        {
            _httpClient ??= _httpClientFactory!.CreateClient(nameof(ForismaticRestClient));

            try
            {
                var response = await _httpClient!.GetAsync(url, token);
                if (response is null) return default;
                return await JsonSerializer.DeserializeAsync<T>(await response.Content.ReadAsStreamAsync(token), _jsonSerializerOptions, token);
            }
            catch (Exception)
            {
                await Console.Out.WriteLineAsync("Exception Occurred! Try again please!");
            }
            return default;
        }
    }
}