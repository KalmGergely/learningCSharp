using System;
using System.Linq;
using Xunit;
using Pirates;

namespace PiratesTest
{
    public class ShipTest
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(3, 3)]
        public void TestAddPirateMethod(int numOfPirates, int expected)
        {
            Ship test = new Ship();

            for (int i = 0; i < numOfPirates; i++)
            {
                Pirate newPirate = new Pirate("pirate");
                test.addPirate(newPirate);
            }

            Assert.Equal(expected, test.GetCrewSize());
        }
    }
}
