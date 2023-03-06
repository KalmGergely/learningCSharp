using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace getTwoMostCommonCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> test =  getTwoMostCommonCharacters(@"C:\Users\kalmg\greenfox\learningCSharp\trial_exercises\isSymmetric\countchar.txt");

            foreach (var key in test.Keys)
            {
                Console.WriteLine("key: " + key);
                Console.WriteLine("value: " + test[key]);
            }
            Console.ReadKey();
        }

        static Dictionary<string, int> getTwoMostCommonCharacters(string filepath)
        {
            string fileContent;
            List<string> fileChars = new List<string>();
            Dictionary<string, int> allCharsDict = new Dictionary<string, int>();

            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filepath))
                {
                    fileContent = reader.ReadToEnd();
                }
                string[] fileLines = fileContent.Split('\n');

                for (int i = 0; i < fileLines.Length; i++)
                {
                    string line = fileLines[i];
                    
                    for (int j = 0; j < line.Length; j++)
                    {
                        fileChars.Add(line[j].ToString());
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();
            }

            for (int i = 0; i < fileChars.Count; i++)
            {
                if (allCharsDict.ContainsKey(fileChars[i]))
                {
                    allCharsDict[fileChars[i]] += 1;
                } else
                {
                    allCharsDict[fileChars[i]] = 1;
                }
            }

            List<KeyValuePair<string, int>> listOfPairs = allCharsDict.ToList();

            listOfPairs.Sort((pair1, pair2) => pair2.Value - pair1.Value);

            Dictionary<string, int> result = new Dictionary<string, int>();

            result.Add(listOfPairs[0].Key, listOfPairs[0].Value);
            result.Add(listOfPairs[1].Key, listOfPairs[1].Value);

            return result;
        }
    }
}
