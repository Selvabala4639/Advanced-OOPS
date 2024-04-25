using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public sealed class EmployeeInfo
    {
        //UserID, Password, KeyInfo = 100
        private static int s_userID=2000;
        public string UserID { get; set; }
        public string Password { get; set; }
        public int KeyInfo =100;
        public EmployeeInfo()
        {
            UserID = "UID" +(++s_userID);
        }
        public void UpdateInfo()
        {
            Console.Write($"Enter Password");
            Password = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"User ID: {UserID}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"KeyInfo: {KeyInfo}");
        }
    }
}