using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Wrappers
{
    public class Button
    {
        public Button(IWebElement? webElement)
        {
            _webElement = webElement;
        }


        private IWebElement? _webElement;

        public IWebElement? WebElement => _webElement;
        public String? Text => _webElement?.Text;



        public void Click() => _webElement?.Click();
    }
}
