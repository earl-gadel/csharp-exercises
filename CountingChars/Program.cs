using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CountingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Earl\Documents\GitHub\csharp-exercises\CountingChars\input.txt";
            string input = File.ReadAllText(path);
            Console.WriteLine(input);

            Dictionary<string, int> counts = new Dictionary<string, int>();
            int value = 1;
                     
            for (int i = 0; i < input.Length; i++)
                if (counts.ContainsKey(input[i].ToString()))
                {
                    counts[input[i].ToString()]++;
                }
                else
                {
                    counts.Add(input[i].ToString(), value);
                }
            foreach (KeyValuePair<string, int> count in counts)
            {
                Console.WriteLine("{0}: {1}", count.Key, count.Value);
            }
            Console.ReadLine();





        }
    }
}
