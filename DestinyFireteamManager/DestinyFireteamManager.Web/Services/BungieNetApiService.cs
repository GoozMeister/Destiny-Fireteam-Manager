using DestinyFireteamManager.Web.Client;
using DestinyFireteamManager.Web.Models.BungieNet;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace DestinyFireteamManager.Web.Services
{
    public interface IBungieNetApiService
    {
        public Task<BungieNetResponse<UserSearchResponse>> GetUser(string userName);
    }


    public class BungieNetApiService : IBungieNetApiService
    {
        private readonly BungieNetApiClient _apiClient;

        public BungieNetApiService(BungieNetApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<BungieNetResponse<UserSearchResponse>> GetUser(string userName)
        {
            var response = await _apiClient.Post($"Platform/User/Search/GlobalName/0", new UserSearchPrefixRequest()
            {
                DisplayNamePrefix = userName
            });

            string responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BungieNetResponse<UserSearchResponse>>(responseContent);
        }
    }
}
