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
    internal class Checkboxes
    {
        WebDriver ChromeDriver { get; set; }


        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");
        }
        [Test]
        public void CheckBoxesTest()
        {
            var checkboxElements = ChromeDriver.FindElements(By.CssSelector("[type = checkbox]"));

            var firstCheckbox = checkboxElements[0];
            var secondCheckbox = checkboxElements[1];

            var firstCheckboxAttribute = firstCheckbox.GetAttribute("checked");
            Assert.IsNull(firstCheckboxAttribute);

            firstCheckbox.Click();

            firstCheckboxAttribute = firstCheckbox.GetAttribute("checked");
            Assert.IsNotNull(firstCheckboxAttribute);

            var secondCheckboxAttribute = secondCheckbox.GetAttribute("checked");
            Assert.IsNotNull(secondCheckboxAttribute);

            secondCheckbox.Click();

            secondCheckboxAttribute = secondCheckbox.GetAttribute("checked");
            Assert.IsNull(secondCheckboxAttribute);

        }
        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }

    }
}
