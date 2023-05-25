using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Test.ShareLane
{
    internal class LoginTests
    {
        internal class LoginTests : BaseShareLaneTest
        {
            [Test]
            public void EnvVariablesExample()
            {
                Environment.SetEnvironmentVariable("Test1", "Value1");
                var value = Environment.GetEnvironmentVariable("Test1");

                // Now retrieve it.
                value = Environment.GetEnvironmentVariable("Browser", EnvironmentVariableTarget.Machine);

            }

            [Test, Category("Positive")]
            public void Login_LoginWithCorrect_Credentialst()
            {
                var standartUser = UserBuilder.StandartUser;

                string expectedUrl = "https://www.saucedemo.com/inventory.html";

                var inventoryPage = LoginPage.Login(standartUser);

                Assert.IsTrue(inventoryPage.CheckCartIconPresented());
                Assert.AreEqual(Browser.Instance.Driver.Url, expectedUrl);
            }

            [Test, Category("Negative")]
            public void Login_EmptyPasswordNameFieldTest_CheckErrorMessage()
            {
                string errorMessage = "Epic sadface: Password is required";

                var user = UserBuilder.GetRandomUser();

                LoginPage.TryToLogin(user);

                var error = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-test='error']"));

                Assert.Multiple(() =>
                {
                    Assert.AreEqual(error.Text, errorMessage);
                    Assert.IsTrue(error.Displayed);
                });
            }

            [Test, Category("Negative")]
            public void Login_EmptyUserNameFieldTest_CheckErrorMessage()
            {
                string errorMessage = "Epic sadface: Username is required";


                var user = new User
                {
                    Password = "123",
                    Name = "",
                };

                user.Name = "123123132";

                LoginPage.TryToLogin(user);

                var error = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-test='error']"));

                Assert.Multiple(() =>
                {
                    Assert.AreEqual(error.Text, errorMessage);
                    Assert.IsTrue(error.Displayed);
                });
            }
        }
    }
}

