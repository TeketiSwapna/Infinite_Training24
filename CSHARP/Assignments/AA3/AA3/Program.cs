using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA3
{
    public class Account
    {
        public string AccountNo { get; private set; }
        public string CustomerName { get; private set; }
        public string AccountType { get; private set; }
        public char TransactionType { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string accountNo, string customerName, string accountType, decimal balance)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
            AccountType = accountType;
            Balance = balance;
        }
        public void Credit(decimal amount)

        {
            Balance += amount;
            Console.WriteLine($"Credited {amount}. New balance is {Balance}");
        }
        public void Debit(decimal amount)
        {
            if (amount > Balance)
            {
                Console.Write("Insufficient Bal");

            }
            else
            {
                Balance -= amount;
                Console.Write($"Debited {amount}. New Bal is {Balance}");
            }
        }
        public void UpdateBalance(char transactionType, decimal amount)
        {
            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit(amount);
            }
            else if (transactionType == 'W' || transactionType == 'd')
            {
                Debit(amount);
            }
            else
            {
                Console.Write("Invalid transaction");
            }
        }
        public void ShowData()
        {
            Console.Write($"Account No: {AccountNo}");
            Console.Write($"Customer Name: {CustomerName}");
            Console.Write($"Account Type: {AccountType}");
            Console.Write($"Balance: {Balance}");

        }

        public static void Main(string[] args)
        {
            Account account = new Account("123456", "Rocky", "Savings", 5000);
            account.ShowData();
            account.UpdateBalance('D', 500);
            account.UpdateBalance('W', 200);
            account.ShowData();
            Console.Read();
        }

    }
}


    /* public class Student
     {
         public int rollno;
         public String name;
         public String Studentclass;
         public int Semester;
         public String branch;
         public int[] marks = new int[5];

         public Student(int rollno, String name, String Studentclass, int Semester, String branch)
         {
             this.rollno = rollno;
             this.name = name;
             this.Studentclass = Studentclass;
             this.Semester = Semester;
             this.branch = branch;
         }
         public void getMarks()
         {
             for (int i = 0; i < marks.Length; i++)
             {
                 Console.Write($"Enter Marks for subject {i + 1}:");
                 marks[i] = int.Parse(Console.ReadLine());
             }
         }

         public void DisplayResult()
         {
             int total = 0;
             bool failed = false;

             foreach (int mark in marks)
             {
                 if (mark < 35)
                 {
                     failed = true;
                 }
                 total += mark;
             }
             double average = total / 5.0;
             if (failed || average < 50)
             {
                 Console.Write("Result:failed");
             }
             else
             {
                 Console.Write("Result: passed");
             }
         }

         public void DisplayData()
         {
             Console.Write("Student Details:");
             Console.Write($"Rollno:{rollno}");
             Console.Write($"Name: {name}:");
             Console.Write($"Class: {Studentclass}:");
             Console.Write($"Semester: {Semester}:");
             Console.Write($"Branch: {branch}:");
             Console.Write("Marks:");
             for (int i = 0; i < marks.Length; i++)
             {
                 Console.Write($"Subject {i + 1}:{marks[i]}");
             }
         }
     }
     public class Program
     {
         public static void Main(string[] args)
         {
             Student student = new Student(1, "Rocky", "10th", 2, "Science");
             student.getMarks();
             student.DisplayData();
             student.DisplayResult();

             Console.Read();
         }

     }*/



    /*  public class Salesdetails
      {
          private int Salesno;
          private int Productno;
          private double Price;
          private DateTime DateOfSale;
          private int Qty;
          private double TotalAmount;
          public Salesdetails(int salesno, int productno, double price, DateTime dateofsale, int qty)
          {
              this.Salesno = salesno;
              this.Productno = productno;
              this.Price = price;
              this.DateOfSale = dateofsale;
              this.Qty = qty;
              this.TotalAmount = 0;
          }
          public void Sales()
          {
              this.TotalAmount = this.Qty * this.Price;
          }
          public void ShowData()
          {
              Console.Write($"Sales Number:{this.Salesno}");
              Console.Write($"Product Number:{this.Productno}");
              Console.Write($"Price:{this.Price}");
              Console.Write($"Date of sale:{this.DateOfSale}");
              Console.Write($"Quantity:{this.Qty}");
              Console.Write($"Total Amount:{this.TotalAmount}");
          }
          public static void Main(string[] args)
          {
              Salesdetails sale = new Salesdetails(1, 101, 25.5, DateTime.Today, 3);
              sale.Sales();
              sale.ShowData();
              Console.Read();
          }

      }*/


   /* public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Phone { get; set; }
        public string City { get; set; }

        public Customer()
            { 
            CustomerId = 0;
            Name= string.Empty;
            Age=0;
            Phone = double.MaxValue;
            City = string.Empty;
        }

        public Customer(int customerId, string name, int age,  double phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.Write("Customer Information:");
            Console.Write($"ID:{customer.CustomerId}");
            Console.Write($"Name:{customer.Name}");
            Console.Write($"Age:{ customer.Age}");
            Console.Write($"Phone:{ customer.Phone}");
            Console.Write($"City:{ customer.City}");

        }
        ~Customer()
        {
            Console.Write("Destructor called for customer");
        }


    }

    class Program
    { 
        static void Main(string[] args)
    {
            Customer customer = new Customer(1, "Rocky", 30, 9000004847, "Australia");
            Customer.DisplayCustomer(customer);
            Customer customer2 = new Customer();
            Customer.DisplayCustomer(customer2);

        Console.Read();
    }
    }*/








