using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Evently.Common.Application;

public static class ApplicationConfiguration
{
    public static IServiceCollection AddApplication(this IServiceCollection services,Assembly[] moduleAssembelies)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblies(moduleAssembelies);
        });

        services.AddValidatorsFromAssemblies(moduleAssembelies, includeInternalTypes: true);

        return services;
    }
}