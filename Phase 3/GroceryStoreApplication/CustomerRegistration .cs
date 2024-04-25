using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        //CustomerID {Auto Increment – CID1000}, WalletBalance

        private static int s_customerID = 1000;
        public string CustomerID { get; }
        public double WalletBalance { get; set; }

        public CustomerDetails(string name , string fatherName, Gender gender, string mobile, DateTime dob, string mailID,double balance):base( name ,  fatherName,  gender,  mobile,  dob,  mailID)
        {
            CustomerID = "CID"+(++s_customerID);
            WalletBalance = balance;
        }

        public void WalletRecharge(double amount)
        {
            WalletBalance += amount;
        }
    }
}