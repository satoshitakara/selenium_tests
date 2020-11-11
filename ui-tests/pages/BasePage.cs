using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;

namespace ui_tests.pages
{
    public abstract class BasePage
    {
        internal readonly IWebDriver _driver;

        public BasePage(string url)
        {
            this._driver = new ChromeDriver();

            _driver.Navigate().GoToUrl(url);
        }

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void Quit()
        {
            this._driver.Quit();
        }

        internal void FillField(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
        internal void FillField(IWebElement element, DateTime value)
        {
            element.Clear();
            element.SendKeys(value.ToString("dd/MM/yyyy"));
        }
        
        internal void FillSelectField(IWebElement element, Enum value)
        {
            element.Click();
            var options = element.FindElements(By.XPath(".//option")).ToList(); 
            var optionToSelect = options.Where(e => e.Text.Equals(value.ToString())).FirstOrDefault();

            optionToSelect?.Click();
        }
        internal void FillRadioField(IWebElement element, string value)
        {
            var label = element.FindElements(By.XPath(".//label")).ToList();
            var labelDesired = label.Where(e => e.Text.Equals(value)).FirstOrDefault();
            labelDesired.Click();
        }
        internal string GetRadioFieldSelected(IWebElement element)
        {
            var input = element.FindElements(By.XPath(".//input")).ToList();
            var inputSelected = input.Where(e => e.GetAttribute("checked") == "true");
            var labels = inputSelected
                .Select(e => e.FindElement(By.XPath($"./../label[@for='{e.GetAttribute("id")}']")).Text).ToList();

            return labels.FirstOrDefault();
        }
        internal int GetSelectionFieldSelected(IWebElement element) 
        {
            return Convert.ToInt32(element.GetAttribute("value"));
        }
    }
}
