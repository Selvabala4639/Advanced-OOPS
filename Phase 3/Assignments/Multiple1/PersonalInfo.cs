using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple1
{
    public class PersonalInfo: IShowData
    {
        //Name, Gender,DOB, phone, mobile, Marital details – Married/single
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string MaritalStatus { get; set; }

        public PersonalInfo(string name, string gender, DateTime dob, string phone, string status)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone; 
            MaritalStatus = status;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Gender}");
            Console.WriteLine($"{DOB}");
            Console.WriteLine($"{Phone}");
            Console.WriteLine($"{MaritalStatus}");
            
        }
    }
}