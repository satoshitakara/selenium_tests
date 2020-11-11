using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ui_tests.pages
{
    public class HomePage:BasePage
    {
        public HomePage():base("localhost:4200") { }
        public HomePage(IWebDriver driver) : base(driver) { }

        public BabysitterFormPage NavigateToBabysitter()
        {
            //do something
            return new BabysitterFormPage(base._driver);
        }
    }
}
