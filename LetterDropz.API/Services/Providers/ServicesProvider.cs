using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LetterDropz.API.Services.Providers
{
    public static class ServicesProvider
    {
        public static IServiceCollection AddLetterDropzServices(this IServiceCollection services)
        {
            services.AddScoped<UsersService>();

            return services;
        }
    }
}
