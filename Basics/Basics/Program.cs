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

            Console.WriteLine("----");

            int[][] testJaggedMatrix = CreateJaggedMatrix(4);
            PrintJaggedMatrix(testJaggedMatrix);

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
                    }
                    else
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

        //JAGGED MATRIX SOLUTION
        static int[][] CreateJaggedMatrix(int size)
        {
            int[][] matrix = new int[size][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[size];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j)
                    {
                        matrix[i][j] = 1;
                    } else
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            return matrix;
        }

        static void PrintJaggedMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                string line = "";
                int[] row = matrix[i];

                for (int j = 0; j < row.Length; j++)
                {
                    line += row[j].ToString();
                }
                Console.WriteLine(line);
            }
        }
    }
}
