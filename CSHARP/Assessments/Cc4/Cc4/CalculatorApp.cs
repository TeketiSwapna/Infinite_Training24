using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc4
{
        public delegate int CalculatorOperations(int x, int y);
        class CalculatorApp
        {
            static void Main(string[] args)
            {
                CalculatorOperations add = Add;//instances
                CalculatorOperations subtract = Subtract;
                CalculatorOperations multiply = Multiply;
                Console.Write("Enter first num: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second num: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int sum = add(n1, n2);
                int difference = subtract(n1, n2);
                int product = multiply(n1, n2);

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Which operation do you want to do in the given options + , - , *");
                    char c = char.Parse(Console.ReadLine());
                    if (c == '+')
                    {
                        Console.WriteLine($"Sum: {sum}");
                    }
                    else if (c == '-')
                    {
                        Console.WriteLine($"Difference: {difference}");
                    }
                    else if (c == '*')
                {
                        Console.WriteLine($"Product: {product}");
                    }
                }
                Console.ReadLine();
            }
            static int Add(int x, int y)
            {
                return x + y;
            }

            static int Subtract(int x, int y)
            {
                return x - y;
            }

            static int Multiply(int x, int y)
            {
                return x * y;
            }
        }
    }
