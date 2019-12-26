using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;
using Website.Data.Models;

namespace Website.Source.API
{
    public class GitHubWrapper
    {
        private HttpClient _client;
        private const string GITHUB_API_BASE_URL = "https://api.github.com";
        private string _userName;
        public GitHubWrapper(string username)
        {
            _userName = username;
            _client = new HttpClient();
            
            _client.DefaultRequestHeaders.Add("User-Agent", "Kevin M. Blazor Server");
        }

        public async Task<List<Repository>> GetUserRepositories()
        {
            var response = await _client.GetAsync(GITHUB_API_BASE_URL + $"/users/{_userName}/repos");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException($"Http Error. HttpStatusCode = {response.StatusCode}");
            }

            var jsonRaw = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Repository>>(jsonRaw);
        }
    }
}