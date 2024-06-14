namespace DestinyFireteamManager.Web.Client
{
    public abstract class ApiClient
    {
        private readonly IHttpClientFactory _factory;

        public abstract Uri ApiBaseUri { get; }

        public ApiClient(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<HttpResponseMessage> Get(string path, string? key = null)
        {
            if (string.IsNullOrEmpty(key)) path += "/" + key;
            using (var client = CreateClient())
            {
                var response = await client.GetAsync(path);
                return response;
            };
        }

        public async Task<HttpResponseMessage> Post<T>(string path, T entity)
        {
            using (var client = CreateClient())
            {
                var response = await client.PostAsJsonAsync(path, entity);
                return response;
            };
        }

        public async Task<HttpResponseMessage> Put<T>(string path, string key, T entity)
        {
            path += "/" + key;
            using (var client = CreateClient())
            {
                var response = await client.PutAsJsonAsync(path, entity);
                return response;
            }
        }

        public async Task<HttpResponseMessage> Delete(string path, string key)
        {
            path += "/" + key;
            using (var client = CreateClient())
            {
                var response = await client.DeleteAsync(path);
                return response;
            }
        }

        private HttpClient CreateClient()
        {
            var client = _factory.CreateClient();
            client.BaseAddress = ApiBaseUri;

            ClientOptions?.Invoke(client);

            return client;
        }

        public abstract Action<HttpClient> ClientOptions { get; }
    }
}
