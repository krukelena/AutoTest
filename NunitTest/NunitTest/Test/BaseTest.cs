using Allure.Commons;
using Core.Selenium;
using NLog;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;
using NunitTest.Page;
using OpenQA.Selenium;
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
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private AllureLifecycle _allure;
        protected IBrowser? _browser;
       
        protected LoginPage _loginPage;


        [SetUp]
        public void SetUp()
        {
            _logger.Trace("Сообщение уровня Trace");
            _logger.Debug("Сообщение уровня Debag");
            _logger.Info("Сообщение уровня Info");
            _logger.Warn("Сообщение уровня Warn");
            _logger.Error("Сообщение уровня Error");
            _logger.Fatal("Сообщение уровня Fatal");

            _browser = new ChromeBrowser();
            _browser.Driver?.Navigate().GoToUrl("https://www.saucedemo.com/");

            _loginPage = new LoginPage(_browser);
            
            // инициализация  Allure
            _allure = AllureLifecycle.Instance;
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
            //Проверка что тест упал
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                //var screenshot= Screenshot screenshot;
                // Создание скриншота
                Screenshot screenshot = ((ITakesScreenshot)_browser.Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                //прикрепление скриншота
                _allure.AddAttachment(name: "Screenshot", type: "image/png", screenshotBytes);
            }

            _browser?.Driver?.Close();
        }
    }
}
