namespace DestinyFireteamManager.Web.Models.BungieNet
{
    public class UserInfoCard
    {
        public string SupplementalDisplayName { get; set; }
        public string IconPath { get; set; }
        public int CrossSaveOverride { get; set; }
        public int[] ApplicableMembershipTypes { get; set; }
        public bool IsPublic { get; set; }
        public int MembershipType { get; set; }
        public long MembershipId { get; set; }
        public string DisplayName { get; set; }
        public string BungieGlobalDisplayName { get; set; }
        public int BungieGlobalDisplayNameCode { get; set; }
    }
}
