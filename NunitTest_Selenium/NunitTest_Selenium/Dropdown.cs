using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest_Selenium
{
    [TestFixture]
    public class Dropdown
    {   /// <summary>
        /// Dropdown - Взять все элементы дроп-дауна и проверить их наличие. 
        /// Выбрать первый, проверить, что он выбран, выбрать второй, проверить, что он выбран
        /// </summary>
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");

        }

        [Test]
        public void DropDownTest()
        {
            SelectElement dropdown = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            
            Assert.That(dropdown.Options.Count, Is.EqualTo(3));

            dropdown.SelectByIndex(1);
            var selectedAttribute = dropdown.SelectedOption.GetAttribute("selected");
            
            Assert.IsNotNull(selectedAttribute);

            dropdown.SelectByIndex(2);
            selectedAttribute = dropdown.SelectedOption.GetAttribute("selected");
           
            Assert.IsNotNull(selectedAttribute);

        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
