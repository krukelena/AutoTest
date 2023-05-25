using Core.Selenium;
using OpenQA.Selenium.DevTools.V111.Runtime;

namespace NunitTest.Page
{
    public abstract class BasePage
    {
        public BasePage(IBrowser browser)
        {
            _browser = browser;
        }


        protected IBrowser _browser;

        protected abstract void OpenPage();

        public abstract bool IsPageOpened();
    }
}

