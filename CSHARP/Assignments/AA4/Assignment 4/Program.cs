using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Program(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public static void Display(string firstName, string lastName)
        {
            Console.Write(firstName.ToUpper());
            Console.Write(lastName.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first name:");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name:");
            string lastName = Console.ReadLine();

            Program program = new Program(firstName, lastName);
            Program.Display(program.FirstName, program.LastName);


            Console.Read();
        }
    }
}
