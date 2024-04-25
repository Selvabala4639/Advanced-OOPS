using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public class Hack :EmployeeInfo
    {
        //StoreUserID, StorePassword
        public string StoreUserID { get; set; }
        public string StorePassword { get; set; }
        //ShowKeyInfo, GetUserInfo, ShowUserInfo
        public void ShowKeyInfo()
        {
            Console.WriteLine($"Key info: {KeyInfo}");
            
        }
        public void GetUserInfo()
        {
            Console.Write($"UserID: ");
            Console.Write($"Password: ");
        }

        public void ShowUserInfo()
        {

        }
    }
}