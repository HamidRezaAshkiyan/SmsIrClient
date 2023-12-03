using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SmsProviders.SmsIr.Extensions;

public static partial class IServiceCollectionExtensions
{
    public static IServiceCollection AddSmsIrClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient<SmsIrClient>(client =>
        {
            SmsIrClientOptions options = new();
            configuration.GetSection(SmsIrClientOptions.ConfigurationSection).Bind(options);

            client.BaseAddress = new Uri(options.BaseAddress, UriKind.Absolute);
            client.DefaultRequestHeaders.Add("x-api-key", options.ApiKey);
        });

        return services;
    }
}