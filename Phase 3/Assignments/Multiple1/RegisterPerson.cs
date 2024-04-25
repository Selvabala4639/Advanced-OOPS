using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple1
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {
        //RegistrationNumber(Auto), DateOfRegistration,
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int Siblings { get; set; }

        public RegisterPerson(string name, string gender, DateTime dob, string phone, string status,string fathername, string mothername, string address, int siblings,DateTime dor):base( name,  gender,  dob,  phone,  status)
        {
            RegisterNumber ="RID"+(++s_registerNumber);
            DateOfRegistration= dor;
            FatherName = fathername;
            MotherName = mothername;
            HouseAddress = address;
            Siblings = siblings;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Father name: {FatherName}");
            Console.WriteLine($"Mother name: {MotherName}");
            Console.WriteLine($"HouseAddress: {HouseAddress}");
            Console.WriteLine($"Siblings: {Siblings}");
            Console.WriteLine($"RegisterNumber: {RegisterNumber}");
            Console.WriteLine($"DateOfRegistration: {DateOfRegistration}");
        }
    }
}