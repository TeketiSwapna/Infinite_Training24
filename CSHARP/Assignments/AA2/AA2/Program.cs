using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first integer:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second integer:");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = n1 + n2;

            if (n1 == n2)
            {
                Console.WriteLine($"CalucateResult: {n3 * 3}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"CalucateResult: {n3}");

            }


            Console.WriteLine("*******Dayy**********");
            Console.WriteLine("Enter a day number*");
            int daynumber = int.Parse(Console.ReadLine());
            switch (daynumber)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("The entered daynum is invalid");
                    break;
            }
            Console.Read();



            Console.WriteLine("*******length of string********");
            Console.WriteLine("enter a string: ");
            Console.Read();
            String word = Console.ReadLine();
            Console.WriteLine("Lenth of given word=" + word.Length);
            Console.ReadLine();



            Console.WriteLine("******* strings are same or not********");
            Console.WriteLine("Enter a string1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter a string2");
            string str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }


            Console.WriteLine("*******Reverse of string********");
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string rev = "";
            for (int i = 0; i < s.Length; i++)
            {
                rev = s[i] + rev;
            }

            Console.WriteLine("after reversing " + rev);

            Console.Read();



            Console.WriteLine("*****min, max, avg of arr*****");

            int[] arr = { 10, 30, 6, 0, 80, 1 };

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Average());
            Console.ReadLine();


             Console.WriteLine("*****same array to copy another*****");
             int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
             int[] arr2 = new int[arr1.Length];
             for (int i = 0; i < arr1.Length; i++)
             {
                 arr2[i] = arr1[i];
             }
             Console.WriteLine("Elements of original array");
             for (int i = 0; i < arr1.Length; i++)
             {
                 Console.Write(arr1[i] + "");


             }
             Console.WriteLine();
             Console.WriteLine("Elements of new array");
             for (int i = 0; i < arr2.Length; i++)
             {
                 Console.Write(arr2[i] + "");
             }
             Console.Read();


            Console.Write("Enter the size of an array ");
            //Console.WriteLine();
            int size = int.Parse(Console.ReadLine());
            int[] arr3 = new int[size];
            Console.WriteLine("Enter the {0} elements :", size);
            for (int i = 0; i < size; i++)
            {
                arr3[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum is :");
            Console.WriteLine(arr3.Sum());

            Console.WriteLine("Average is :");
            Console.WriteLine(arr3.Average());

            Console.WriteLine("Minimum is :");
            Console.WriteLine(arr3.Min());

            Console.WriteLine("Maximum is is :");
            Console.WriteLine(arr3.Max());

            Array.Sort(arr3);
            Console.WriteLine("Ascending Order is :");
            foreach (int i in arr3)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();

            Array.Reverse(arr3);
            Console.WriteLine("Descending Order is :");
            foreach (int i in arr3)
            {
                Console.Write($" {i} ");
            }

        }
    }
    }

