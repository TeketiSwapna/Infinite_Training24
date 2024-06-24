using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA3
{
    public class Accounts
    {
        // Data members/fields
        private string accountNo;
        private string customerName;
        private string accountType;
        private int balance;

        // Constructor to initialize account details
        public Accounts(string accountNo, string customerName, string accountType, int initialBalance = 0)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = initialBalance;
        }

        // Method to deposit amount
        public void Credit(int amount)
        {
            balance += amount;
            Console.WriteLine("Amount deposited: " + amount);
            Console.WriteLine("New balance: " + balance);
        }

        // Method to withdraw amount
        public void Debit(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance. Current balance: " + balance);
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Amount withdrawn: " + amount);
                Console.WriteLine("New balance: " + balance);
            }
        }

        // Method to update balance based on transaction type
        public void UpdateBalance(char transactionType, int amount)
        {
            if (transactionType == 'd' || transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'w' || transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Use 'd' for deposit and 'w' for withdrawal.");
            }
        }

        // Override the ToString method to display account details
        public override string ToString()
        {
            return $"Account No: {accountNo}\nCustomer Name: {customerName}\nAccount Type: {accountType}\nBalance: {balance}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an account with initial details
            Accounts account = new Accounts("564321890", "Rocky", "Savings", 10000);

            // Display account details using ToString method
            Console.WriteLine(account);

            // Perform deposit and withdrawal transactions
            account.UpdateBalance('d', 5000);   // Deposit 500
            account.UpdateBalance('w', 2000);   // Withdraw 200
            account.UpdateBalance('w', 2000);  // Attempt to withdraw 2000

            // Display updated account details using ToString method
            Console.WriteLine(account);
            Console.Read();
        }
    }
}







