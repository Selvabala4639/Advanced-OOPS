using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    public class UserDetails :PersonalDetails, IWallet
    {
        /// <summary>
        /// this private field autoincrement the user id.
        /// </summary> <summary>
        /// 
        /// </summary>
        private static int s_userID = 1000;
        private double _balance;
        /// <summary>
        /// Used to store user ID.
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        ///  Used to store Wallet balance.
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;}  }
        /// <summary> 
        ///  This constructor is used to create object for user details.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        /// <param name="balance"></param> <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public UserDetails(string name, int age, string city, string phone, double balance):base( name,  age,  city,  phone)
        {
            UserID ="UID"+(++s_userID);
             Name= name;
            Age = age;
            City  = city;
            PhoneNumber = phone;
            _balance= balance;
        }
        /// <summary>
        /// Gets the data as string and split those strings and store it in respective properties.
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            s_userID = int.Parse(values[0].Remove(0,3));
            UserID =values[0];
            Name= values[1];
            Age = int.Parse(values[2]);
            City  = values[3];
            PhoneNumber = values[4];
            _balance= int.Parse(values[5]);
        }
        /// <summary>
        /// This method is used to reduce amount from the balance.
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void DetuctBalance(double amount)
        {
            _balance -= amount;
        }
        /// <summary>
        ///  This method is used to recharge amount from the balance.
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }

    }
}