using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Calculator
{
    [TestFixture]
    public class TestsClass3
    {
        //int randomInt;
        Calculator calculator;

        [OneTimeSetUp]
        public void SetForClass()
        {
            //randomInt = new Random().Next(0, 10);
            calculator = new Calculator();
        }

        [SetUp]
        public void SetupForEachMetods()
        {
            //randomInt = new Random().Next(0, 10);
        }
        [Test, Category("UnitTest3"), Description("Метод деления")]
        [TestCase(10, 5, ExpectedResult = 2)]
        [TestCase(-6, 6, ExpectedResult = -1)]
        [TestCase(15, 5, ExpectedResult = 3)]
        [TestCase(30, 6, ExpectedResult = 9)]

        public int DivedieTest(int x, int y)
        {

            //Action
            var actualResult = calculator.Divedie(x, y);
            return actualResult;
            //Assert
            //Assert.AreEqual(actualResult, actualResult-1, $"Result Failed");
            //Assert.That(actualResult, Is.EqualTo(actualResult), $"Summ {x}+{y}={actualResult}");
        }
        [TearDown]

        public void TearDown()
        {

        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
