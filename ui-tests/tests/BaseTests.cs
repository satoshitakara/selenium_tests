using System;
using ui_tests.pages;

namespace ui_tests.tests
{
    public abstract class BaseTests<T> : IDisposable where T : BasePage
    {
        public T _page;

        public BaseTests()
        {

        }

        public void Dispose()
        {
            _page?.Quit();
        }
    }
}
