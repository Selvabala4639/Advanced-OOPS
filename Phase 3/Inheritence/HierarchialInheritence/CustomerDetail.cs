using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchial_inheritence
{
    public class CustomerDetail : PersonalDetail
    {
        private static int s_customerID;
        public string CustomerID { get; }
        //public string CustomerName { get; set; }
        public int Balance { get; set; }

        public CustomerDetail(string userID,string userName, string fatherName, Gender gender, string phoneNumber,int balance):base( userID, userName,  fatherName,  gender,  phoneNumber)
        {
            CustomerID = "CID" +(++s_customerID);
            Balance = balance;
        }
    }
}