namespace DestinyFireteamManager.Web.Models.BungieNet
{
    public class BungieNetResponse<T>
    {
        public T Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
    }
}
