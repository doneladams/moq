﻿using System.Linq;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Moq.Proxy
{
    static class LanguageServicesExtensions
    {
        public static ILanguageService GetLanguageService(this ILanguageServices services, string language, string serviceType, string layer = ServiceLayer.Default)
            => services.GetLanguageServices(language, serviceType, layer).FirstOrDefault();

        public static TService GetLanguageService<TService>(this ILanguageServices services, string language, string layer = ServiceLayer.Default)
            => services.GetLanguageServices<TService>(language, layer).FirstOrDefault();
    }
}