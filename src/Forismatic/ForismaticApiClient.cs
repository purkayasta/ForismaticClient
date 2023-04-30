// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



using Forismatic.Core;
using Forismatic.Models;

namespace Forismatic
{
    public class ForismaticApiClient : IForismaticApiClient
    {
        private readonly IForismaticRestClient _client;

        public ForismaticApiClient(IForismaticRestClient client)
        {
            _client = client;
        }


        public Task<QuoteDto?> GetQuoteAsync(LanguageEnum languageEnum, CancellationToken token = default)
        {
            string url = $"?method=getQuote&format=json&lang={languageEnum.ToText()}";
            return _client.GetAsync<QuoteDto>(url, token);
        }
    }
}