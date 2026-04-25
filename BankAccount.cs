using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WinFormsApp1
{
    public class BankAccount
    {
        public string FullName { get; set; }
        public string AccountNumber { get; set; }

        public decimal Balance { get; private set; }

        public string AccountType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public BankAccount(string fullName, decimal balance, string accountType, string username, string password)
        {
            FullName = fullName;
            AccountNumber = GetAccountNumber();
            Balance = balance;
            AccountType = accountType;
            Username = username;
            Password = password;
        }
        List<Transaction> transactions { get; set; } = new List<Transaction>();
        private string GetAccountNumber()
        {
            Random digit = new Random();
            return digit.Next(10000000, 99999999).ToString();

        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Type = "Deposit",
                    Amount = amount,
                    BalanceAfter = Balance,
                });
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid Withdrawal Amount");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient Fund, make a deposit.");
            }
            else
            {
                Balance -= amount;
                transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Type = "Withdraw",
                    Amount = amount,
                    BalanceAfter = Balance,
                });
            }

        }
        public void Transfer(BankAccount receiver, decimal amount)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException("No user found");
            }
            this.Withdraw(amount);
            receiver.Deposit(amount);

            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Type = "Money Sent",
                Amount = amount,
                BalanceAfter = Balance,
            }
                );
            receiver.transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Type = "Money Received",
                Amount = amount,
                BalanceAfter = receiver.Balance,


            });



        }

    }
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public decimal BalanceAfter { get; set; }


    }
    public static class Customers
    {
        static List<BankAccount> accounts = new List<BankAccount>();

    }
}
