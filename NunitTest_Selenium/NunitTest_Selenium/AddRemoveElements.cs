using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace NunitTest_Selenium
{
   
    [TestFixture]
    public class AddRemoveElements
    {
        WebDriver ChromeDriver { get; set; }
       
        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");

        }

        [Test]
        public void AddRemoveElementTest()
        {
          
            IWebElement addElement = ChromeDriver.FindElement(By.XPath("//button[text()='Add Element']"));
            addElement.Click();
            var elementsAttributa = addElement.GetAttribute("elements");
            addElement.Click();

            IWebElement deleteElement = ChromeDriver.FindElement(By.XPath("//button[text()='Delete']"));
            deleteElement.Click();

            var elements = ChromeDriver.FindElements(By.XPath("//button[text()='Delete']"));
            int count = elements.Count;

            Assert.That(count, Is.EqualTo(1));
       
        }

        [TearDown]
        public void TearDown()
        {
           ChromeDriver.Quit();
        }
    }
}