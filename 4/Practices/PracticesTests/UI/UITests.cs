using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace PracticesTests.UI
{
    public class UITests : IDisposable
    {
        IWebDriver _driver = new ChromeDriver(".");

        public void Dispose()
        {
            _driver.Close();
            _driver.Dispose();

        }

        [Fact]
        public void FirstTest()
        {
            _driver.Navigate().GoToUrl("https://www.hesapkurdu.com");
            Assert.True(true);
        }


    }
}