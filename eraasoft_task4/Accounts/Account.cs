using System;
using System.Collections.Generic;
using System.Text;

namespace eraasoft_task4.Accounts
{
    internal class Account
    {
        public string Name { get; set; }// Convert it to prop Done
        public double Balance { get; set; } // Convert it to prop Done

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            Name = name;
            Balance = balance;
        }

        public virtual bool Deposit(double amount) // virtual allows derived classes to override 
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return $"[Account: {Name}: {Balance}]";
        }

    }
}
