namespace NunitTest
{
    [TestFixture]
    public class TestsClass1
    {
        //int randomInt;
        Calculator calculator;

        [OneTimeSetUp]
        public void SetForClass()
        {
            //randomInt= new Random().Next(0,10);
            calculator = new Calculator();
        }

        [SetUp]
        public void SetupForEachMetods()
        {
           // randomInt = new Random().Next(0, 10);
        }

        //[TestCase(1, 5, ExpectedResult = 6)]
        //[TestCase(-3, 6, ExpectedResult = 3)]
        //[TestCase(-3, -6, ExpectedResult = 3)]
        //[TestCase(3, 6, ExpectedResult = 9)]
        [Retry(2)]
        [Test]
        public void SummTest([Values(1, 1)] int x, 
            [Range(10, 20, 2)] int y)
        {

            //Action
           var actualResult = calculator.Summ(x, y);
            //Assert
            //Assert.AreEqual(actualResult, actualResult - 1, $"Result Failed");
            //Assert.That(actualResult,Is.EqualTo(actualResult),$"Summ {x}+{y}={actualResult}");
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