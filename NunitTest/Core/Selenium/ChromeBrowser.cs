using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core.Selenium
{
    public class ChromeBrowser : IBrowser
    {
        public ChromeBrowser()
        {
            _driver = new ChromeDriver();
        }


        private IWebDriver? _driver;

        public IWebDriver? Driver
        {
            get { return _driver; }
            set { }
        }
    }
}
