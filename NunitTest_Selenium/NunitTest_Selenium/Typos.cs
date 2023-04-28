using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest_Selenium
{
    [TestFixture]
    public class Typos
    {
        WebDriver ChromeDriver { get; set; }


        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/typos");

        }

        [Test]
        public void TyposTest()
        {
            var typosElement = ChromeDriver.FindElements(By.TagName("p"))[1];
            
            Assert.That(typosElement.Text, Is.EqualTo("Sometimes you'll see a typo, other times you won't."));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }

    }
}
