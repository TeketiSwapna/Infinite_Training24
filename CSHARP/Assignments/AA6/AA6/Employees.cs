using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA6
{
    class Employees
    {
            class Employee
            {
                public int EmpId { get; set; }
                public string EmpName { get; set; }
                public string EmpCity { get; set; }
                public decimal EmpSalary { get; set; }
            }
            static void Main()
            {
                Employee[] employees = new Employee[]
                {
            new Employee { EmpId = 101, EmpName = "Reddy", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employee { EmpId = 102, EmpName = "Gopi", EmpCity = "Mumbai", EmpSalary = 50000 },
            new Employee { EmpId = 103, EmpName = "Priya", EmpCity = "Bangalore", EmpSalary = 43000 },
            new Employee { EmpId = 104, EmpName = "Karishma", EmpCity = "Delhi", EmpSalary = 48000 },
            new Employee { EmpId = 105, EmpName = "Chandu", EmpCity = "Chennai", EmpSalary = 53000 }
                };

                Console.WriteLine("All Employees:");
                DisplayEmployees(employees);

                Console.WriteLine("\nEmployees with Salary > 45000:");
                DisplayEmployeesWithSalaryAbove(employees, 45000);

                Console.WriteLine("\nEmployees from Bangalore:");
                DisplayEmployeesFromCity(employees, "Bangalore");

                Console.WriteLine("\nEmployees sorted by Name (Ascending):");
                Array.Sort(employees, (x, y) => string.Compare(x.EmpName, y.EmpName));
                DisplayEmployees(employees);
            }
            static void DisplayEmployees(Employee[] employees)
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                    Console.ReadLine();
                }
            }
            static void DisplayEmployeesWithSalaryAbove(Employee[] employees, decimal salaryThreshold)
            {
                foreach (var emp in employees)
                {
                    if (emp.EmpSalary > salaryThreshold)
                    {
                        Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                        Console.ReadLine();
                    }
                }
            }


            static void DisplayEmployeesFromCity(Employee[] employees, string city)
            {
                foreach (var emp in employees)
                {
                    if (emp.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
