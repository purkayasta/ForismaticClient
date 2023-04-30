using System.Net.Http.Json;

namespace Forismatic.Core
{
    public interface IForismaticRestClient
    {
        Task<T?> GetAsync<T>(string url, CancellationToken token = default);
    }
    public class ForismaticRestClient : IForismaticRestClient
    {
        private readonly HttpClient? _httpClient;

        public ForismaticRestClient(IHttpClientFactory? httpClientFactory)
        {
            ArgumentNullException.ThrowIfNull(httpClientFactory);
            _httpClient = httpClientFactory.CreateClient(nameof(ForismaticRestClient));
        }

        internal ForismaticRestClient(HttpClient? httpClient)
        {
            ArgumentNullException.ThrowIfNull(httpClient);
            _httpClient = httpClient;
        }

        public Task<T?> GetAsync<T>(string url, CancellationToken token = default) => _httpClient!.GetFromJsonAsync<T>(url, token);

    }
}