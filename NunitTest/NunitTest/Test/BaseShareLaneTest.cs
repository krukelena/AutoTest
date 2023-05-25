using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Test.ShareLane
{
    internal class BaseShareLaneTest : BaseTest
    {
        [SetUp]
        public void SetUp() 
        {
            ChromeDriver.Navigate().GoToUrl("");
        }
    }
}
