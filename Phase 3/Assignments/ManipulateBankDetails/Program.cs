using System;
using System.Collections.Generic;
namespace ManipulateBankDetails;
class Program
{
    public static void Main(string[] args)
    {
        List<PersonalInfo> personalList = new List<PersonalInfo>();
        List<AccountInfo> accountList = new List<AccountInfo>();
        PersonalInfo personal = new PersonalInfo("Selva", "Vel", "9024976614", "selva@gamil", new DateTime(2001,11,22),"male");
        PersonalInfo personal2 = new PersonalInfo("Selva", "Vel", "9024976614", "selva@gamil", new DateTime(2001,11,22),"male");
        PersonalInfo personal3 = new PersonalInfo("Selva", "Vel", "9024976614", "selva@gamil", new DateTime(2001,11,22),"male");
        personalList.Add(personal);
        personalList.Add(personal2);
        personalList.Add(personal3);
        AccountInfo account1 = new AccountInfo(personal.Name, personal.FatherName, personal.Phone, personal.Mail,personal.DOB,personal.Gender,      "463342343221","5005","HDFC1001",1000);
        AccountInfo account2 = new AccountInfo(personal2.Name, personal2.FatherName, personal2.Phone, personal2.Mail,personal2.DOB,personal2.Gender,"463342343298","5005","HDFC1001",2000);
        AccountInfo account3 = new AccountInfo(personal3.Name, personal3.FatherName, personal3.Phone, personal3.Mail,personal3.DOB,personal3.Gender,"463342343257","5005","HDFC1001",3000);
        
        accountList.Add(account1);
        accountList.Add(account2);
        accountList.Add(account3);
        int count =1;
        foreach(AccountInfo account in accountList)
        {
            Console.WriteLine($"********Customer {count}**********");
            count++;
            Console.Write($"Enter amount to Deposit: ");
            int amount = int.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.Write($"Enter amount to withdraw: ");
             amount = int.Parse(Console.ReadLine());
            account.Withdraw(amount);
            account.ShowAccountInfo();
            account.ShowBalance();
        }
        
        
    }
}
