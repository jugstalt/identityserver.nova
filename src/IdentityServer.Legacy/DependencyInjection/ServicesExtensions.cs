using IdentityServer.Legacy.DbContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.DependencyInjection
{
    public static class ServicesExtensions
    {
        #region UserDbContext

        static public IUserDbContextBuilder AddUserDbContext<T>(this IServiceCollection services) 
            where T : class, IUserDbContext
        {
            services.AddTransient<IUserDbContext, T>();

            return new UserDbContextBuilder(services);
        }

        static public IServiceCollection AddUserDbContext<T>(this IServiceCollection services, Action<UserDbContextConfiguration> setupAction)
            where T : class, IUserDbContext
        {
            services.Configure(setupAction);
            services.AddTransient<IUserDbContext, T>();

            return services;
        }

        public static IUserDbContextBuilder AddUserDbContextOptions(this IUserDbContextBuilder builder, 
            Action<UserDbContextConfiguration> setupAction)
        {
            builder.Services.Configure(setupAction);

            return builder;
        }

        #endregion

        #region ClientDbContext

        static public IClientDbContextBuilder AddClientDbContext<T>(this IServiceCollection services)
            where T : class, IClientDbContext
        {
            services.AddTransient<IClientDbContext, T>();

            return new ClientDbContextBuilder(services);
        }

        static public IServiceCollection AddClientDbContext<T>(this IServiceCollection services, Action<ClientDbContextConfiguration> setupAction)
            where T : class, IClientDbContext
        {
            services.Configure(setupAction);
            services.AddTransient<IClientDbContext, T>();

            return services;
        }

        public static IClientDbContextBuilder AddClientDbContextOptions(this IClientDbContextBuilder builder,
            Action<UserDbContextConfiguration> setupAction)
        {
            builder.Services.Configure(setupAction);

            return builder;
        }

        #endregion

        #region ResourceDbContext

        static public IResourceDbContextBuilder AddResourceDbContext<T>(this IServiceCollection services)
            where T : class, IResourceDbContext
        {
            services.AddTransient<IResourceDbContext, T>();

            return new ResourceDbContextBuilder(services);
        }

        static public IServiceCollection AddResourceDbContext<T>(this IServiceCollection services, Action<ResourceDbContextConfiguration> setupAction)
            where T : class, IResourceDbContext
        {
            services.Configure(setupAction);
            services.AddTransient<IResourceDbContext, T>();

            return services;
        }

        public static IResourceDbContextBuilder AddResourceDbContextOptions(this IResourceDbContextBuilder builder,
            Action<ResourceDbContextConfiguration> setupAction)
        {
            builder.Services.Configure(setupAction);

            return builder;
        }

        #endregion
    }
}
