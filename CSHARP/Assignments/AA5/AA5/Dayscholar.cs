using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA5
{
public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Type: Dayscholar");
            Console.Read();
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Type: Resident");
            Console.Read();
        }
    }


    class Student
    {
        static void Main()
        {
            
            IStudent student1 = new Dayscholar { StudentId = 101, Name = "Reethu" };
            IStudent student2 = new Resident { StudentId = 201, Name = "Riya" };

            Console.WriteLine("Details of Dayscholar:");
            student1.ShowDetails();
            Console.WriteLine();
            Console.Read();

            Console.WriteLine("Details of Resident:");
            student2.ShowDetails();
        }
    }

}

