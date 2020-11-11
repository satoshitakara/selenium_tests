using System.Collections.Generic;
using ui_tests.pages;
using Xunit;

namespace ui_tests.tests
{
    public class BabysitterTests : BaseTests<BabysitterFormPage>
    {
        public BabysitterTests()
        {
            _page = new BabysitterFormPage();
        }

        [Fact]
        public void CheckFields()
        {
            var fieldsExpected = new List<string>()
            {
                "Name",
                "Birth Date", "Driving Licence", "Do you study?",
                "Martial Status", "Do you smoke?", "Do you drink?",
                "Any Certificates?", "Please describe yourself",
                "Phone", "Email", "Address", "High School", "College",
                "Name of Employer", "Phone", "Age of Children"
            };
            var fields =_page.GetFields();
            fields.ForEach(field => fieldsExpected.Contains(field));
        }

        [Fact]
        public void Create()
        {
            _page.FillFields();
            _page.ClickSubmit();
        }

    }
}
