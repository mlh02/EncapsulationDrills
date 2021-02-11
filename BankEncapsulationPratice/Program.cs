using System;
using System.Threading;
using BankEncapsulationPratice;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("What would you like to do?");
                
                Console.WriteLine("1 - Balance " +
                    "2 - Withdraw " +
                    "3 - Deposit " +
                    "4 - Exit ");
                int action = int.Parse(Console.ReadLine());
                if (action == 1)
                {
                    Console.WriteLine("Your Balance is: " + account.GetBalance());
                }
                if (action == 2)
                {
                    Console.WriteLine("Enter Amount to withdraw");
                    double withdrawAns = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAns);
                    Console.WriteLine("Your Balance is: " + account.GetBalance());

                }
                if (action == 3)
                {
                    Console.WriteLine("Enter Amount to Deposit");
                    double depositAns = double.Parse(Console.ReadLine());
                    account.Withdraw(depositAns);
                    Console.WriteLine("Your Balance is: " + account.GetBalance());

                }
                if (action == 4)
                {
                    i = 1001;
                }
            }
        }
    }
}
