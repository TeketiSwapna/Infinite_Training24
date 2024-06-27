using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
    namespace Assignment4
{
    class Exceptionhandling
    {
        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException() : base("Insufficient balance. Withdrawal failed.") { }
        }
        private double balance;
        public Exceptionhandling(double initialBalance)
        {
            this.balance = initialBalance;
        }
        public void Withdraw(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                if (amount > balance)
                {
                    throw new InsufficientBalanceException();
                }

                this.balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully. Remaining balance: {balance}");
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

            catch (InsufficientBalanceException ex)
            {
                throw ex;
            }
        }
        static void Main(string[] args)
        {
            Exceptionhandling account = new Exceptionhandling(1000.0);
            try
            {
                Console.WriteLine("Enter amount to withdraw:");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument Error: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: {ex.Message}");
            }
            
            Console.Read();
        }
    }
}

