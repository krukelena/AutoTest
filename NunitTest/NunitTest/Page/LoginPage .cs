using OpenQA.Selenium;
using Core.Selenium;
using Core.Wrappers;
using OpenQA.Selenium.Support.UI;
using Core.Models;

namespace NunitTest.Page
{
    public class LoginPage : BasePage
    {
        private static readonly By UserNameInputLocator = By.XPath("//*[@data-test='username']");
        private static readonly By PasswordInputLocator = By.CssSelector("#password");
        private static readonly By LoginButtonLocator = By.Name("login-button");
        private static readonly By ErrorElementLocator = By.XPath("//*[@data-test='error']");


        public LoginPage(IBrowser browser) : base(browser) { }


        public Input UsernameInputElement
        {
            get { 
                return new Input(
                    _browser?.Driver?.FindElement(UserNameInputLocator)
                ); 
            }
            private set { }
        }

        public Input PasswordInputElement
        {
            get
            {
                return new Input(
                    _browser?.Driver?.FindElement(PasswordInputLocator)
                );
            }
            private set { }
        }

        public Button LoginButton
        {
            get
            {
                return new Button(
                    _browser?.Driver?.FindElement(LoginButtonLocator)
                );
            }
            private set { }
        }

        public IWebElement? ErrorElement
        {
            get => _browser.Driver?.FindElement(ErrorElementLocator);
            private set { }
        }



        public InventoryPage SuccessfullyLogIn(User user)
        {
            LogIn(user);

            return new InventoryPage(_browser);
        }

        public LoginPage IncorrrectLogIn(User user)
        {
            LogIn(user);

            return this;
        }

        private void LogIn(User user)
        {
            EnterUsername(user.Username)
                .EnterPassword(user.Password)
                .ClickLoginButton();
        }


        public LoginPage EnterUsername(String username)
        {
            UsernameInputElement.SetValue(username);

            return this;
        }

        public LoginPage EnterPassword(String password) { 
            PasswordInputElement.SetValue(password);

            return this;
        }

        public LoginPage ClickLoginButton()
        {
            LoginButton.Click();

            return this;
        }

        public String? GetErrorMessage()
        {
            return ErrorElement?.Text;
        }


        protected override void OpenPage()
        {
            throw new NotImplementedException();
        }

        public override bool IsPageOpened()
        {
            try
            {
                return LoginButton.WebElement?.Displayed ?? false;
            }
            catch { 
                return false;
            }
        }
    }
}

