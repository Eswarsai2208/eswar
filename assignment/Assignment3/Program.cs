using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Accounts
    {
        private int accountNumber;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;
        public Accounts(int accNo, string custName, string accType)
        {
            accountNumber = accNo;
            customerName = custName;
            accountType = accType;
            balance = 0;
        }
        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type : {accountType}");
            Console.WriteLine($"Balance      : {balance:C}");
        }
        public void Credit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }
        public void Debit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
        }
    }
    class MainProgram
    {
        static void Main()
        {
            Accounts acc = new Accounts(637959230, "Eswarsai", "Salaried");
            acc.ShowData();
            acc.Credit(1000);
            acc.Debit(500);
            acc.ShowData();
        }
    }


}
