using System;
using System.Collections.Generic;
using System.Text;

namespace eraasoft_task4.Accounts
{
    internal class TrustAccount : SavingsAccount
    {
        private int WithdrawCount = 0;

        public TrustAccount(string name = "Unnamed Trust Account",double balance = 0.0,double interestRate = 0.0)
            : base(name, balance, interestRate)
        {
        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                amount += 50;

            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if (WithdrawCount >= 3)
                return false;

            if (amount > Balance * 0.2)
                return false;

            if (base.Withdraw(amount))
            {
                WithdrawCount++;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"[Trust Account: {Name}: {Balance}, Interest Rate: {InterestRate}%]";
        }
    }
}