using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace ui_tests
{
    public class UnitTest1 : IDisposable
    {
        private IWebDriver driver;
        public UnitTest1()
        {
            driver = new ChromeDriver();
        }
        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            
            IWebElement search = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));
            
            search.SendKeys("primeiro teste");

            searchButton.Click();
            Thread.Sleep(5000);
        }
    }
}
