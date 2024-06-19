using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Multiplication******");
            Console.Write("Enter a number:  ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
                
            }
            Console.ReadKey();



            Console.WriteLine("*****Finding largest value******");
            Console.WriteLine("Enter three numbers to check the largest value: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine("Largest value is : " + a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Largest value is : " + b);
            }
            else
            {
                Console.WriteLine("Largest value is : " + c);
            }Console.ReadLine();



            Console.WriteLine("*****Reverse of String******");
            Console.WriteLine("enter a String :");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            char d = sb[0];
            sb[0] = sb[sb.Length - 1];
            sb[sb.Length - 1] = d;
            Console.WriteLine("String after swapping first and last characters : " + sb);
            Console.ReadLine();
        }
    }
}
