using DestinyFireteamManager.Web.Client;
using DestinyFireteamManager.Web.Resources;
using DestinyFireteamManager.Web.Services;

namespace DestinyFireteamManager.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBungieNet(this IServiceCollection services, IConfigurationSection configuration)
        {
            return services
                .Configure<BungieNetOptions>(configuration)
                .AddScoped<BungieNetApiClient>()
                .AddScoped<IBungieNetApiService, BungieNetApiService>();
        }
    }
}
