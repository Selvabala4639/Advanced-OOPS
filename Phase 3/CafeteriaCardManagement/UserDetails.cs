using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class UserDetails : PersonalDetails,IBalance
    {
        //UserID (Auto – SF1001)
        // •	WorkStationNumber
        // •	Field: _balance
        // •	Read only property: WalletBalance.

        private static int s_userID=1000;
        public string UserID { get;  }
        public string WorkStationNumber { get; set; }
        private double _balance { get; set; }
        public double WalletBalance { get{return _balance;}  }

        public UserDetails(string workStationNumber, int balance,string name, string fatherName, Gender gender, string mobile, string mailId):base( name,  fatherName,  gender,  mobile,  mailId)
        {
            UserID = "SF"+ (++s_userID);
            WorkStationNumber = workStationNumber;
            _balance = balance;
        }
        public void WalletRecharge(double amount)
        {
            _balance +=amount;
        }
        public void DeductAmount(double amount)
        {
            _balance-=amount;
        }
    }
}