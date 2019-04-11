using FluentAssertions;
using System;
using Xunit;

namespace MvcIntegrationTests
{
    public class InterationTests : IClassFixture<TestServerFixture>
    {
        private readonly TestServerFixture _fixture;

        public InterationTests(TestServerFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async void Test1()
        {
            var response = await _fixture.Client.GetAsync($"api/values/1");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            responseString.Should().Be("value");
        }
    }
}
