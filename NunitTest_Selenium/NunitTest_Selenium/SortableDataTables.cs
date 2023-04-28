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
    public class SortableDataTables
    {
        WebDriver ChromeDriver { get; set; }


        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");

        }
        [Test]
        public void SortableDataTablesTest()
        {
            var element = ChromeDriver.FindElement(By.XPath("//tbody/tr[1]/td[1]"));
            Assert.That(element.Text, Is.EqualTo("Smith"));
            element = ChromeDriver.FindElement(By.XPath("//tbody/tr[2]/td[1]"));
            Assert.That(element.Text, Is.EqualTo("Bach"));
            element = ChromeDriver.FindElement(By.XPath("//tbody/tr[4]/td[2]"));
            Assert.That(element.Text, Is.EqualTo("Tim"));
        }
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }

}
