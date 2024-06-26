using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc2.Properties
{
    class Exception
    {
        static void Main()
        {
            try
            {

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                CheckIfNegative(number);
                
            } 
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid integer.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                
            }
            Console.Read();
        }
        static void CheckIfNegative(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Negative numbers are not allowed.");
            }
        }
    }

}

