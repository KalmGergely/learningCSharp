using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures_FileIO_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> baseInput = handleInput("Base 2 Power 4");
            WriteFile(baseInput);
            List<int> baseAndPower = ReadNums();
            int result = toThePowerOf(baseAndPower);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static Dictionary<string, int> handleInput(string input)
        {
            string[] inputWords =  input.Split(' ');

            Dictionary<string, int> result = new Dictionary<string, int>();

            result[inputWords[0]] = Convert.ToInt32(inputWords[1]);
            result[inputWords[2]] = Convert.ToInt32(inputWords[3]);

            return result;
        }

        static void WriteFile(Dictionary<string, int> baseAndPower)
        {
            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\kalmg\greenfox\learningCSharp\DataStructures_FileIO_Recursion\content.txt"))
                {
                    foreach (var pair in baseAndPower)
                    {
                        writer.WriteLine(pair.Value.ToString());
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("File not found!");
                Console.ReadLine();
            }
        }

        static List<int> ReadNums()
        {
            List<int> result = new List<int>();
            
            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\kalmg\greenfox\learningCSharp\DataStructures_FileIO_Recursion\content.txt"))
                {
                    String data = reader.ReadLine();
                    while (data != null)
                    {
                        result.Add(Convert.ToInt32(data));
                        data = reader.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found!");
                Console.ReadLine();
            }

            return result;
        }

        static int toThePowerOf(List<int> baseAndPower)
        {
            if (baseAndPower[1] == 0)
            {
                return 1;
            } else
            {
                baseAndPower[1] -= 1;

                return baseAndPower[0] * toThePowerOf(baseAndPower);
            }
        }
    }
}
