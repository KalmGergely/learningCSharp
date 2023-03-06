using System;
using System.Linq;
using Xunit;
using isSymmetric;

namespace isSymmetricTest
{
    public class isSymmetricTest
    {
        Program program;

        [Fact]
        public void TestMethodWithTrueInput()
        {

            int[][] trueInput =
             {
                new int[]{1,0,1},
                new int[]{0,2,2},
                new int[]{1,2,5}
            };

            Boolean result = Program.isSymmetric(trueInput);

            Assert.True(result);
        }

        [Fact]
        public void TestMethodWithFalseInput()
        {

            int[][] falseInput =
            {
                new int[]{1,1,1},
                new int[]{0,2,2},
                new int[]{1,2,5}
            };

            Boolean result = Program.isSymmetric(falseInput);

            Assert.False(result);
        }
    }
}
