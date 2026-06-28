using System;
using System.Collections.Generic;
using System.Text;

namespace eraasoft_task4.Accounts
{
    internal class AccountUtil
    {
        public static void Display<T>(List<T> accounts) where T : Account     // Generic method to display account information 
            // سالت شات عليها وهي افضل بكتير من اني اكرر الكود 4 مرات  
            // ودا تطبيق لل polymorphism 
            // بتكون الليست فيها كل انواع الاكاونتس سواء كانت SavingAccount او CheckingAccount او Account
        {
            Console.WriteLine("\n=== Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit<T>(List<T> accounts, double amount) where T : Account
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw<T>(List<T> accounts, double amount) where T : Account
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
}