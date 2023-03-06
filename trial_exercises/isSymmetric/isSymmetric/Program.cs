using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isSymmetric
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] trueInput =
            {
                new int[]{1,0,1},
                new int[]{0,2,2},
                new int[]{1,2,5}
            };

            int[][] falseInput =
            {
                new int[]{1,1,1},
                new int[]{0,2,2},
                new int[]{1,2,5}
            };

            Console.WriteLine(isSymmetric(trueInput));
            Console.WriteLine(isSymmetric(falseInput));
            Console.ReadKey();
        }

        public static Boolean isSymmetric(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] != array[j][i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
