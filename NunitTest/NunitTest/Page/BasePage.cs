using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Page
{
    internal abstract class BasePage
    {
        protected IWebDriver ChromeDriver { get; set; }

        public BasePage()
        {
            ChromeDriver = Browser.Instance.Driver;
        }
    }
}
