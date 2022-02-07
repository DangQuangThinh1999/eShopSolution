using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using eShopSolution.ViewModels.System.Users;
using Newtonsoft.Json;

namespace eShopSolution.ApiIntegration
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, encoding: Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7193");// localhost của backend API
            var response = await client.PostAsync("api/users/authenticate", httpContent);

            var token = await response.Content.ReadAsStringAsync();
            return token;
        }
    }
}