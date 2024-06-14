using DestinyFireteamManager.Web.Resources;
using Microsoft.Extensions.Options;

namespace DestinyFireteamManager.Web.Client
{
    public class BungieNetApiClient : ApiClient
    {
        IOptions<BungieNetOptions> _options;

        public BungieNetApiClient(IHttpClientFactory httpClientFactory, IOptions<BungieNetOptions> options) : base(httpClientFactory) 
        {
            _options = options;
        }

        public override Uri ApiBaseUri => new Uri(_options.Value.ApiBaseUrl!);
        public override Action<HttpClient> ClientOptions => (httpClient) =>
        {
            httpClient.DefaultRequestHeaders.Add("X-API-Key", _options.Value.ApiKey);
        };
    }
}
