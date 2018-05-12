using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"Lorem ipsum dolor sit amet, consectetur 
                adipiscing elit. Nunc accumsan sem ut ligula scelerisque 
                sollicitudin. Ut at sagittis augue. Praesent quis rhoncus 
                justo. Aliquam erat volutpat. Donec sit amet suscipit 
                metus, non lobortis massa. Vestibulum augue ex, dapibus ac 
                suscipit vel, volutpat eget massa. Donec nec velit non 
                ligula efficitur luctus.";
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
