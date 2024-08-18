﻿using IntelliSenseLocalizer;
using IntelliSenseLocalizer.ThirdParty;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIntelliSenseLocalizer(this IServiceCollection services)
    {
        services.TryAddTransient<LocalizeIntelliSenseGenerator>();
        services.TryAddTransient<IIntelliSenseItemProvider, DefaultIntelliSenseItemProvider>();
        services.TryAddTransient<IIntelliSenseItemUpdaterFactory, MSDocIntelliSenseItemUpdaterFactory>();

        services.TryAddTransient<LocalizeIntelliSenseTranslator>();

        return services;
    }
}
