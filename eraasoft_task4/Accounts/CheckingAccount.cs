using System;

namespace eraasoft_task4.Accounts
{
    internal class CheckingAccount : Account
    {
        private const double Fee = 1.50;
        //private علشان محدش يوصلها بسهوله
        // const علشان محدش يغيرها


        public CheckingAccount(string name = "Unnamed Checking Account", double balance = 0.0)
            : base(name, balance)
        {
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
            
        }

        public override string ToString()
        {
            return $"[Checking Account: {Name}: {Balance}]";
        }
    }
}
