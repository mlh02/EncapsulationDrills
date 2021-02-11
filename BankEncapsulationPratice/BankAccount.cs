using System;
namespace BankEncapsulationPratice
{
    public class BankAccount
    {
        private double balance = 0;

        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        public double Withdraw(double amount)
        {
            return balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
