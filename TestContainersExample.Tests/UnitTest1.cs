using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;
using TestContainersExample.Infrastructure;

namespace TestContainersExample.Tests
{
    public class UnitTest1 : IClassFixture<IntegrationTestWebAppFactory>
    {
        private readonly HttpClient _client;
        private readonly IntegrationTestWebAppFactory
            _factory;

        public UnitTest1(IntegrationTestWebAppFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task Test1()
        {
            // Given
            var customerService = await _client.GetAsync("/weatherforecast");
        }
    }
}
