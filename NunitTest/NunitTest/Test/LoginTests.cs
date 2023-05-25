using Core.Models;
using Core.Models.Builders;
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
       
        [Test, Category("Positive")]
        public void Test()
        {
            _loginPage
                .SuccessfullyLogIn(new User {
                    Username = "standard_user",
                    Password = "secret_sauce"
                })
                .ClickCartIcon();

            Thread.Sleep(2000);
        }

        [Test, Category("Negative")]
        public void Test_ErrorMessage()
        {
            _loginPage
                .IncorrrectLogIn(new User {
                    Username = "standard",
                    Password = "secret_sauce"
                });

            Assert.That(
                _loginPage.GetErrorMessage(), 
                Is.EqualTo("Epic sadface: Username and password do not match any user in this service")
            );
        }

        [Test]
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
