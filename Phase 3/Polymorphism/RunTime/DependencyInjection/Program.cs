using System;
using System.Collections.Generic;
namespace DependencyInjection;

class Program
{
    public static void Main(string[] args)
    {
        CCAccount ccAccount = new CCAccount();
        ccAccount.AccountNumber=123;
        ccAccount.Name = "Kannan";
        ccAccount.Balance=1000000000;


        SBAcccount sbAccount = new SBAcccount();
        sbAccount.AccountNumber=123;
        sbAccount.Name = "Kannan";
        sbAccount.Balance=1000000000;
       
        List<CCAccount> ccList = new List<CCAccount>();
        ccList.Add(ccAccount);

        List<SBAcccount> sbList = new List<SBAcccount>();
        sbList.Add(sbAccount);

        List<IAccount> accountList = new List<IAccount>();
        accountList.Add(ccAccount);
        accountList.Add(sbAccount);

        Console.WriteLine(accountList[0].Name);
    }
}