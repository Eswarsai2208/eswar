using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() { }

        public InsufficientBalanceException(string message)
            : base(message) { }

        public InsufficientBalanceException(string message, Exception innerException)
            : base(message, innerException) { }
    }
    public class BankingSystem
    {
        private decimal balance;

        public BankingSystem(decimal initialBalance)
        {
            balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }
            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {balance}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. New balance: {balance}");
            Console.Read();
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
    class Program3
    {
        static void Main()
        {
            try
            {
                BankingSystem account = new BankingSystem(100);
                account.Deposit(100);
                account.Withdraw(100);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }

}
