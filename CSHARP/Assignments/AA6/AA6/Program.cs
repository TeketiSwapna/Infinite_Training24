using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA6
{
    class Program
    {
        public static void Main()
        {
            // Part 1: Squares of numbers greater than 20
            Console.WriteLine("enter number:");
            Console.ReadLine();
            int[] num = { 7, 2, 30 };
            foreach (int n in num)
            {
                int square = n * n;
                if (square > 20)
                {
                    Console.WriteLine($"{n} - {square}");
                }
            }
            Console.WriteLine("-----2nd program-----:");

            Console.WriteLine("enter the strings:");
            Console.ReadLine();
            List<string> words = new List<string> { "mum", "amsterdam", "bloom" };
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char firstChar = char.ToLower(word[0]);
                    bool startsWithA = (firstChar == 'a');
                    char lastChar = char.ToLower(word[word.Length - 1]);
                    bool endsWithM = (lastChar == 'm');

                    if (startsWithA && endsWithM)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
