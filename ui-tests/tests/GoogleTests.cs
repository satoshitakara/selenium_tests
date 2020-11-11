using ui_tests.pages;
using Xunit;

namespace ui_tests.tests
{
    public class GoogleTests : BaseTests<GoogleFormPage>
    {
        public GoogleTests() : base()
        {
            _page = new GoogleFormPage();
        }

        [Fact]
        public void CheckFields()
        {
            Assert.True(_page.CheckExistence());
        }

        [Theory]
        [InlineData("primeiro teste")]
        [InlineData("segundo teste")]
        [InlineData("terceiro teste")]
        public void SearchTest(string text)
        {
            _page.SearchText = text;

            _page.ClickOnSearchButton();

            Assert.Contains("Aproximadamente", _page.ResultSearchText);
            Assert.Contains("resultados", _page.ResultSearchText);
            Assert.True(_page.ListResult.Count > 0);
        }
    }
}
