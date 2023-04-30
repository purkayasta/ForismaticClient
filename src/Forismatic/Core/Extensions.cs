// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------


using Forismatic.Models;

namespace Forismatic.Core
{
    public static class Extensions
    {
        public static string ToText(this LanguageEnum lang)
        {
            return lang switch
            {
                LanguageEnum.English => "en",
                LanguageEnum.Russian => "ru",
                _ => string.Empty,
            };
        }
    }
}