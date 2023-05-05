using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest_Selenium
{
    ///Проверить 
    /// на возможность ввести различные цифровые и нецифровые значения, 
    ///используя Keys.ARROW_UP  И Keys.ARROW_DOWN 

    [TestFixture]
    public class Inputs
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");

        }

        [Test]
        public void InputsTest()
        {
            var inputElement = ChromeDriver.FindElement(By.TagName("input"));
            inputElement.SendKeys(Keys.ArrowUp);

            var inputAttribute = inputElement.GetAttribute("value");
            
            Assert.That(inputAttribute, Is.EqualTo("1"));

            for (int i = 0; i < 10; i++)
            {
                inputElement.SendKeys(Keys.ArrowDown);
            }
           
            Assert.That(inputAttribute, Is.EqualTo("-9"));
            
            inputElement.SendKeys("vklbndklfg&*dsd");
           
            Assert.That(inputAttribute, Is.EqualTo("-9"));
        }

        [TearDown]
        public void TearDown() 
        {
            ChromeDriver.Quit();
        }
    }
}
