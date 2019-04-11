using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PracticesTests.advanced
{
    public class FixtureSampleTests : IClassFixture<SeleniumFixture>
    {
        private readonly SeleniumFixture _fixture;

        public FixtureSampleTests(SeleniumFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void FirstTestEver()
        {
            _fixture.Driver.Navigate().GoToUrl("https://www.hesapkurdu.com");
            var element = _fixture.Driver.FindElement(By.Id(""));

            //Assert
            element.Text.Should().Be("");
        }

    }
}
