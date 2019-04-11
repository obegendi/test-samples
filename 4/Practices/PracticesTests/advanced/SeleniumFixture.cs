using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PracticesTests.advanced
{
    public class SeleniumFixture : IDisposable
    {
         IWebDriver _driver = null;
        public SeleniumFixture()
        {
            Driver = new ChromeDriver(".");
        }

        public IWebDriver Driver { get => _driver; set => _driver = value; }

        public void Dispose()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}