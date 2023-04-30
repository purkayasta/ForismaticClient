using Forismatic.Models;

namespace Forismatic
{
    public interface IForismaticApiClient
    {
        Task<QuoteDto?> GetQuoteAsync(LanguageEnum languageEnum, CancellationToken token = default);
    }
}