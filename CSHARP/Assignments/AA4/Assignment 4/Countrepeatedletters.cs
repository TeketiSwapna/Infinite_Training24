using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Countrepeatedletters
    {
          public static void Main()
        {

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Convert.ToChar(Console.ReadLine());
            int count = 0;
            foreach (char c in input)
            {
                if (c == letterToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the string.");
            Console.ReadLine();
        }
    }
}
