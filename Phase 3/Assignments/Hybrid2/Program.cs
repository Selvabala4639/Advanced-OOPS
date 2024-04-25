using System;
namespace Hybrid2;
class Program
{
    public static void Main(string[] args)
    {
        SavingAccount saving = new SavingAccount("Selva", 23423432,"HDFC", "HDFC2379", "West");
        saving.Deposit(200);
        saving.CheckBalance();

        SavingAccount saving1 = new SavingAccount("avi", 234234334,"HDFC", "HDFC2379", "West");
        saving1.Deposit(4000);
        saving1.CheckBalance();
    }
}