using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal class BankAccount
    {
        string? AccountNumber;
        private decimal Balance;
        public BankAccount(string accountNumber, int Balance) { this.AccountNumber = accountNumber; this.Balance = Balance; }
        public BankAccount() { AccountNumber = "1234567890"; Balance = 0; }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount) { this.Balance -= amount; }
        public void PrintBalance()
        {
            Console.WriteLine($"Текущий баланс: {Balance}");
        }
    }
}
