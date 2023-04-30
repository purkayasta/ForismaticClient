using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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