using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulateBankDetails
{
    public class AccountInfo : PersonalInfo
    {
        //AccountNumber, BranchName, IFSCCode, Balance
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public int Balance { get; set; }

        public AccountInfo(string name, string fatherName, string phone ,string mail, DateTime dob, string gender, string accountNumber, string branch, string Code, int balance):base( name,  fatherName,  phone , mail,  dob,  gender)
        {
            AccountNumber= accountNumber;
            BranchName= branch;
            IFSCCode = Code;
            Balance = balance;
        }

        //Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.

        public void ShowAccountInfo()
        {
            Console.WriteLine($"Name: {Name}\nFatherName: {FatherName}\nPhone: {Phone}\nMail: {Mail}\nDOB: {DOB}\nGender: {Gender}\nAccountNumber: {AccountNumber}\nBranchName: {BranchName}\nIFSCCode: {IFSCCode}\nBalance: {Balance}");

        }
        public void Deposit(int amount)
        {
                Balance+=amount;
                
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance: {Balance}");
        }

    }
}