using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid2
{
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
    {
        public double Balance { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public double AccountNumber { get; set; }
        public string Accounttype { get; set; }
        public SavingAccount(string name , double acc,string bank, string ifsc, string branch)
        {
            Name =name;

            AccountNumber = acc;
            BankName = bank;
            IFSC = ifsc;
            Branch = branch;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void CheckBalance()
        {
            Console.WriteLine($"your balance: {Balance}");  
        }
    }
}