using System;
using System.Collections.Generic;
using System.Text;

namespace eraasoft_task4.Accounts
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string name = "Unnamed Savings Account",double balance = 0.0, double interestRate = 0.0)
            : base(name, balance)
        {
            InterestRate = interestRate;
        }
        public override bool Deposit(double amount)  
        {
            if (amount < 0)
                return false;

            amount += amount * (InterestRate / 100);

            return base.Deposit(amount);
        }
        /* withdraw method مش هتتكب لانها موجودة ف
          ال base class 
        و مش هتتغير ف
          ال derived class*/
        public override string ToString()
        {
            return $"[Savings Account: {Name}: {Balance}, Interest Rate: {InterestRate}%]";
        }
    }
}
