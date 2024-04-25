using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class UserDetails :PersonalDetails, IBalance
    {
        /// <summary>
        /// Private field is used to auto inccrement card number.
        /// </summary> <summary>
        /// 
        /// </summary>
        private static int s_cardNumber=1000;
        /// <summary>
        /// Used to store card Number.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string CardNumber { get;  }
        /// <summary>
        /// used to store balance of the user.
        /// </summary>
        /// <value></value>
        public double Balance { get; set; }

        /// <summary>
        /// constructor used to create object for the user.
        /// </summary>
        /// <param name="userName">Contains name of the user</param>
        /// <param name="phoneNumber">Contains phone number of the user</param>
        /// <param name="balance"></param>Contains balance of the user <summary>
        /// 
        /// </summary>
           public UserDetails(string userName , string phoneNumber, double balance)
        {
            CardNumber = "CMRL"+(++s_cardNumber);
            UserName= userName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }
        /// <summary>
        /// get User details as string from csv file and assign its respective values to the properties by splitting.
        /// </summary>
        /// <param name="user">contains user details as string.</param> <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user)
        {
            string [] values = user.Split(",");
            s_cardNumber = int.Parse(values[0].Remove(0,4));
            CardNumber = values[0];
            UserName= values[1];
            PhoneNumber = values[2];
            Balance = double.Parse(values[3]);
        }
        /// <summary>
        /// this method is used to add amount to the user balance.
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            Balance += amount;
        }
        /// <summary>
        /// this method is used to deduct amount to the user balance.
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount)
        {
            Balance -= amount;
        }
    }
}