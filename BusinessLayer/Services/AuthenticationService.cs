using Microsoft.Extensions.Configuration;
using Models.Account;
using Models.AuthServer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;
        public AuthenticationService(IConfiguration config, IHttpClientFactory httpClientFactory)
        {
            _config = config;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResponse<AuthServerLoginResponse>> AuthenticateUserAsync(LoginModel loginModel)
        {
            using var _httpClient = _httpClientFactory.CreateClient();
            try
            {
                AuthServerLoginViewModel authServerLoginModule = new()
                {
                    ClientId = _config["AuthServer:client_id"],
                    ClientSecret = _config["AuthServer:client_secret"],
                    GrantType = _config["AuthServer:grant_type"],
                    Scope = _config["AuthServer:scope"],
                    UserName = loginModel.UserName,
                    Password = loginModel.Password
                };
                var data = new AuthServerLoginData() { Data = authServerLoginModule };
                using var response = await _httpClient.PostAsync($"https://auth.ekbana.net/api/v2/auth/login", new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
                var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var loginResponse = JsonConvert.DeserializeObject<ApiResponse<AuthServerLoginResponse>>(dataAsString);
                return loginResponse;
            }

            catch
            {
                throw;
            }
        }

        public async Task<ApiResponse<AuthServerUserProfileResponse>> GetUserDetailsAsync(string token)
        {
            using var _httpClient = _httpClientFactory.CreateClient();

            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                using var response = await _httpClient.GetAsync($"https://auth.ekbana.net/api/v2/profiles");
                var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var loginResponse = JsonConvert.DeserializeObject<ApiResponse<AuthServerUserProfileResponse>>(dataAsString);
                return loginResponse;
            }
            catch
            {
                throw;
            }
        }

    }
}
