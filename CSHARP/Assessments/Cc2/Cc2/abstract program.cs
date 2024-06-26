using System;
namespace Cc2
{
    public abstract class Student
    {

        public string name;
        public int studentId;
        public double grade;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        protected Student(string name, int studentId, double grade)
        {
            this.name = name;
            this.studentId = studentId;
            this.grade = grade;
        }
        public abstract bool IsPassed();
    }
    public class Ug : Student
    {
        public Ug(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }
        public override bool IsPassed()
        {
            return Grade > 70.0;
        }
    }
    public class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }
        public override bool IsPassed()
        {
            return Grade > 80.0;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Ug undergrad = new Ug("Divya", 101, 71.0);
            Console.WriteLine($"{undergrad.Name} with Student ID {undergrad.StudentId} has {(undergrad.IsPassed() ? "passed" : "not passed")}.");

            Graduate grad = new Graduate("Deeksha", 201, 79.0);
            Console.WriteLine($"{grad.Name} with Student ID {grad.StudentId} has {(grad.IsPassed() ? "passed" : "not passed")}.");
            Console.ReadKey();
        }
    }
}