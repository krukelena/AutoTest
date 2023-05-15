using NunitTest.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NunitTest.Test
{
   public class BaseTest
    {
        //protected WebDriver ChromeDriver { get; set; }  

        //public LoginPage LoginPage { get; set; }

        //[SetUp]
        //public void SetUp()
        //{
        //    string browser = TestContext.Parameters.Get("Browser");
        //    switch (browser) 
        //    {
        //        case "headless":
        //            ChromeOptions options= new ChromeOptions();
        //            options.AddArgument("--headless");
        //            break;
        //        default:
        //            ChromeDriver = new ChromeDriver();
        //            break;
        //    }
        //    ChromeDriver = new ChromeDriver();
        //    ChromeDriver.Manage().Window.Maximize();
        //    ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //}
            //[TearDown]

        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
    
