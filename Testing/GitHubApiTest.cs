using System.Threading.Tasks;
using NUnit.Framework;
using Website.Source.API;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GitHubGetRepositoryTest()
        {
            var git = new GitHubWrapper("Lucky2114");
            var result = await git.GetUserRepositories();
            Assert.GreaterOrEqual(result.Count, 0);
        }
    }
}