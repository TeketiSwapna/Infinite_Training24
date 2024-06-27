using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Scholarship
    {
            public double Merit(double marks, double fees)
            {
                double scholarshipAmount = 0;

                if (marks >= 70 && marks <= 80)
                {
                    scholarshipAmount = 0.2 * fees;
                }
                else if (marks > 80 && marks <= 90)
                {
                    scholarshipAmount = 0.3 * fees;
                }
                else if (marks > 90)
                {
                    scholarshipAmount = 0.5 * fees;
                }

                return scholarshipAmount;
            }

            public static void Main()
            {
                Scholarship scholarship = new Scholarship();


                Console.Write("Enter marks: ");
                double marks = double.Parse(Console.ReadLine());

                Console.Write("Enter fees: ");
                double fees = double.Parse(Console.ReadLine());

                double amount = scholarship.Merit(marks, fees);

                Console.WriteLine("Scholarship amount: $" + amount);

                Console.ReadLine();
            }
        }
    }


