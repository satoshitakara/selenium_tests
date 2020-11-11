using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ui_tests.pages
{
    public partial class GoogleFormPage : BasePage
    {
        private IWebElement _searchText => base._driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
        private IWebElement _searchButton => base._driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));
        private IWebElement _resultSearchText => base._driver.FindElement(By.Id("result-stats"));
        private IEnumerable<IWebElement> _listResult => base._driver.FindElements(By.XPath("//div[@class='g']"));
    }
    public partial class GoogleFormPage : BasePage
    {
        public GoogleFormPage() : base("http://www.google.com")
        {

        }

        public GoogleFormPage(IWebDriver driver) : base(driver)
        {
        }


        public string SearchText
        {
            get
            {
                return _searchText.Text;
            }
            set
            {
                _searchText.SendKeys(value);
            }
        }

        public string ResultSearchText
        {
            get
            {
                return _resultSearchText.Text;
            }
        }

        public List<string> ListResult
        {
            get
            {
                return _listResult.ToList().Select(result => result.Text).ToList();
            }
        }

        public bool CheckExistence()
        {
            return this._searchText.Displayed
                && this._searchButton.Displayed;
        }

        public void ClickOnSearchButton()
        {
            _searchButton.Click();
        }
    }
}