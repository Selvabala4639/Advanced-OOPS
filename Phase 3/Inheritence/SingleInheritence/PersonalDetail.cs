using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Single_inheritence
{
    public enum Gender{Select, Male, Felame, Transgender}
    public class PersonalDetail
    {
        private static int s_userID = 1000;
        public string UserID { get;  }
        public string UserName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public PersonalDetail(string userName, string fatherName, Gender gender, string phoneNumber)
        {
            s_userID++;
            UserID = "SF"+s_userID;
            UserName= userName;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }

        public PersonalDetail(string userID,string userName, string fatherName, Gender gender, string phoneNumber)
        {
            UserID = userID;
            UserName= userName;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }
    }
}