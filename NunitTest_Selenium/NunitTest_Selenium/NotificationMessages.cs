using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest_Selenium
{ /// <summary>
  ///.Notification Messages - кликнуть на кнопку,
  ///дождаться появления нотификации, проверить соответствие текста ожиданиям
  /// </summary>
    [TestFixture]
    public class NotificationMessages
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/notification_message_rendered");

        }
        [Test]
        public void NotificationMessagesTest()
        {
           // var expectedMessage = $"Action successful\n+×";
            var linkButton = ChromeDriver.FindElement(By.CssSelector(".example a"));
            linkButton.Click();
            var flashElement = ChromeDriver.FindElement(By.Id("flash"));
     
            Assert.That(flashElement.Text, Is.EqualTo("Action successful\r\n×"));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}

