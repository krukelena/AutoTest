using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    [TestFixture]
    public class TestsClass2
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
        [Test, Category("UnitTest2"), Description("Метод разности")]
        [TestCase(6, 5, ExpectedResult = 1)]
        [TestCase(3, 6, ExpectedResult = -3)]
        [TestCase(-3, -6, ExpectedResult = 3)]
        [TestCase(6, 2, ExpectedResult = 4)]
        public int MinusTest(int x, int y)
        {

            //Action
            var actualResult = calculator.Minus(x, y);

            return actualResult;
            //Assert
            Assert.That(actualResult, Is.EqualTo(actualResult), $"Summ {x}+{y}={actualResult}");
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
