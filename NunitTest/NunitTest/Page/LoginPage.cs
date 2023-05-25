using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Page
{
    internal class LoginPage : BasePage
    {
        By UserNameInputLocator = By.XPath("//*[@data-test='username']");
        By PassrowdInputLocator = By.CssSelector("#password");
        By LoginButtonLocator = By.Name("login-button");
        By ErrorElement = By.XPath("//*[@data-test='error']");

        public LoginPage() : base() { }

        void SetUserName(string name)
        {
            ChromeDriver.FindElement(UserNameInputLocator).SendKeys(name);
        }

        public string GetErrorMessage()
        {
            return ChromeDriver.FindElement(ErrorElement).Text;
        }

        void SetPasswrod(string password)
        {
            ChromeDriver.FindElement(PassrowdInputLocator).SendKeys(password);
        }

        void ClickLoginButton()
        {
            ChromeDriver.FindElement(LoginButtonLocator).Click();
        }

        public void TryToLogin(User user)
        {
            SetUserName(user.Name);
            SetPasswrod(user.Password);
            ClickLoginButton();
        }

        public InventoryPage Login(User user)
        {
            TryToLogin(user);
            return new InventoryPage();
        }
    }
}

