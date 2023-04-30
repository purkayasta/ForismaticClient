// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



using Forismatic.Models;

namespace Forismatic
{
    public interface IForismaticApiClient
    {
        Task<QuoteDto?> GetQuoteAsync(LanguageEnum languageEnum, CancellationToken token = default);
    }
}