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

            Console.WriteLine("Enter something:");
            string input = Console.ReadLine();
            File.WriteAllText(path, input);
            string openFile = File.ReadAllText(path);
            Dictionary<string, int> counts = new Dictionary<string, int>();
            int value = 1;
                     
            for (int i = 0; i < openFile.Length; i++)
                if (counts.ContainsKey(openFile[i].ToString()))
                {
                    counts[openFile[i].ToString()]++;
                }
                else
                {
                    counts.Add(openFile[i].ToString(), value);
                }
            foreach (KeyValuePair<string, int> count in counts)
            {
                Console.WriteLine("{0}: {1}", count.Key, count.Value);
            }
            Console.ReadLine();





        }
    }
}
