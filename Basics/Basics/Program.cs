using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testMatrix = CreateMatrix(4);
            PrintMatrix(testMatrix);

            Console.ReadKey();
        }

        static int[,] CreateMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 1;
                    } else
                    {
                        matrix[i, j] = 0;
                    }

                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    line += matrix[i, j].ToString();
                }
                Console.WriteLine(line);
            }
        }
    }
}
