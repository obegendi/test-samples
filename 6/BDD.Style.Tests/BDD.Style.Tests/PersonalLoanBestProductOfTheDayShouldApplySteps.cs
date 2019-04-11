using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDD.Style.Tests
{
    [Binding]
    public class PersonalLoanBestProductOfTheDayShouldApplySteps : IDisposable
    {
        IWebDriver _driver = new ChromeDriver(".");

        [Given]
        public void GivenLaunchHomePage()
        {
            _driver.Url = "https://www.hesapkurdu.com";
            _driver.Navigate();
        }

        [When]
        public void WhenClickPersonalLoan()
        {
            _driver.FindElement(By.XPath(@"//*[@id='page-body']/div[2]/div/div/div/div[1]/a")).Click();
            //*[@id="js-sticky-point"]/div/div/div/div[1]/div[2]/div[3]/div/a
        }

        [When]
        public void WhenClickBestProductOfDayApplicationButton()
        {
            Thread.Sleep(5000);
            _driver.Manage().Window.FullScreen();
            
            _driver.FindElement(By.XPath(@"//*[@id='js-sticky-point']/div/div/div/div[1]/div[2]/div[3]/div/a")).Click();
        }

        [When]
        public void WhenFillTheForm()
        {
            Thread.Sleep(2000);
            IWebElement tcknField = _driver.FindElement(By.XPath(@"//*[@id='js-mask-tckn']"));
            if (tcknField != null)
            {
                tcknField.SendKeys("11111111110");
            }
            IWebElement phoneField = _driver.FindElement(By.XPath(@"//*[@id='js-mask-phone']"));
            if (phoneField != null)
            {
                phoneField.SendKeys("5551234545");
            }
            IWebElement emailField = _driver.FindElement(By.XPath(@"//*[@id='js-mask-email']"));
            if (emailField != null)
            {
                emailField.SendKeys("dummy@hesapkurdu.com");
            }
            IWebElement incomeField = _driver.FindElement(By.XPath(@"//*[@id='js-personal-application-form']/div[2]/div[3]/div/label[2]/input"));
            if (incomeField != null)
            {
                incomeField.SendKeys("5000");
            }


        }

        [Then]
        public void ThenApply()
        {
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//*[@id='js-btn-submit']")).Click();
        }

        public void Dispose()
        {
            _driver.Close();
            _driver.Dispose();
        }

        public IWebElement WaitUntilElementExists(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}
