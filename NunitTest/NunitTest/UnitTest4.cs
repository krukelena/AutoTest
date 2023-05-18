using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    [TestFixture]
    public class TestsClass4
    {
        int randomInt;
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

        [Test, Category("UnitTest"), Description("Метод умножения")]

        [Test, Category("UnitTest4"), Description("Метод умножения")]

        [TestCase(10, 5, ExpectedResult = 50)]
        [TestCase(-6, 6, ExpectedResult = -1)]
        [TestCase(1, 5, ExpectedResult = 5)]
        [TestCase(2, 6, ExpectedResult = 12)]
        public int MultiplicyTest(int x, int y)
        {

            //Action
            var actualResult = calculator.Multiplicy(x, y);

            return actualResult;
            //Assert
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


