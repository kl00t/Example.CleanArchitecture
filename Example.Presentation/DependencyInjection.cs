using Microsoft.Extensions.DependencyInjection;

namespace Example.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}