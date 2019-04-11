using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace PracticesTests.UI
{
    public class UITests
    {
        IWebDriver _driver = new ChromeDriver(".");

        [Fact]
        public void FirstTest()
        {
            _driver.Navigate().GoToUrl("https://www.hesapkurdu.com");

            Assert.True(true);
        }

        //public void SecondTest()
        //{
        //_driver.FindElement(By.Id("")).Click();
        //WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0,0,5));
        //wait.Until(x => x.FindElement(By.Id("")).Displayed);
        //}
    }
}