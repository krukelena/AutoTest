using Allure.Commons;
using Core.Models;
using Core.Models.Builders;
using NUnit.Allure.Attributes;
using NunitTest.Page;
using NunitTest.Test.SwagLabs;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNunitTest.Test.SwagLabs
{
    [TestFixture]
    internal class LoginTests : BaseTest
    {
        [Test(Description= "Успешный логин")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("User1")]
        [AllureSuite("PassedSuite")]
        [AllureIssue(name:"ID")]
        [AllureTag("Smoke")]
        [Description("Подробное описание теста")]
      
        [Category("Pasitive")]
        public void SuccessfullyLogIn()
        {
            _loginPage
                .SuccessfullyLogIn(new User {
                    Username = "standard_user",
                    Password = "secret_sauce"
                })
                .ClickCartIcon();

            Thread.Sleep(2000);
        }

        [Test(Description = "Неверный пароль")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("User2")]
        [AllureSuite("PassedSuite")]
        [AllureIssue(name: "ID2")]
        [AllureTag("Smoke")]
        [Description("Подробное описание теста")]
        
        [Category("Negative")]
        public void Test_ErrorMessage()
        {
            _loginPage
                .IncorrrectLogIn(new User {
                    Username = "standard",
                    Password = "secret_"
                });

            Assert.That(
                _loginPage.GetErrorMessage(), 
                Is.EqualTo("Epic sadface: Username and password do not match any user in this service")
            );
        }

        [Test(Description = "Переход на страницу")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("User2")]
        [AllureSuite("PassedSuite")]
        [AllureIssue(name: "ID2")]
        [AllureTag("Smoke")]
        [Description("Подробное описание теста")]
        
        [Category("Negative")]
        public void Test1()
        {
            if(!_loginPage.IsPageOpened())
            {
                Assert.Fail("Page not opened!");
                return;
            }

            UserBuilder userBuilder = new UserBuilder();
            User user = userBuilder
                .SetUsername("standard_user")
                .SetPassword("secret_sauce")
                .Build();

            _loginPage
                .SuccessfullyLogIn(user)
                .ClickMenuButton()
                .ClickFilterDropdown()
                .ClickCartIcon();
        }
    }
}
