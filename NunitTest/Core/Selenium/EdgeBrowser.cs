using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium
{
    public class EdgeBrowser : IBrowser
    {
        public EdgeBrowser()
        {
            _driver = new EdgeDriver();
        }


        private IWebDriver? _driver;

        public IWebDriver? Driver 
        {
            get => _driver;
            set { }
        }
    }
}
