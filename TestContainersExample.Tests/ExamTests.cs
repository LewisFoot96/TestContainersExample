using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using TestContainersExample.Domain;
using TestContainersExample.Infrastructure;

namespace TestContainersExample.Tests
{
    public class ExamTests : IClassFixture<IntegrationTestWebAppFactory>
    {
        private readonly HttpClient _client;
        private readonly IntegrationTestWebAppFactory
            _factory;

        public ExamTests(IntegrationTestWebAppFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });

            // Initialize database
            using var scope = _factory.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ExamDbContext>();
            dbContext.Database.Migrate();
        }

        [Fact]
        public async Task GetAllExamsAsync_ValidResponse_ReturnsExams()
        {
            //Arrange & act
            var response = await _client.GetAsync("/exams");

            //Assert
            response.EnsureSuccessStatusCode();
            var examStream = await response.Content.ReadAsStreamAsync();
            var exams = await JsonSerializer
                .DeserializeAsync<List<Exam>>(examStream);

            Assert.NotNull(exams);
            Assert.Empty(exams);

        }
    }
}
