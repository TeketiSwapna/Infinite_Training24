using System;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        { 
            /* Console.WriteLine("Enter value 1:");
             int value1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enetr value 2:");
             int value2 = int.Parse(Console.ReadLine());
             if (value1==value2)
             {
                 Console.WriteLine("Both numbers are equal");
             }
             else
             {
                 Console.WriteLine("Both numbers are not euqal");
             }
             Console.ReadLine();*/







            /*Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("Given number is even");
            }
            else
            {
                Console.WriteLine("Given number is odd");
            }
            Console.ReadLine();*/




            /*Console.WriteLine("Enter value a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b:");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int division = 0;
            int subtraction = a - b;
            int product = a * b;
            if (b != 0)
            {
                division = a / b;
            }
            Console.WriteLine("Results:");
            Console.WriteLine($"{a}+{b}={sum}");
            Console.WriteLine($"{a}-{b}={subtraction}");
            Console.WriteLine($"{a}*{b}={product}");
            if (b != 0)
            {
                Console.WriteLine($"{a}/{b}={division}");

            }

            Console.ReadLine();*/


            int n1, n2, temp;
            Console.WriteLine("enter the first number:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBefore swapping:");
            Console.WriteLine("first number: " + n1);
            Console.WriteLine("second number: " + n2);

            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("first number: " + n1);
            Console.WriteLine("second number: " + n2);

            Console.ReadLine();

        }
    }
}