using System;
using System.Linq;
using Xunit;
using Pirates;

namespace PiratesTest
{
    public class PirateTest
    {
        [Fact]
        public void TestPiratesWorkMethod()
        {
            Pirate testCase = new Pirate("TestPirate");

            testCase.Work();
            testCase.Work();

            Assert.Equal(2, testCase.GetGoldAmount());
        }
    }
}
