using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication
{
    public class CustomerDetails :PersonalDetails,IBalance
    {
        //private field
        private double _balance;
        private static int s_customerID= 1000;
        /// <summary>
        /// This property is used to store Customer ID of the customer.
        /// </summary>
        /// <value></value>
        public string CustomerID { get; }
        /// <summary>
        /// This property is used to store balance of the customer.
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;} }

        //Constructor
        /// <summary>
        /// This constructor is used to create object for the customer.
        /// </summary>
        /// <param name="balance">Contains data of balance</param>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dob"></param>
        /// <param name="mailId"></param>
        /// <param name="location"></param>
        public CustomerDetails(double balance, string name , string fatherName, Gender gender, string mobile, DateTime dob, string mailId, string location)
        {
            CustomerID = "CID" +(++s_customerID);
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB= dob;
            MailID = mailId;
            Location = location;
            _balance = balance;
        }
        /// <summary>
        /// gets customer details from csv file as string and assignn its respective values to the properties.
        /// </summary>
        /// <param name="customer"></param>
        public CustomerDetails(string customer)
        {
            string [] values = customer.Split(",");
            s_customerID = int.Parse(values[0].Remove(0,3));
            CustomerID = values[0];
            Name = values[1];
            FatherName = values[2];
            Gender = Enum.Parse<Gender>(values[3]);
            Mobile = values[4];
            DOB = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            MailID = values[6];
            Location = values[7];
            _balance = double.Parse(values[8]);
        }
        //Methods
        /// <summary>
        /// this method is used to add amount to the balance.
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }

        /// <summary>
        /// this method is used to deduct amount from the user.
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }
    }
}