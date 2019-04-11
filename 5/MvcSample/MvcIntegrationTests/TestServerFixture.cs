using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using MvcSample;
using System;
using System.IO;
using System.Net.Http;


namespace MvcIntegrationTests
{
    public class TestServerFixture
    {
        private readonly TestServer _testServer;
        public HttpClient Client { get; }

        public TestServerFixture()
        {
             var builder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseConfiguration(new ConfigurationBuilder()
                    .SetBasePath(GetRootPath())
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile("appsettings.Development.json")
                    .Build())
                .UseStartup<Startup>();
            _testServer = new TestServer(builder);

            Client = _testServer.CreateClient();
        }

        private string GetRootPath()
        {
            
            string testProjectPath = Directory.GetCurrentDirectory();
            
            var relativePathToWebProject = @"..\..\..\..\..\MvcSample\MvcSample";

            return Path.Combine(testProjectPath, relativePathToWebProject);
        }

        public void Dispose()
        {
            Client.Dispose();
            _testServer.Dispose();
        }
    }
}
