﻿using IdentityServer.Nova.Distribution.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityServer.Nova.Distribution.Extensions.DependencyInjection;

static public class ServiceCollectionExtensions
{
    static public IServiceCollection AddHttpInvoker<TInterface>(
            this IServiceCollection services,
            Action<HttpInvokerServiceOptions<TInterface>> setupInvoker,
            Action<HttpClient> setupClient
        )
    {
        services
            .Configure(setupInvoker)
            .AddHttpClient<HttpInvokerService<TInterface>>(setupClient);

        return services;
    }
}
