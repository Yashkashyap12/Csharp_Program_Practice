using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDepositChecking_Program_in_C_
{
    using System;

    namespace BankingSystem
    {
        class BankAccount
        {
            public string AccountHolder { get; set; }
            public decimal Balance { get; private set; }

            public BankAccount(string accountHolder, decimal initialBalance)
            {
                AccountHolder = accountHolder;
                Balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
            }

            public void Withdraw(decimal amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew {amount:C}. Remaining Balance: {Balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance!");
                }
            }

            public void DisplayBalance()
            {
                Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Account Holder Name:");
                string name = Console.ReadLine();

                BankAccount account = new BankAccount(name, 0); // Initial balance of 1000
                account.DisplayBalance();

                Console.WriteLine("Enter amount to deposit:");
                decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                account.Deposit(depositAmount);

                Console.WriteLine("Enter amount to withdraw:");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(withdrawAmount);

                account.DisplayBalance();
                Console.ReadLine();
            }
        }
    }
}
