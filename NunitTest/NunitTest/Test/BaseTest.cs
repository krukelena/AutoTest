using Core.Selenium;
using NUnit.Allure.Core;
using NunitTest.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Test.SwagLabs
{
    [AllureNUnit]
    public class BaseTest
    {
        protected IBrowser? _browser;
        
        protected LoginPage _loginPage;


        [SetUp]
        public void SetUp()
        {
            _browser = new ChromeBrowser();
            _browser.Driver?.Navigate().GoToUrl("https://www.saucedemo.com/");

            _loginPage = new LoginPage(_browser);
        }

        //[Test]
        //public void Test()
        //{
        //    loginPage.EnterUsername("standard_user");
        //    loginPage.EnterPassword("secret_sauce");
        //    loginPage.ClickLoginButton();
        //}

        [TearDown]
        public void TearDown()
        {
            _browser?.Driver?.Close();
        }

    }
}
