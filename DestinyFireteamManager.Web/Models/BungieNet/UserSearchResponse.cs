using System.Collections;
using System.Collections.ObjectModel;

namespace DestinyFireteamManager.Web.Models.BungieNet
{
    public class UserSearchResponse
    {
        public ICollection<UserSearchResponseDetail> SearchResults { get; set; }
        public int Page { get; set; }
        public bool HasMore { get; set; }

        public UserSearchResponse()
        {
            SearchResults = [];
        }
    }

    public class UserSearchResponseDetail
    {
        public string BungieGlobalDisplayName { get; set; }
        public int BungieGlobalDisplayNameCode { get; set; }
        public long BungieNetMembershipId { get; set; }
        public ICollection<UserInfoCard> DestinyMemberships { get; set; }
    }
}
