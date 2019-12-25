using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Octokit;
using Microsoft.AspNetCore.Session;

namespace Website.Source.API
{
    public class GitHubWrapper
    {
        private GitHubClient client;
        public GitHubWrapper()
        {
            client = new GitHubClient(new ProductHeaderValue("Lucky2114"));
        }

        public async Task<string> GetUserRepositories()
        {
            var user = await client.User.Get("Lucky2114");
            return user.PublicRepos.ToString();
        }
    }
}