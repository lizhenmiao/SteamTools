// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection TryAddFontManager(this IServiceCollection services)
    {
        services.TryAddSingleton<IFontManager, FontManagerImpl>();
        return services;
    }
}