using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Wrappers
{
    public class Input
    {
        public Input(IWebElement? webElement)
        {
            _webElement = webElement;
        }


        private IWebElement? _webElement;

        public IWebElement? WebElement => _webElement;



        public void Clear() => _webElement?.Clear();

        public void EnterValue(String value) => _webElement?.SendKeys(value);

        public void SetValue(String value)
        {
            _webElement?.Clear();
            _webElement?.SendKeys(value);
        }
    }
}
